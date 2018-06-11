using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(alreadyImported())
                Application.Run(new mapForm());
            else
                Application.Run(new yaWelcome());
        }

        static bool alreadyImported() {
            string MapsPath = AppDomain.CurrentDomain.BaseDirectory + "Maps";
            if (!System.IO.Directory.Exists(MapsPath)) {
                return false;
            }
            System.IO.Directory.CreateDirectory(MapsPath);
            String[] directories = Directory.GetDirectories(MapsPath);
            for (int i = 0; i < directories.Length; i++) {
                if (!File.Exists(directories[i] + "/Rooms.shp") ||
                    !File.Exists(directories[i] + "/Coverage.shp") ||
                    !File.Exists(directories[i] + "/Beacons.shp")) {
                    return false;
                }
            }
            return true;
        }
    }
}
