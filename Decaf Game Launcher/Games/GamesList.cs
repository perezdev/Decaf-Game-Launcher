using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Decaf_Game_Launcher.Games
{
    public class GamesList
    {
        public delegate void MessageUpdateEventHandler(object source, string e);
        public event MessageUpdateEventHandler OnMessageUpdate;

        private List<Game> Games { get; set; } = new List<Game>();

        public List<Game> GetGames()
        {
            SearchDirectoriesRecursivelyForGames(Environment.CurrentDirectory);

            UpdateMessage("Ready");

            return Games;
        }
        private void UpdateMessage(string message)
        {
            if (OnMessageUpdate != null)
                OnMessageUpdate(this, message);
        }
        private void SearchDirectoriesRecursivelyForGames(string root)
        {
            foreach (DirectoryInfo directory in new DirectoryInfo(root).GetDirectories())
            {
                DirectoryInfo[] directories = directory.GetDirectories();
                DirectoryInfo codeDirtectory = directories.SingleOrDefault(x => x.Name.ToLower() == "code");
                DirectoryInfo contentDirectory = directories.SingleOrDefault(x => x.Name.ToLower() == "content");
                DirectoryInfo metaDirectory = directories.SingleOrDefault(x => x.Name.ToLower() == "meta");

                if (codeDirtectory != null && contentDirectory != null && metaDirectory != null)
                {
                    string cosXml = $@"{codeDirtectory.FullName}\cos.xml";
                    string appXml = $@"{codeDirtectory.FullName}\app.xml";
                    string metaXml = $@"{metaDirectory.FullName}\meta.xml";

                    if (File.Exists(cosXml) && File.Exists(appXml) && File.Exists(metaXml))
                    {
                        try
                        {
                            string[] data = GetGameDataFromMetaXmlFile(metaXml);

                            Game game = new Game()
                            {
                                Name = data[0],
                                ProductID = data[1],
                                CompanyCode = data[2],
                                GameDirectory = directory
                            };

                            UpdateMessage($"Found {game.Name}. Loading cover art...");

                            if (File.Exists(game.CoverArtFileName))
                                game.CoverArtImage = Image.FromFile(game.CoverArtFileName);
                            else
                            {
                                UpdateMessage($"Cover art wasn't found. Downloading from GameTDB...");
                                DownloadCoverArt(game);

                                if (File.Exists(game.CoverArtFileName))
                                    game.CoverArtImage = Image.FromFile(game.CoverArtFileName);
                                else
                                    game.CoverArtImage = null;
                            }

                            Games.Add(game);
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message);
                        }
                    }
                }
                else
                {
                    SearchDirectoriesRecursivelyForGames(directory.FullName);
                }
            }
        }
        private string[] GetGameDataFromMetaXmlFile(string metaFile)
        {
            string[] data = new string[3];

            byte[] encodedString = Encoding.UTF8.GetBytes(File.ReadAllText(metaFile)); //meta.xml is encoded as utf-8 instead of the default utf-16
            using (MemoryStream ms = new MemoryStream(encodedString))
            {
                ms.Flush();
                ms.Position = 0;

                var xml = new XmlDocument();
                xml.Load(ms);
                XmlNode nameNode = xml.DocumentElement.SelectSingleNode("/menu/longname_en");
                XmlNode productIdNode = xml.DocumentElement.SelectSingleNode("/menu/product_code");
                XmlNode companyCode = xml.DocumentElement.SelectSingleNode("/menu/company_code");

                if (nameNode != null)
                    data[0] = nameNode.InnerText;
                if (productIdNode != null)
                    data[1] = productIdNode.InnerText;
                if (companyCode != null)
                    data[2] = companyCode.InnerText;
            }

            return data;
        }
        private void DownloadCoverArt(Game game)
        {
            string html = GetGameTdbPageHtml(game);
            if (!string.IsNullOrEmpty(html))
            {
                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(html);

                string[] imgs = htmlDocument.DocumentNode.Descendants("a").Select(a => a.GetAttributeValue("href", null)).Where(u => !string.IsNullOrEmpty(u)).Distinct().ToArray();
                DownloadCoverArtImageFromGameTdb(imgs.Where(x => x.ToLower().Contains("coverm")).First(), game.CoverArtFileName);
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
                string productID = game.ProductID.Substring(game.ProductID.Length - 4);
                string companyCode = game.CompanyCode.Substring(game.CompanyCode.Length - 2);

                string url = $"http://www.gametdb.com/WiiU/{productID}{companyCode}";

                using (WebClient client = new WebClient())
                {
                    client.Headers.Add(HttpRequestHeader.UserAgent, "DecafEmuGameLauncher");
                    client.Encoding = Encoding.UTF8;
                    html = client.DownloadString(url);
                }
            }
            catch(Exception ex)
            {
                string errors = ex.Message;
            }

            return html;
        }
        private void DownloadCoverArtImageFromGameTdb(string url, string filename)
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
    }
}
