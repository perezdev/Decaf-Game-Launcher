using System.Drawing;
using System.IO;

namespace Decaf_Game_Launcher.Games
{
    public class Game
    {
        public string Name { get; set; }
        public string ProductID { get; set; }
        public string CompanyCode { get; set; }
        public string CoverArtFileName { get { return $@"{GameDirectory.FullName}\{Name}_Cover.png"; } }
        public DirectoryInfo GameDirectory { get; set; }
        public Image CoverArtImage { get; set; }
    }
}
