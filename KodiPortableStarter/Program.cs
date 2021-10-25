using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace KodiPortableStarter
{
    class Program
    {
        public static string folder = "Kodi";
        public static string app = "kodi.exe";

        static void Main(string[] args)
        {
            Process p = new Process();
            p.StartInfo.FileName = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), folder, app);
            p.StartInfo.Arguments = "-p";
            p.Start();
        }
    }
}
