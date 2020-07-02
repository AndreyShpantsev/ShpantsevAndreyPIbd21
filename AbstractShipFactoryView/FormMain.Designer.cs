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
            this.buttonTakeOnWork = new System.Windows.Forms.Button();
            this.buttonCreateReady = new System.Windows.Forms.Button();
            this.buttonPayOrd = new System.Windows.Forms.Button();
            this.buttonRefOrder = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.ShipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfExecution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.деталиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.суднаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(600, 39);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(111, 23);
            this.buttonCreateOrder.TabIndex = 0;
            this.buttonCreateOrder.Text = "Создать заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonTakeOnWork
            // 
            this.buttonTakeOnWork.Location = new System.Drawing.Point(600, 68);
            this.buttonTakeOnWork.Name = "buttonTakeOnWork";
            this.buttonTakeOnWork.Size = new System.Drawing.Size(111, 38);
            this.buttonTakeOnWork.TabIndex = 1;
            this.buttonTakeOnWork.Text = "Отдать на выполнение";
            this.buttonTakeOnWork.UseVisualStyleBackColor = true;
            this.buttonTakeOnWork.Click += new System.EventHandler(this.buttonTakeOnWork_Click);
            // 
            // buttonCreateReady
            // 
            this.buttonCreateReady.Location = new System.Drawing.Point(600, 112);
            this.buttonCreateReady.Name = "buttonCreateReady";
            this.buttonCreateReady.Size = new System.Drawing.Size(111, 23);
            this.buttonCreateReady.TabIndex = 2;
            this.buttonCreateReady.Text = "Заказ готов";
            this.buttonCreateReady.UseVisualStyleBackColor = true;
            this.buttonCreateReady.Click += new System.EventHandler(this.buttonCreateReady_Click);
            // 
            // buttonPayOrd
            // 
            this.buttonPayOrd.Location = new System.Drawing.Point(600, 141);
            this.buttonPayOrd.Name = "buttonPayOrd";
            this.buttonPayOrd.Size = new System.Drawing.Size(111, 23);
            this.buttonPayOrd.TabIndex = 3;
            this.buttonPayOrd.Text = "Заказ оплачен";
            this.buttonPayOrd.UseVisualStyleBackColor = true;
            this.buttonPayOrd.Click += new System.EventHandler(this.buttonPayOrd_Click);
            // 
            // buttonRefOrder
            // 
            this.buttonRefOrder.Location = new System.Drawing.Point(600, 170);
            this.buttonRefOrder.Name = "buttonRefOrder";
            this.buttonRefOrder.Size = new System.Drawing.Size(111, 23);
            this.buttonRefOrder.TabIndex = 4;
            this.buttonRefOrder.Text = "Обновить список";
            this.buttonRefOrder.UseVisualStyleBackColor = true;
            this.buttonRefOrder.Click += new System.EventHandler(this.buttonRefOrder_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShipID,
            this.Ship,
            this.Count,
            this.Sum,
            this.Status,
            this.DateOfCreate,
            this.DateOfExecution});
            this.dataGridViewMain.Location = new System.Drawing.Point(25, 39);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(569, 364);
            this.dataGridViewMain.TabIndex = 5;
            // 
            // ShipID
            // 
            this.ShipID.HeaderText = "ID";
            this.ShipID.Name = "ShipID";
            this.ShipID.Visible = false;
            // 
            // Ship
            // 
            this.Ship.HeaderText = "Судно";
            this.Ship.Name = "Ship";
            this.Ship.Width = 90;
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.Width = 87;
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Сумма заказов";
            this.Sum.Name = "Sum";
            this.Sum.Width = 87;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.Width = 88;
            // 
            // DateOfCreate
            // 
            this.DateOfCreate.HeaderText = "Дата создания";
            this.DateOfCreate.Name = "DateOfCreate";
            this.DateOfCreate.Width = 87;
            // 
            // DateOfExecution
            // 
            this.DateOfExecution.HeaderText = "Дата исполнения";
            this.DateOfExecution.Name = "DateOfExecution";
            this.DateOfExecution.Width = 87;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.деталиToolStripMenuItem,
            this.суднаToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // деталиToolStripMenuItem
            // 
            this.деталиToolStripMenuItem.Name = "деталиToolStripMenuItem";
            this.деталиToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.деталиToolStripMenuItem.Text = "Детали";
            this.деталиToolStripMenuItem.Click += new System.EventHandler(this.деталиToolStripMenuItem_Click);
            // 
            // суднаToolStripMenuItem
            // 
            this.суднаToolStripMenuItem.Name = "суднаToolStripMenuItem";
            this.суднаToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.суднаToolStripMenuItem.Text = "Судна";
            this.суднаToolStripMenuItem.Click += new System.EventHandler(this.суднаToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 446);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.buttonRefOrder);
            this.Controls.Add(this.buttonPayOrd);
            this.Controls.Add(this.buttonCreateReady);
            this.Controls.Add(this.buttonTakeOnWork);
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
        private System.Windows.Forms.Button buttonTakeOnWork;
        private System.Windows.Forms.Button buttonCreateReady;
        private System.Windows.Forms.Button buttonPayOrd;
        private System.Windows.Forms.Button buttonRefOrder;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ship;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfExecution;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem деталиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem суднаToolStripMenuItem;
    }
}