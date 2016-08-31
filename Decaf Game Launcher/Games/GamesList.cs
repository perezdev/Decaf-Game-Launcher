using Decaf_Game_Launcher.Settings;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;


namespace Decaf_Game_Launcher.Games
{
    public class GamesList
    {
        public delegate void MessageUpdateEventHandler(object source, string e);
        public event MessageUpdateEventHandler OnMessageUpdate;

        public delegate void GameAddedEventHandler(object source, Game e);
        public event GameAddedEventHandler OnGameAdded;

        public delegate void GameAddingCompleteEventHandler(object source);
        public event GameAddingCompleteEventHandler OnGameAddingComplete;

        private List<Game> Games { get; set; } = new List<Game>();
        private List<GameDirectoryInfo> GameDirectoryInfoList { get; set; } = new List<GameDirectoryInfo>();

        public List<Game> GetGames(List<GameRootDirectory> extraGameDirectories)
        {
            UpdateMessage("Getting intial game data...");

            GameDirectoryInfoList = new List<GameDirectoryInfo>();
            SetGameDirectoryInfoListRecursively(Environment.CurrentDirectory);
            foreach (GameRootDirectory directory in extraGameDirectories.Where(x => x.Enabled).ToList())
                SetGameDirectoryInfoListRecursively(directory.Directory);

            int toAddCount = 0;

            foreach (GameDirectoryInfo info in GameDirectoryInfoList)
            {
                toAddCount = toAddCount + 1;
                UpdateMessage($"Adding games: {toAddCount.ToString()} of {GameDirectoryInfoList.Count.ToString()}");
                SetGames(info);
            }

            UpdateMessage("Ready");

            if (OnGameAddingComplete != null)
                OnGameAddingComplete(this);

            return Games;
        }
        private void UpdateMessage(string message)
        {
            if (OnMessageUpdate != null)
                OnMessageUpdate(this, message);
        }
        private void SetGames(GameDirectoryInfo info)
        {
            try
            {
                string[] data = GetGameDataFromMetaXmlFile(info.MetaXml);

                Game game = new Game()
                {
                    Name = data[0],
                    ProductID = data[1],
                    CompanyCode = data[2],
                    Publisher = data[3],
                    GameDirectory = info.RootDirectory,
                    GameSize = GetReadableDirectorySizeFromBytes(GetDirectorySizeInBytes(info.RootDirectory))
                };

                if (Games.Where(x => x.ProductID == game.ProductID && x.CompanyCode == game.CompanyCode).Count() == 0) //Don't add duplicate games
                {
                    string productID = game.ProductID.Substring(game.ProductID.Length - 4);
                    string companyCode = game.CompanyCode.Substring(game.CompanyCode.Length - 2);

                    game.BoxArtURL = $"http://www.gametdb.com/WiiU/{productID}{companyCode}";

                    try
                    {
                        game.BannerImage = Paloma.TargaImage.LoadTargaImage($@"{info.MetaDirectory.FullName}\bootDrcTex.tga");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Get BannerImage error: {ex.Message}");
                    }

                    if (File.Exists(game.BoxArtFileName))
                        game.BoxArtImage = Image.FromFile(game.BoxArtFileName);
                    else
                    {
                        DownloadBoxArt(game);

                        if (File.Exists(game.BoxArtFileName))
                            game.BoxArtImage = Image.FromFile(game.BoxArtFileName);
                        else
                            game.BoxArtImage = null;
                    }

                    Games.Add(game);
                    if (OnGameAdded != null)
                        OnGameAdded(this, game);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        private void SetGameDirectoryInfoListRecursively(string root)
        {
            foreach (DirectoryInfo directory in new DirectoryInfo(root).GetDirectories())
            {
                DirectoryInfo[] directories = directory.GetDirectories();

                GameDirectoryInfo info = new GameDirectoryInfo();
                info.RootDirectory = directory;
                info.CodeDirectory = directories.SingleOrDefault(x => x.Name.ToLower() == "code");
                info.ContentDirectory = directories.SingleOrDefault(x => x.Name.ToLower() == "content");
                info.MetaDirectory = directories.SingleOrDefault(x => x.Name.ToLower() == "meta");
                info.CosXml = info.CodeDirectory == null ? null : new FileInfo($@"{info.CodeDirectory.FullName}\cos.xml");
                info.AppXml = info.CodeDirectory == null ? null : new FileInfo($@"{info.CodeDirectory.FullName}\app.xml");
                info.MetaXml = info.MetaDirectory == null ? null : new FileInfo($@"{info.MetaDirectory.FullName}\meta.xml");

                if (info.CodeDirectory != null && info.ContentDirectory != null && info.MetaDirectory != null)
                {

                    if (info.CosXml.Exists && info.AppXml.Exists && info.MetaXml.Exists)
                        GameDirectoryInfoList.Add(info);
                }
                else
                {
                    SetGameDirectoryInfoListRecursively(directory.FullName);
                }

            }
        }
        private string[] GetGameDataFromMetaXmlFile(FileInfo metaFile)
        {
            string[] data = new string[4];

            byte[] encodedString = Encoding.UTF8.GetBytes(File.ReadAllText(metaFile.FullName)); //meta.xml is encoded as utf-8 instead of the default utf-16
            using (MemoryStream ms = new MemoryStream(encodedString))
            {
                ms.Flush();
                ms.Position = 0;

                var xml = new XmlDocument();
                xml.Load(ms);
                XmlNode nameNode = xml.DocumentElement.SelectSingleNode("/menu/longname_en");
                XmlNode productIdNode = xml.DocumentElement.SelectSingleNode("/menu/product_code");
                XmlNode companyCode = xml.DocumentElement.SelectSingleNode("/menu/company_code");
                XmlNode publisher = xml.DocumentElement.SelectSingleNode("/menu/publisher_en");

                if (nameNode != null)
                    data[0] = nameNode.InnerText;
                if (productIdNode != null)
                    data[1] = productIdNode.InnerText;
                if (companyCode != null)
                    data[2] = companyCode.InnerText;
                if (publisher != null)
                    data[3] = publisher.InnerText;
            }

            return data;
        }
        private void DownloadBoxArt(Game game)
        {
            string html = GetGameTdbPageHtml(game);
            if (!string.IsNullOrEmpty(html))
            {
                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(html);

                string[] imgs = htmlDocument.DocumentNode.Descendants("a").Select(a => a.GetAttributeValue("href", null)).Where(u => !string.IsNullOrEmpty(u)).Distinct().ToArray();
                DownloadBoxArtImageFromGameTdb(imgs.Where(x => x.ToLower().Contains("coverm")).First(), game.BoxArtFileName);
            }
        }
        public virtual string FixHtmlCharacters(string html)
        {
            html = html.Replace("&quot;", "\"");
            html = html.Replace("&#8217;", "'");
            html = html.Replace("&#39;", "'");
            html = html.Replace("&#039;", "'");
            html = html.Replace("&#33;", "!");
            html = html.Replace("&#38;", "&");
            html = html.Replace("&amp;", "&");
            html = html.Replace("&#8211;", "-");
            html = html.Replace("&quot;", "-");
            html = html.Replace("&#x27;", "'");
            html = html.Replace("&laquo;", "«");

            html = html.Trim();

            return html;
        }
        private string GetGameTdbPageHtml(Game game)
        {
            string html = string.Empty;

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add(HttpRequestHeader.UserAgent, "DecafEmuGameLauncher");
                    client.Encoding = Encoding.UTF8;
                    html = client.DownloadString(game.BoxArtURL);
                }
            }
            catch (Exception ex)
            {
                string errors = ex.Message;
            }

            return html;
        }
        private void DownloadBoxArtImageFromGameTdb(string url, string filename)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add(HttpRequestHeader.UserAgent, "DecafEmuGameLauncher");
                    client.Encoding = Encoding.UTF8;
                    client.DownloadFile(url, filename);
                }
            }
            catch (Exception ex)
            {
                string errors = ex.Message;
            }
        }
        private long GetDirectorySizeInBytes(DirectoryInfo d)
        {

            long size = 0;
            try
            {
                // Add file sizes.
                FileInfo[] fis = d.GetFiles();
                foreach (FileInfo fi in fis)
                {
                    size += fi.Length;
                }
                // Add subdirectory sizes.
                DirectoryInfo[] dis = d.GetDirectories();
                foreach (DirectoryInfo di in dis)
                {
                    size += GetDirectorySizeInBytes(di);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"GetDirectorySizeInBytes error: {ex.Message}");
            }

            return size;
        }
        private string GetReadableDirectorySizeFromBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return string.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }
    }
}
