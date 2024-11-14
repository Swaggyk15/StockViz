using System;
using System.Windows.Forms;

namespace COP_4365
{
    internal static class Program
    {
        // The main entry point that starts the application

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStockLoader());
        }
    }
}