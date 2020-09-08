using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbstractShipFactoryBusinessLogic.ViewModels;

namespace AbstractShipFactoryClientView
{
    static class Program
    {
        public static ClientViewModel Client { get; set; }

        [STAThread]
        static void Main()
        {
            APIClient.Connect();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new FormLogin();
            form.ShowDialog();
            if (Client != null)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
