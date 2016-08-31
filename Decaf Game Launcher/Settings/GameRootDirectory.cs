using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decaf_Game_Launcher.Settings
{
    public class GameRootDirectory
    {
        public Guid GameDirectoryID { get; set; }
        public bool Enabled { get; set; }
        public string Directory { get; set; }
    }
}
