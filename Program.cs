using ControleRevendaWF.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleRevendaWF
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadingScreen loadingScreen = new LoadingScreen();
            Application.Run(loadingScreen);
            if (loadingScreen.isOpen)
                Application.Run(new Home());

        }
    }
}
