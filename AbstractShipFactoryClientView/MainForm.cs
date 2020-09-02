using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AbstractShipFactoryBusinessLogic.ViewModels;

namespace AbstractShipFactoryClientView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadOrderList();
        }
        private void LoadOrderList()
        {
            try
            {
                dataGridViewMain.DataSource =
                APIClient.GetRequest<List<OrderViewModel>>
                ($"api/main/getorders?clientid={ Program.Client.Id }");
                dataGridViewMain.Columns[0].Visible = false;
                dataGridViewMain.Columns[1].Visible = false;
                dataGridViewMain.Columns[2].Visible = false;
                dataGridViewMain.Columns[3].Visible = false;
                dataGridViewMain.Columns[4].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void ChangeDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormUpdateData();
            form.ShowDialog();
        }
        private void CreateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCreateOrder();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList();
            }
        }
        private void UpdateTheListOfOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }
    }
}
