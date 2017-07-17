using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shuffle_Game
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
            Application.Run(new Form1(100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000
                , 10000000, 10000000, 10000000, 10000000, 10000000, 10000000, 10000000, 10000000, 10000000, 10000000
                ,"clear", "clear", "clear", "clear", "clear", "clear", "clear", "clear", "clear", "clear"
                , "clear", "clear", "clear", "clear", "clear", "clear", "clear", "clear", "clear", "clear"
                ,false));
        }
    }
}
