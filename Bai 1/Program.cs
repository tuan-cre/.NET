using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai01;
using Bai02;
using Bai03;
using Bai04;

//namespace Bai01
//{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new FormBai01());
        Application.Run(new FormBai02());
        Application.Run(new FormBai03());
        Application.Run(new FormBai04());
    }
}
//}
