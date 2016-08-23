using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decaf_Game_Launcher.Decaf
{
    public class DecafEmulator
    {
        public void PlayGame(string gameDirectory)
        {
            PlayGameInternal(gameDirectory, GetDecafExecutablePathAutomatically());
        }
        public void PlayGame(string gameDirectory, string decafExecutablePath)
        {
            PlayGameInternal(gameDirectory, decafExecutablePath);
        }
        private string GetDecafExecutablePathAutomatically()
        {
            string path = string.Empty;

            var allFiles = Directory.GetFiles(Environment.CurrentDirectory, "decaf-sdl.exe", SearchOption.AllDirectories);

            if (allFiles != null)
                path = allFiles[0];

            return path;
        }
        private void PlayGameInternal(string gameDirectory, string decafExecutablePath)
        {
            if (!File.Exists(decafExecutablePath))
                throw new Exception($"Decaf executable was not found: {decafExecutablePath}");

            using (Process p = new Process())
            {
                p.StartInfo = new ProcessStartInfo()
                {
                    FileName = decafExecutablePath,
                    Arguments = $"play \"{gameDirectory}\"",
                };

                p.Start();
            };
        }
    }
}
