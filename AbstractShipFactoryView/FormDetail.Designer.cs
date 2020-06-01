namespace AbstractShipFactoryView
{
    partial class FormDetail
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DetailName = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DetailName
            // 
            this.DetailName.AutoSize = true;
            this.DetailName.Location = new System.Drawing.Point(12, 18);
            this.DetailName.Name = "DetailName";
            this.DetailName.Size = new System.Drawing.Size(57, 13);
            this.DetailName.TabIndex = 0;
            this.DetailName.Text = "Название";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(76, 18);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(180, 20);
            this.Name_textBox.TabIndex = 1;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(76, 55);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(88, 23);
            this.Save_button.TabIndex = 2;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(171, 55);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(85, 23);
            this.Cancel_button.TabIndex = 3;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // FormDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 108);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.DetailName);
            this.Name = "FormDetail";
            this.Text = "Деталь";
            this.Load += new System.EventHandler(this.FormDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DetailName;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}

