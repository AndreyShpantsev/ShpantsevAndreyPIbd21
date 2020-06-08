namespace AbstractShipFactoryView
{
    partial class FormMain2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CreateOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateTheListOfOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateImplement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateOrderToolStripMenuItem,
            this.UpdateTheListOfOrdersToolStripMenuItem,
            this.ChangeDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CreateOrderToolStripMenuItem
            // 
            this.CreateOrderToolStripMenuItem.Name = "CreateOrderToolStripMenuItem";
            this.CreateOrderToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.CreateOrderToolStripMenuItem.Text = "Создать заказ";
            // 
            // UpdateTheListOfOrdersToolStripMenuItem
            // 
            this.UpdateTheListOfOrdersToolStripMenuItem.Name = "UpdateTheListOfOrdersToolStripMenuItem";
            this.UpdateTheListOfOrdersToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.UpdateTheListOfOrdersToolStripMenuItem.Text = "Обновить список заказов";
            // 
            // ChangeDataToolStripMenuItem
            // 
            this.ChangeDataToolStripMenuItem.Name = "ChangeDataToolStripMenuItem";
            this.ChangeDataToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.ChangeDataToolStripMenuItem.Text = "Изменить данные";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.Ship,
            this.Count,
            this.Sum,
            this.Status,
            this.DateCreate,
            this.DateImplement});
            this.dataGridViewMain.Location = new System.Drawing.Point(13, 28);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(740, 311);
            this.dataGridViewMain.TabIndex = 1;
            // 
            // Client
            // 
            this.Client.HeaderText = "Клиент";
            this.Client.Name = "Client";
            // 
            // Ship
            // 
            this.Ship.HeaderText = "Судно";
            this.Ship.Name = "Ship";
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Сумма";
            this.Sum.Name = "Sum";
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            // 
            // DateCreate
            // 
            this.DateCreate.HeaderText = "Дата создания";
            this.DateCreate.Name = "DateCreate";
            // 
            // DateImplement
            // 
            this.DateImplement.HeaderText = "Дата выполнения";
            this.DateImplement.Name = "DateImplement";
            // 
            // FormMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 354);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain2";
            this.Text = "Главная форма";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateTheListOfOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeDataToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ship;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateImplement;
    }
}