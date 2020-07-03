namespace AbstractShipFactoryView
{
    partial class FormReportShipDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMakeOrder = new System.Windows.Forms.Button();
            this.buttonPDFOrder = new System.Windows.Forms.Button();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // buttonMakeOrder
            // 
            this.buttonMakeOrder.Location = new System.Drawing.Point(13, 11);
            this.buttonMakeOrder.Name = "buttonMakeOrder";
            this.buttonMakeOrder.Size = new System.Drawing.Size(100, 23);
            this.buttonMakeOrder.TabIndex = 2;
            this.buttonMakeOrder.Text = "Сформировать";
            this.buttonMakeOrder.UseVisualStyleBackColor = true;
            this.buttonMakeOrder.Click += new System.EventHandler(this.buttonMakeOrder_Click);
            // 
            // buttonPDFOrder
            // 
            this.buttonPDFOrder.Location = new System.Drawing.Point(132, 11);
            this.buttonPDFOrder.Name = "buttonPDFOrder";
            this.buttonPDFOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonPDFOrder.TabIndex = 3;
            this.buttonPDFOrder.Text = "pdf";
            this.buttonPDFOrder.UseVisualStyleBackColor = true;
            this.buttonPDFOrder.Click += new System.EventHandler(this.buttonPDFOrder_Click);
            // 
            // reportViewer
            // 
            this.reportViewer.LocalReport.ReportEmbeddedResource = "AbstractShipFactoryView.Report1.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(13, 40);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(764, 398);
            this.reportViewer.TabIndex = 4;
            // 
            // FormReportShipDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.buttonPDFOrder);
            this.Controls.Add(this.buttonMakeOrder);
            this.Name = "FormReportShipDetails";
            this.Text = "Список судов с деталями";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonMakeOrder;
        private System.Windows.Forms.Button buttonPDFOrder;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}