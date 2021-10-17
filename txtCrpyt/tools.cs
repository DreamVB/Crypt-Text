using System;
using System.Text;
using System.Diagnostics;

namespace DreamVB.Tools
{
    public static class tools
    {
        public static int ButtonPress { get; set; }
        public static string Password { get; set; }

        public static string FixPath(string Path)
        {
            if (!Path.EndsWith("\\"))
                return Path + "\\";
            return Path;
        }

        public static void WinExe(string Filename)
        {
            Process p = new Process();
            try
            {
                p.StartInfo.FileName = Filename;
                p.Start();
            }
            catch { }
        }

    }
}
