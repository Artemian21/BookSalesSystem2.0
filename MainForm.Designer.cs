namespace BookSalesSystem2._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelLeft = new Panel();
            pictureBox1 = new PictureBox();
            reportControlButton = new Button();
            orderControlButton = new Button();
            bookControlButton = new Button();
            mainControlButton = new Button();
            panelContainer = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(101, 39, 253);
            panelLeft.Controls.Add(pictureBox1);
            panelLeft.Controls.Add(reportControlButton);
            panelLeft.Controls.Add(orderControlButton);
            panelLeft.Controls.Add(bookControlButton);
            panelLeft.Controls.Add(mainControlButton);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(245, 820);
            panelLeft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Bss;
            pictureBox1.InitialImage = Properties.Resources.Bss;
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // reportControlButton
            // 
            reportControlButton.AutoSize = true;
            reportControlButton.BackColor = Color.FromArgb(101, 39, 253);
            reportControlButton.Cursor = Cursors.Hand;
            reportControlButton.FlatAppearance.BorderSize = 0;
            reportControlButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            reportControlButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            reportControlButton.FlatStyle = FlatStyle.Flat;
            reportControlButton.Font = new Font("Palatino Linotype", 11F);
            reportControlButton.ForeColor = SystemColors.HighlightText;
            reportControlButton.Location = new Point(12, 368);
            reportControlButton.Margin = new Padding(3, 4, 3, 4);
            reportControlButton.Name = "reportControlButton";
            reportControlButton.Size = new Size(217, 54);
            reportControlButton.TabIndex = 14;
            reportControlButton.Text = "📄  Звіти";
            reportControlButton.UseVisualStyleBackColor = false;
            reportControlButton.Click += reportControlButton_Click;
            // 
            // orderControlButton
            // 
            orderControlButton.AutoSize = true;
            orderControlButton.BackColor = Color.FromArgb(101, 39, 253);
            orderControlButton.Cursor = Cursors.Hand;
            orderControlButton.FlatAppearance.BorderSize = 0;
            orderControlButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            orderControlButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            orderControlButton.FlatStyle = FlatStyle.Flat;
            orderControlButton.Font = new Font("Palatino Linotype", 11F);
            orderControlButton.ForeColor = SystemColors.HighlightText;
            orderControlButton.Location = new Point(12, 294);
            orderControlButton.Margin = new Padding(3, 4, 3, 4);
            orderControlButton.Name = "orderControlButton";
            orderControlButton.Size = new Size(214, 55);
            orderControlButton.TabIndex = 13;
            orderControlButton.Text = "\U0001f6d2  Замовлення";
            orderControlButton.UseVisualStyleBackColor = false;
            orderControlButton.Click += orderControlButton_Click;
            // 
            // bookControlButton
            // 
            bookControlButton.AutoSize = true;
            bookControlButton.BackColor = Color.FromArgb(101, 39, 253);
            bookControlButton.Cursor = Cursors.Hand;
            bookControlButton.FlatAppearance.BorderSize = 0;
            bookControlButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            bookControlButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            bookControlButton.FlatStyle = FlatStyle.Flat;
            bookControlButton.Font = new Font("Palatino Linotype", 11F);
            bookControlButton.ForeColor = SystemColors.HighlightText;
            bookControlButton.Location = new Point(15, 217);
            bookControlButton.Margin = new Padding(3, 4, 3, 4);
            bookControlButton.Name = "bookControlButton";
            bookControlButton.Size = new Size(211, 57);
            bookControlButton.TabIndex = 12;
            bookControlButton.Text = "📚  Книги";
            bookControlButton.UseVisualStyleBackColor = false;
            bookControlButton.Click += bookControlButton_Click;
            // 
            // mainControlButton
            // 
            mainControlButton.AutoSize = true;
            mainControlButton.BackColor = Color.FromArgb(101, 39, 253);
            mainControlButton.Cursor = Cursors.Hand;
            mainControlButton.FlatAppearance.BorderSize = 0;
            mainControlButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            mainControlButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            mainControlButton.FlatStyle = FlatStyle.Flat;
            mainControlButton.Font = new Font("Palatino Linotype", 11F);
            mainControlButton.ForeColor = SystemColors.HighlightText;
            mainControlButton.Location = new Point(15, 140);
            mainControlButton.Margin = new Padding(3, 4, 3, 4);
            mainControlButton.Name = "mainControlButton";
            mainControlButton.Size = new Size(211, 55);
            mainControlButton.TabIndex = 11;
            mainControlButton.Text = "🏠  Головна";
            mainControlButton.UseVisualStyleBackColor = false;
            mainControlButton.Click += mainControlButton_Click;
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = Color.White;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(245, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(914, 820);
            panelContainer.TabIndex = 1;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // MainForm
            // 
            AccessibleDescription = "";
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1159, 820);
            Controls.Add(panelContainer);
            Controls.Add(panelLeft);
            Icon = Properties.Resources.BssIcon;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BSS";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Button button4;
        private Button reportControlButton;
        private Button orderControlButton;
        private Button bookControlButton;
        private Button mainControlButton;
        private Panel panelContainer;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox pictureBox1;
    }
}