using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuzzleBiz.Model;
using PuzzleBiz.Loader;

namespace PuzzlePr.Viewer
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
            Configuration.LoadConfiguration();
            Application.Run(new Security());

            
        }
    }
}
