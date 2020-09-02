﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using AbstractShipFactoryBusinessLogic.BindingModels;
using AbstractShipFactoryBusinessLogic.Interfaces;

namespace AbstractShipFactoryView
{
    public partial class FormDetails : Form
    {
        [Dependency] public new IUnityContainer Container { get; set; }

        private readonly IDetailLogic logic;

        public FormDetails(IDetailLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                Program.ConfigGrid(logic.Read(null), DetailGridView);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormDetail>(); 
            if (form.ShowDialog() == DialogResult.OK) 
            { 
                LoadData(); 
            }
        }

        private void Change_button_Click(object sender, EventArgs e)
        {
            if (DetailGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormDetail>();
                form.Id = Convert.ToInt32(DetailGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (DetailGridView.SelectedRows.Count == 1) 
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                { 
                    int id = Convert.ToInt32(DetailGridView.SelectedRows[0].Cells[0].Value);
                    try
                    { 
                        logic.Delete(new DetailBindingModel { Id = id }); 
                    } 
                    catch (Exception ex) 
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    } 
                    LoadData();
                }
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
