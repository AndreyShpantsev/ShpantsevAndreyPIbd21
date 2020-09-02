namespace AbstractShipFactoryView
{
    partial class FormMain
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
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonPayOrd = new System.Windows.Forms.Button();
            this.buttonRefOrder = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.деталиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.суднаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исполнителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сообщенияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DetailShipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartOfWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сообщенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(821, 39);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(111, 46);
            this.buttonCreateOrder.TabIndex = 0;
            this.buttonCreateOrder.Text = "Создать заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonPayOrd
            // 
            this.buttonPayOrd.Location = new System.Drawing.Point(821, 91);
            this.buttonPayOrd.Name = "buttonPayOrd";
            this.buttonPayOrd.Size = new System.Drawing.Size(111, 46);
            this.buttonPayOrd.TabIndex = 3;
            this.buttonPayOrd.Text = "Заказ оплачен";
            this.buttonPayOrd.UseVisualStyleBackColor = true;
            this.buttonPayOrd.Click += new System.EventHandler(this.buttonPayOrd_Click);
            // 
            // buttonRefOrder
            // 
            this.buttonRefOrder.Location = new System.Drawing.Point(821, 143);
            this.buttonRefOrder.Name = "buttonRefOrder";
            this.buttonRefOrder.Size = new System.Drawing.Size(111, 44);
            this.buttonRefOrder.TabIndex = 4;
            this.buttonRefOrder.Text = "Обновить список";
            this.buttonRefOrder.UseVisualStyleBackColor = true;
            this.buttonRefOrder.Click += new System.EventHandler(this.buttonRefOrder_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(25, 39);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(768, 364);
            this.dataGridViewMain.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.StartOfWorkToolStripMenuItem,
            this.сообщенияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.деталиToolStripMenuItem,
            this.суднаToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.исполнителиToolStripMenuItem,
            this.сообщенияToolStripMenuItem1});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // деталиToolStripMenuItem
            // 
            this.деталиToolStripMenuItem.Name = "деталиToolStripMenuItem";
            this.деталиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.деталиToolStripMenuItem.Text = "Детали";
            this.деталиToolStripMenuItem.Click += new System.EventHandler(this.деталиToolStripMenuItem_Click_1);
            // 
            // суднаToolStripMenuItem
            // 
            this.суднаToolStripMenuItem.Name = "суднаToolStripMenuItem";
            this.суднаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.суднаToolStripMenuItem.Text = "Судна";
            this.суднаToolStripMenuItem.Click += new System.EventHandler(this.суднаToolStripMenuItem_Click_1);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // исполнителиToolStripMenuItem
            // 
            this.исполнителиToolStripMenuItem.Name = "исполнителиToolStripMenuItem";
            this.исполнителиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.исполнителиToolStripMenuItem.Text = "Исполнители";
            this.исполнителиToolStripMenuItem.Click += new System.EventHandler(this.исполнителиToolStripMenuItem_Click);
            // 
            // сообщенияToolStripMenuItem1
            // 
            this.сообщенияToolStripMenuItem1.Name = "сообщенияToolStripMenuItem1";
            this.сообщенияToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.сообщенияToolStripMenuItem1.Text = "Сообщения";
            this.сообщенияToolStripMenuItem1.Click += new System.EventHandler(this.сообщенияToolStripMenuItem1_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DetailsToolStripMenuItem,
            this.DetailShipsToolStripMenuItem,
            this.OrdersToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // DetailsToolStripMenuItem
            // 
            this.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem";
            this.DetailsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.DetailsToolStripMenuItem.Text = "Список деталей";
            this.DetailsToolStripMenuItem.Click += new System.EventHandler(this.DetailsToolStripMenuItem_Click);
            // 
            // DetailShipsToolStripMenuItem
            // 
            this.DetailShipsToolStripMenuItem.Name = "DetailShipsToolStripMenuItem";
            this.DetailShipsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.DetailShipsToolStripMenuItem.Text = "Детали по суднам";
            this.DetailShipsToolStripMenuItem.Click += new System.EventHandler(this.DetailShipsToolStripMenuItem_Click);
            // 
            // OrdersToolStripMenuItem
            // 
            this.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem";
            this.OrdersToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.OrdersToolStripMenuItem.Text = "Список заказов";
            this.OrdersToolStripMenuItem.Click += new System.EventHandler(this.OrdersToolStripMenuItem_Click);
            // 
            // StartOfWorkToolStripMenuItem
            // 
            this.StartOfWorkToolStripMenuItem.Name = "StartOfWorkToolStripMenuItem";
            this.StartOfWorkToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.StartOfWorkToolStripMenuItem.Text = "Запуск работ";
            this.StartOfWorkToolStripMenuItem.Click += new System.EventHandler(this.StartOfWorkToolStripMenuItem_Click);
            // 
            // сообщенияToolStripMenuItem
            // 
            this.сообщенияToolStripMenuItem.Name = "сообщенияToolStripMenuItem";
            this.сообщенияToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 458);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.buttonRefOrder);
            this.Controls.Add(this.buttonPayOrd);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Абстрактный судостроительный завод";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonPayOrd;
        private System.Windows.Forms.Button buttonRefOrder;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem деталиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem суднаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetailShipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartOfWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исполнителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сообщенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сообщенияToolStripMenuItem1;
    }
}