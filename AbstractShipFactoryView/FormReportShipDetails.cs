using System;
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
using AbstractShipFactoryBusinessLogic.BusinessLogics;
using Microsoft.Reporting.WinForms;

namespace AbstractShipFactoryView
{
    public partial class FormReportShipDetails : Form
    {
        [Dependency] 
        public new IUnityContainer Container { get; set; }

        private readonly ReportLogic logic;
        public FormReportShipDetails(ReportLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void buttonMakeOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var dataSource = logic.GetShipDetail();
                ReportDataSource source = new ReportDataSource("DataSetShipDetails", dataSource);
                reportViewer.LocalReport.DataSources.Add(source);
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        [Obsolete]
        private void buttonPDFOrder_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        logic.SaveShipDetailsToPdfFile(new ReportBindingModel
                        {
                            FileName = dialog.FileName,
                        });
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
