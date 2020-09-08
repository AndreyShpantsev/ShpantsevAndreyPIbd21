using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbstractShipFactoryBusinessLogic.BindingModels;
using AbstractShipFactoryBusinessLogic.Interfaces;
using AbstractShipFactoryBusinessLogic.ViewModels;
using Unity;

namespace AbstractShipFactoryView
{
    public partial class FormShip : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly IShipLogic logic;
        private int? id;
        private Dictionary<int, (string, int)> shipDetails;

        public FormShip(IShipLogic service)
        {
            InitializeComponent();
            this.logic = service;
        }

        private void LoadData()
        {
            try
            {
                Program.ConfigGrid(logic.Read(null), dataGridViewShip);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FormShip_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    ShipViewModel view = logic.Read(new ShipBindingModel
                    {
                        Id =
                        id.Value
                    })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.ShipName;
                        textBoxPrice.Text = view.Price.ToString();
                        shipDetails = view.ShipDetails;
                        LoadData();
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
                shipDetails = new Dictionary<int, (string, int)>();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormShipDetail>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (shipDetails.ContainsKey(form.Id))
                {
                    shipDetails[form.Id] = (form.DetailName, form.Count);
                }
                else
                {
                    shipDetails.Add(form.Id, (form.DetailName, form.Count));
                }
                LoadData();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridViewShip.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormShipDetail>();
                int id = Convert.ToInt32(dataGridViewShip.SelectedRows[0].Cells[0].Value);
                form.Id = id;
                form.Count = shipDetails[id].Item2;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    shipDetails[form.Id] = (form.DetailName, form.Count);
                    LoadData();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewShip.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        shipDetails.Remove(Convert.ToInt32(dataGridViewShip.SelectedRows[0].Cells[0].Value));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("Заполните цену", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (shipDetails == null || shipDetails.Count == 0)
            {
                MessageBox.Show("Заполните компоненты", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                logic.CreateOrUpdate(new ShipBindingModel
                {
                    Id = id,
                    ShipName = textBoxName.Text,
                    Price = Convert.ToDecimal(textBoxPrice.Text),
                    ShipDetails = shipDetails
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
