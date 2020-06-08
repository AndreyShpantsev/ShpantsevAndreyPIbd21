﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbstractShipFactoryBusinessLogic.BindingModels;
using AbstractShipFactoryBusinessLogic.BusinessLogics;
using AbstractShipFactoryBusinessLogic.Interfaces;
using AbstractShipFactoryBusinessLogic.ViewModels;
using Unity;

namespace AbstractShipFactoryView
{
    public partial class FormCreateOrder : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IShipLogic shiplogic;
        private readonly IClientLogic clientLogic;
        private readonly MainLogic logicMain;
        public FormCreateOrder(IShipLogic logicP, IClientLogic logicC, MainLogic logicM)
        {
            InitializeComponent(); 
            this.shiplogic = logicP;
            this.clientLogic = logicC;
            this.logicMain = logicM;
        }

        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            try
            {
                List<ShipViewModel> list = shiplogic.Read(null);
                if (list != null)
                {
                    comboBoxShip.DisplayMember = "ShipName";
                    comboBoxShip.ValueMember = "Id";
                    comboBoxShip.DataSource = list;
                    comboBoxShip.SelectedItem = null;
                }
                List<ClientViewModel> clientList = clientLogic.Read(null);
                if (clientList != null)
                {
                    comboBoxClient.DisplayMember = "Login";
                    comboBoxClient.ValueMember = "Id";
                    comboBoxClient.DataSource = clientList;
                    comboBoxClient.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void CalcSum()
        {
            if (comboBoxShip.SelectedValue != null &&
           !string.IsNullOrEmpty(textBoxCount.Text))
            {
                try
                {
                    int id = Convert.ToInt32(comboBoxShip.SelectedValue);
                    ShipViewModel product = shiplogic.Read(new ShipBindingModel { Id = 
                        id })?[0];
                    int count = Convert.ToInt32(textBoxCount.Text);
                    textBoxSum.Text = (count * product?.Price ?? 0).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void comboBoxShip_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxShip.SelectedValue == null)
            {
                MessageBox.Show("Выберите судно", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                logicMain.CreateOrder(new CreateOrderBindingModel
                {
                    ShipId = Convert.ToInt32(comboBoxShip.SelectedValue),
                    ClientId = Convert.ToInt32(comboBoxClient.SelectedValue),
                    Count = Convert.ToInt32(textBoxCount.Text),
                    Sum = Convert.ToDecimal(textBoxSum.Text)
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
