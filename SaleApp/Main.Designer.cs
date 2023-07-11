namespace SaleApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оформитьПродажуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьПродажуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьЧекаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.анализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализПоСотрудникамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализКомплектующихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(11, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 314);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(195, 18);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 26);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dateTime,
            this.Sum,
            this.Status,
            this.Worker});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 264);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // dateTime
            // 
            this.dateTime.HeaderText = "Дата и время продажи";
            this.dateTime.MinimumWidth = 6;
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            this.dateTime.Width = 220;
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Сумма продажи";
            this.Sum.MinimumWidth = 6;
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            this.Sum.Width = 200;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус продажи";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // Worker
            // 
            this.Worker.HeaderText = "Сотрудник";
            this.Worker.MinimumWidth = 6;
            this.Worker.Name = "Worker";
            this.Worker.ReadOnly = true;
            this.Worker.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.label1.Size = new System.Drawing.Size(146, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Продажи";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продажиToolStripMenuItem,
            this.анализToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(816, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // продажиToolStripMenuItem
            // 
            this.продажиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оформитьПродажуToolStripMenuItem,
            this.отменитьПродажуToolStripMenuItem,
            this.печатьЧекаToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem2});
            this.продажиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.продажиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.продажиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("продажиToolStripMenuItem.Image")));
            this.продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
            this.продажиToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
            this.продажиToolStripMenuItem.Text = "Продажа";
            // 
            // оформитьПродажуToolStripMenuItem
            // 
            this.оформитьПродажуToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.оформитьПродажуToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.оформитьПродажуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оформитьПродажуToolStripMenuItem.Image")));
            this.оформитьПродажуToolStripMenuItem.Name = "оформитьПродажуToolStripMenuItem";
            this.оформитьПродажуToolStripMenuItem.Size = new System.Drawing.Size(263, 28);
            this.оформитьПродажуToolStripMenuItem.Text = "Оформить продажу...";
            this.оформитьПродажуToolStripMenuItem.Click += new System.EventHandler(this.оформитьПродажуToolStripMenuItem_Click);
            // 
            // отменитьПродажуToolStripMenuItem
            // 
            this.отменитьПродажуToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.отменитьПродажуToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.отменитьПродажуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("отменитьПродажуToolStripMenuItem.Image")));
            this.отменитьПродажуToolStripMenuItem.Name = "отменитьПродажуToolStripMenuItem";
            this.отменитьПродажуToolStripMenuItem.Size = new System.Drawing.Size(263, 28);
            this.отменитьПродажуToolStripMenuItem.Text = "Отменить продажу...";
            this.отменитьПродажуToolStripMenuItem.Click += new System.EventHandler(this.отменитьПродажуToolStripMenuItem_Click_1);
            // 
            // печатьЧекаToolStripMenuItem
            // 
            this.печатьЧекаToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.печатьЧекаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.печатьЧекаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("печатьЧекаToolStripMenuItem.Image")));
            this.печатьЧекаToolStripMenuItem.Name = "печатьЧекаToolStripMenuItem";
            this.печатьЧекаToolStripMenuItem.Size = new System.Drawing.Size(263, 28);
            this.печатьЧекаToolStripMenuItem.Text = "Печать чека";
            this.печатьЧекаToolStripMenuItem.Click += new System.EventHandler(this.печатьЧекаToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(260, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(263, 28);
            this.toolStripMenuItem2.Text = "Выход";
            // 
            // анализToolStripMenuItem
            // 
            this.анализToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.анализПоСотрудникамToolStripMenuItem,
            this.анализКомплектующихToolStripMenuItem});
            this.анализToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.анализToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.анализToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("анализToolStripMenuItem.Image")));
            this.анализToolStripMenuItem.Name = "анализToolStripMenuItem";
            this.анализToolStripMenuItem.Size = new System.Drawing.Size(167, 27);
            this.анализToolStripMenuItem.Text = "Анализ продаж";
            // 
            // анализПоСотрудникамToolStripMenuItem
            // 
            this.анализПоСотрудникамToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.анализПоСотрудникамToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.анализПоСотрудникамToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("анализПоСотрудникамToolStripMenuItem.Image")));
            this.анализПоСотрудникамToolStripMenuItem.Name = "анализПоСотрудникамToolStripMenuItem";
            this.анализПоСотрудникамToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.анализПоСотрудникамToolStripMenuItem.Text = "По сотрудникам";
            this.анализПоСотрудникамToolStripMenuItem.Click += new System.EventHandler(this.анализПоСотрудникамToolStripMenuItem_Click);
            // 
            // анализКомплектующихToolStripMenuItem
            // 
            this.анализКомплектующихToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.анализКомплектующихToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.анализКомплектующихToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("анализКомплектующихToolStripMenuItem.Image")));
            this.анализКомплектующихToolStripMenuItem.Name = "анализКомплектующихToolStripMenuItem";
            this.анализКомплектующихToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.анализКомплектующихToolStripMenuItem.Text = "По комплектующим";
            this.анализКомплектующихToolStripMenuItem.Click += new System.EventHandler(this.анализКомплектующихToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(195, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Позиции в продаже";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(11, 383);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 231);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detail,
            this.CountDetail,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(-2, 41);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(795, 188);
            this.dataGridView2.TabIndex = 4;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Комплектующее";
            this.Detail.MinimumWidth = 6;
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Width = 200;
            // 
            // CountDetail
            // 
            this.CountDetail.HeaderText = "Количество";
            this.CountDetail.MinimumWidth = 6;
            this.CountDetail.Name = "CountDetail";
            this.CountDetail.ReadOnly = true;
            this.CountDetail.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 175;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(816, 622);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Главное";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worker;
        private System.Windows.Forms.ToolStripMenuItem продажиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оформитьПродажуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьПродажуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализПоСотрудникамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализКомплектующихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьЧекаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}