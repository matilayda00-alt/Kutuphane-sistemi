using System;
using System.Windows.Forms;

namespace KutuphaneTakipSistemi
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.SetDefaultFont(new Font("Segoe UI", 9.5f));
            Application.Run(new GirisFormu());
        }
    }
}
