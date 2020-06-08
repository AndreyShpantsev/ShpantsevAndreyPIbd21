using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AbstractShipFactoryBusinessLogic.BindingModels;

namespace AbstractShipFactoryClientView
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxLogin.Text) &&
            !string.IsNullOrEmpty(textBoxPassword.Text) &&
            !string.IsNullOrEmpty(textBoxFIO.Text))
            {
                try
                {
                    APIClient.PostRequest("api/client/register", new ClientBindingModel
                    {
                        FIO = textBoxFIO.Text,
                        Login = textBoxLogin.Text,
                        Password = textBoxPassword.Text
                    });
                    MessageBox.Show("Регистрация прошла успешно", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите логин, пароль и ФИО", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}