namespace AbstractShipFactoryClientView
{
    partial class MainForm
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
            this.MessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateOrderToolStripMenuItem,
            this.UpdateTheListOfOrdersToolStripMenuItem,
            this.ChangeDataToolStripMenuItem,
            this.MessagesToolStripMenuItem});
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
            this.CreateOrderToolStripMenuItem.Click += new System.EventHandler(this.CreateOrderToolStripMenuItem_Click);
            // 
            // UpdateTheListOfOrdersToolStripMenuItem
            // 
            this.UpdateTheListOfOrdersToolStripMenuItem.Name = "UpdateTheListOfOrdersToolStripMenuItem";
            this.UpdateTheListOfOrdersToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.UpdateTheListOfOrdersToolStripMenuItem.Text = "Обновить список заказов";
            this.UpdateTheListOfOrdersToolStripMenuItem.Click += new System.EventHandler(this.UpdateTheListOfOrdersToolStripMenuItem_Click);
            // 
            // ChangeDataToolStripMenuItem
            // 
            this.ChangeDataToolStripMenuItem.Name = "ChangeDataToolStripMenuItem";
            this.ChangeDataToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.ChangeDataToolStripMenuItem.Text = "Изменить данные";
            this.ChangeDataToolStripMenuItem.Click += new System.EventHandler(this.ChangeDataToolStripMenuItem_Click);
            //
            // MessagesToolStripMenuItem
            // 
            this.MessagesToolStripMenuItem.Name = "MessagesToolStripMenuItem";
            this.MessagesToolStripMenuItem.Size = new System.Drawing.Size(180, 20);
            this.MessagesToolStripMenuItem.Text = "Сообщения";
            this.MessagesToolStripMenuItem.Click += new System.EventHandler(this.MessagesToolStripMenuItem_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(13, 28);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(740, 311);
            this.dataGridViewMain.TabIndex = 1;
            // 
            // FormMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 354);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
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
        private System.Windows.Forms.ToolStripMenuItem MessagesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewMain;
    }
}