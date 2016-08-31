using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace Decaf_Game_Launcher.Games
{
    public class Game
    {
        public string Name { get; set; }
        public string ProductID { get; set; }
        public string CompanyCode { get; set; }
        public string Publisher { get; set; }
        public string BoxArtFileName { get { return $@"{GameDirectory.FullName}\{RemoveSpecialCharacters(Name)}_BoxArt.png"; } }
        public Image BannerImage { get; set; }
        public DirectoryInfo GameDirectory { get; set; }
        public Image BoxArtImage { get; set; }
        public string GameSize { get; set; }
        public string BoxArtURL { get; set; }

        private string RemoveSpecialCharacters(string input)
        {
            Regex r = new Regex("(?:[^a-z0-9 ]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            return r.Replace(input, string.Empty);
        }
    }
}
