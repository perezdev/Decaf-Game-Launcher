using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decaf_Game_Launcher.Games
{
    public class GameDirectoryInfo
    {
        public DirectoryInfo RootDirectory { get; set; }
        public DirectoryInfo CodeDirectory { get; set; }
        public DirectoryInfo ContentDirectory { get; set; }
        public DirectoryInfo MetaDirectory { get; set; }
        public FileInfo CosXml { get; set; }
        public FileInfo AppXml { get; set; }
        public FileInfo MetaXml { get; set; }
    }
}
