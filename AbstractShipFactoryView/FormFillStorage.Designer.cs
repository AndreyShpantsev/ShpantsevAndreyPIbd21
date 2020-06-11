namespace AbstractShipFactoryView
{
    partial class FormFillStorage
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
            this.labelstorage = new System.Windows.Forms.Label();
            this.labelbillet = new System.Windows.Forms.Label();
            this.labelcount = new System.Windows.Forms.Label();
            this.textBoxcount = new System.Windows.Forms.TextBox();
            this.comboBoxstorage = new System.Windows.Forms.ComboBox();
            this.comboBoxdetail = new System.Windows.Forms.ComboBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelstorage
            // 
            this.labelstorage.AutoSize = true;
            this.labelstorage.Location = new System.Drawing.Point(15, 24);
            this.labelstorage.Name = "labelstorage";
            this.labelstorage.Size = new System.Drawing.Size(41, 13);
            this.labelstorage.TabIndex = 0;
            this.labelstorage.Text = "Склад:";
            // 
            // labelbillet
            // 
            this.labelbillet.AutoSize = true;
            this.labelbillet.Location = new System.Drawing.Point(15, 58);
            this.labelbillet.Name = "labelbillet";
            this.labelbillet.Size = new System.Drawing.Size(48, 13);
            this.labelbillet.TabIndex = 1;
            this.labelbillet.Text = "Деталь:";
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Location = new System.Drawing.Point(15, 91);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(69, 13);
            this.labelcount.TabIndex = 2;
            this.labelcount.Text = "Количество:";
            // 
            // textBoxcount
            // 
            this.textBoxcount.Location = new System.Drawing.Point(93, 88);
            this.textBoxcount.Name = "textBoxcount";
            this.textBoxcount.Size = new System.Drawing.Size(167, 20);
            this.textBoxcount.TabIndex = 3;
            // 
            // comboBoxstorage
            // 
            this.comboBoxstorage.FormattingEnabled = true;
            this.comboBoxstorage.Location = new System.Drawing.Point(93, 21);
            this.comboBoxstorage.Name = "comboBoxstorage";
            this.comboBoxstorage.Size = new System.Drawing.Size(167, 21);
            this.comboBoxstorage.TabIndex = 4;
            // 
            // comboBoxdetail
            // 
            this.comboBoxdetail.FormattingEnabled = true;
            this.comboBoxdetail.Location = new System.Drawing.Point(93, 55);
            this.comboBoxdetail.Name = "comboBoxdetail";
            this.comboBoxdetail.Size = new System.Drawing.Size(167, 21);
            this.comboBoxdetail.TabIndex = 5;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(257, 129);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(97, 23);
            this.ButtonCancel.TabIndex = 6;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(146, 129);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(96, 23);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // FormFillStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 158);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.comboBoxdetail);
            this.Controls.Add(this.comboBoxstorage);
            this.Controls.Add(this.textBoxcount);
            this.Controls.Add(this.labelcount);
            this.Controls.Add(this.labelbillet);
            this.Controls.Add(this.labelstorage);
            this.Name = "FormFillStorage";
            this.Text = "Заполнение склада";
            this.Load += new System.EventHandler(this.FormFillStorage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelstorage;
        private System.Windows.Forms.Label labelbillet;
        private System.Windows.Forms.Label labelcount;
        private System.Windows.Forms.TextBox textBoxcount;
        private System.Windows.Forms.ComboBox comboBoxstorage;
        private System.Windows.Forms.ComboBox comboBoxdetail;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSave;
    }
}