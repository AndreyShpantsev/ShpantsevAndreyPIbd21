using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbstractShipFactoryBusinessLogic.ViewModels;

namespace AbstractShipFactoryClientView
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            Program.Client = null;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegister form = new FormRegister();
            form.ShowDialog();
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxLogin.Text) &&
                !string.IsNullOrEmpty(textBoxPassword.Text))
            {
                try
                {
                    Program.Client = APIClient.GetRequest<ClientViewModel>
                        ($"api/client/login?login={ textBoxLogin.Text }" +
                        $"&password={ textBoxPassword.Text }");
                    Close();
                }
                catch (AggregateException ex)
                {
                    foreach (var errInner in ex.InnerExceptions)
                    {
                        Debug.WriteLine(errInner);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
