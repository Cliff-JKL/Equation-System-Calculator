namespace Calculator
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.errorYealLabel = new System.Windows.Forms.Label();
            this.eqListView = new System.Windows.Forms.ListView();
            this.xFactorTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yFactorTextBox = new System.Windows.Forms.TextBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.zFactorTextBox = new System.Windows.Forms.TextBox();
            this.zLabel = new System.Windows.Forms.Label();
            this.cFactorTextBox = new System.Windows.Forms.TextBox();
            this.zeroLabel = new System.Windows.Forms.Label();
            this.list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.zeroLabel);
            this.panel1.Controls.Add(this.cFactorTextBox);
            this.panel1.Controls.Add(this.zLabel);
            this.panel1.Controls.Add(this.zFactorTextBox);
            this.panel1.Controls.Add(this.yLabel);
            this.panel1.Controls.Add(this.yFactorTextBox);
            this.panel1.Controls.Add(this.xLabel);
            this.panel1.Controls.Add(this.xFactorTextBox);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.errorYealLabel);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 342);
            this.panel1.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nameLabel.Location = new System.Drawing.Point(19, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(66, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Уравнение:";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Control;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Location = new System.Drawing.Point(22, 123);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // errorYealLabel
            // 
            this.errorYealLabel.AutoSize = true;
            this.errorYealLabel.ForeColor = System.Drawing.Color.Red;
            this.errorYealLabel.Location = new System.Drawing.Point(19, 188);
            this.errorYealLabel.Name = "errorYealLabel";
            this.errorYealLabel.Size = new System.Drawing.Size(49, 13);
            this.errorYealLabel.TabIndex = 11;
            this.errorYealLabel.Text = "*ошибка";
            this.errorYealLabel.Visible = false;
            // 
            // eqListView
            // 
            this.eqListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list});
            this.eqListView.FullRowSelect = true;
            this.eqListView.GridLines = true;
            this.eqListView.Location = new System.Drawing.Point(361, 80);
            this.eqListView.Name = "eqListView";
            this.eqListView.Size = new System.Drawing.Size(256, 277);
            this.eqListView.TabIndex = 2;
            this.eqListView.UseCompatibleStateImageBehavior = false;
            this.eqListView.View = System.Windows.Forms.View.Details;
            // 
            // xFactorTextBox
            // 
            this.xFactorTextBox.Location = new System.Drawing.Point(22, 81);
            this.xFactorTextBox.Name = "xFactorTextBox";
            this.xFactorTextBox.Size = new System.Drawing.Size(25, 20);
            this.xFactorTextBox.TabIndex = 13;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(53, 84);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(24, 13);
            this.xLabel.TabIndex = 14;
            this.xLabel.Text = "x + ";
            // 
            // yFactorTextBox
            // 
            this.yFactorTextBox.Location = new System.Drawing.Point(80, 81);
            this.yFactorTextBox.Name = "yFactorTextBox";
            this.yFactorTextBox.Size = new System.Drawing.Size(25, 20);
            this.yFactorTextBox.TabIndex = 15;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(111, 84);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(24, 13);
            this.yLabel.TabIndex = 16;
            this.yLabel.Text = "y + ";
            // 
            // zFactorTextBox
            // 
            this.zFactorTextBox.Location = new System.Drawing.Point(138, 81);
            this.zFactorTextBox.Name = "zFactorTextBox";
            this.zFactorTextBox.Size = new System.Drawing.Size(25, 20);
            this.zFactorTextBox.TabIndex = 17;
            // 
            // zLabel
            // 
            this.zLabel.AutoSize = true;
            this.zLabel.Location = new System.Drawing.Point(169, 84);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(24, 13);
            this.zLabel.TabIndex = 18;
            this.zLabel.Text = "z + ";
            // 
            // cFactorTextBox
            // 
            this.cFactorTextBox.Location = new System.Drawing.Point(196, 81);
            this.cFactorTextBox.Name = "cFactorTextBox";
            this.cFactorTextBox.Size = new System.Drawing.Size(25, 20);
            this.cFactorTextBox.TabIndex = 19;
            // 
            // zeroLabel
            // 
            this.zeroLabel.AutoSize = true;
            this.zeroLabel.Location = new System.Drawing.Point(227, 84);
            this.zeroLabel.Name = "zeroLabel";
            this.zeroLabel.Size = new System.Drawing.Size(25, 13);
            this.zeroLabel.TabIndex = 20;
            this.zeroLabel.Text = " = 0";
            // 
            // list
            // 
            this.list.Text = "Уравнения";
            this.list.Width = 251;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.eqListView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label errorYealLabel;
        private System.Windows.Forms.ListView eqListView;
        private System.Windows.Forms.Label zeroLabel;
        private System.Windows.Forms.TextBox cFactorTextBox;
        private System.Windows.Forms.Label zLabel;
        private System.Windows.Forms.TextBox zFactorTextBox;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.TextBox yFactorTextBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox xFactorTextBox;
        private System.Windows.Forms.ColumnHeader list;
    }
}

