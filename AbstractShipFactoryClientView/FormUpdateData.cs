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
    public partial class FormUpdateData : Form
    {
        public FormUpdateData()
        {
            InitializeComponent();
            textBoxLogin.Text = Program.Client.Login;
            textBoxFIO.Text = Program.Client.FIO;
            textBoxPassword.Text = Program.Client.Password;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxLogin.Text) &&
            !string.IsNullOrEmpty(textBoxFIO.Text) &&
            !string.IsNullOrEmpty(textBoxPassword.Text))
            {
                if (textBoxLogin.Text != Program.Client.Login
                || textBoxPassword.Text != Program.Client.Password
                || textBoxFIO.Text != Program.Client.FIO)
                {
                    try
                    {
                        APIClient.PostRequest("api/client/updatedata", new ClientBindingModel
                        {
                            Id = Program.Client.Id,
                            Login = textBoxLogin.Text,
                            Password = textBoxPassword.Text,
                            FIO = textBoxFIO.Text
                        });
                        MessageBox.Show("Обновление прошло успешно", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.Client.FIO = textBoxFIO.Text;
                        Program.Client.Login = textBoxLogin.Text;
                        Program.Client.Password = textBoxPassword.Text;
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
                    MessageBox.Show("Новые данные совпадают со старыми", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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