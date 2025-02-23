namespace BookSalesSystem2._0
{
    partial class ReportsControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            startDate = new DateTimePicker();
            endDate = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            txtpath = new Label();
            pathButton = new Button();
            pdfButton = new Button();
            excelButton = new Button();
            generateExcelFinButton = new Button();
            generatePdfFinButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 40, 179);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 115);
            panel1.TabIndex = 31;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(101, 39, 253);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Palatino Linotype", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(748, 115);
            label1.TabIndex = 1;
            label1.Text = "Звіти";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(66, 316);
            label2.Name = "label2";
            label2.Size = new Size(428, 27);
            label2.TabIndex = 32;
            label2.Text = "Генерувати звіт про кількість продажу книг:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(66, 435);
            label3.Name = "label3";
            label3.Size = new Size(278, 27);
            label3.TabIndex = 33;
            label3.Text = "Генерувати фінансовий звіт:";
            // 
            // startDate
            // 
            startDate.Location = new Point(66, 176);
            startDate.Name = "startDate";
            startDate.Size = new Size(194, 27);
            startDate.TabIndex = 34;
            // 
            // endDate
            // 
            endDate.Location = new Point(350, 176);
            endDate.Name = "endDate";
            endDate.Size = new Size(194, 27);
            endDate.TabIndex = 35;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(66, 146);
            label4.Name = "label4";
            label4.Size = new Size(160, 27);
            label4.TabIndex = 36;
            label4.Text = "Початкова дата:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(350, 146);
            label5.Name = "label5";
            label5.Size = new Size(136, 27);
            label5.TabIndex = 37;
            label5.Text = "Кінцева дата:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // txtpath
            // 
            txtpath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtpath.AutoEllipsis = true;
            txtpath.BackColor = Color.White;
            txtpath.BorderStyle = BorderStyle.FixedSingle;
            txtpath.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtpath.Location = new Point(66, 221);
            txtpath.Name = "txtpath";
            txtpath.RightToLeft = RightToLeft.No;
            txtpath.Size = new Size(457, 27);
            txtpath.TabIndex = 38;
            // 
            // pathButton
            // 
            pathButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pathButton.AutoSize = true;
            pathButton.BackColor = Color.FromArgb(101, 39, 253);
            pathButton.Cursor = Cursors.Hand;
            pathButton.FlatAppearance.BorderSize = 0;
            pathButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            pathButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            pathButton.FlatStyle = FlatStyle.Flat;
            pathButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pathButton.ForeColor = Color.White;
            pathButton.Location = new Point(555, 221);
            pathButton.Margin = new Padding(3, 4, 3, 4);
            pathButton.Name = "pathButton";
            pathButton.Size = new Size(125, 33);
            pathButton.TabIndex = 40;
            pathButton.Text = "Обрати шлях";
            pathButton.UseVisualStyleBackColor = false;
            pathButton.Click += pathButton_Click;
            // 
            // pdfButton
            // 
            pdfButton.AutoSize = true;
            pdfButton.BackColor = Color.FromArgb(101, 39, 253);
            pdfButton.Cursor = Cursors.Hand;
            pdfButton.FlatAppearance.BorderSize = 0;
            pdfButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            pdfButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            pdfButton.FlatStyle = FlatStyle.Flat;
            pdfButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pdfButton.ForeColor = Color.White;
            pdfButton.Location = new Point(66, 360);
            pdfButton.Margin = new Padding(3, 4, 3, 4);
            pdfButton.Name = "pdfButton";
            pdfButton.Size = new Size(153, 36);
            pdfButton.TabIndex = 41;
            pdfButton.Text = "Генерувати PDF";
            pdfButton.UseVisualStyleBackColor = false;
            pdfButton.Click += pdfButton_Click;
            // 
            // excelButton
            // 
            excelButton.AutoSize = true;
            excelButton.BackColor = Color.FromArgb(101, 39, 253);
            excelButton.Cursor = Cursors.Hand;
            excelButton.FlatAppearance.BorderSize = 0;
            excelButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            excelButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            excelButton.FlatStyle = FlatStyle.Flat;
            excelButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            excelButton.ForeColor = Color.White;
            excelButton.Location = new Point(246, 360);
            excelButton.Margin = new Padding(3, 4, 3, 4);
            excelButton.Name = "excelButton";
            excelButton.Size = new Size(153, 36);
            excelButton.TabIndex = 42;
            excelButton.Text = "Генерувати Excel";
            excelButton.UseVisualStyleBackColor = false;
            excelButton.Click += excelButton_Click;
            // 
            // generateExcelFinButton
            // 
            generateExcelFinButton.AutoSize = true;
            generateExcelFinButton.BackColor = Color.FromArgb(101, 39, 253);
            generateExcelFinButton.Cursor = Cursors.Hand;
            generateExcelFinButton.FlatAppearance.BorderSize = 0;
            generateExcelFinButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            generateExcelFinButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            generateExcelFinButton.FlatStyle = FlatStyle.Flat;
            generateExcelFinButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            generateExcelFinButton.ForeColor = Color.White;
            generateExcelFinButton.Location = new Point(246, 481);
            generateExcelFinButton.Margin = new Padding(3, 4, 3, 4);
            generateExcelFinButton.Name = "generateExcelFinButton";
            generateExcelFinButton.Size = new Size(153, 36);
            generateExcelFinButton.TabIndex = 50;
            generateExcelFinButton.Text = "Генерувати Excel";
            generateExcelFinButton.UseVisualStyleBackColor = false;
            generateExcelFinButton.Click += generateExcelFinButton_Click;
            // 
            // generatePdfFinButton
            // 
            generatePdfFinButton.AutoSize = true;
            generatePdfFinButton.BackColor = Color.FromArgb(101, 39, 253);
            generatePdfFinButton.Cursor = Cursors.Hand;
            generatePdfFinButton.FlatAppearance.BorderSize = 0;
            generatePdfFinButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            generatePdfFinButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            generatePdfFinButton.FlatStyle = FlatStyle.Flat;
            generatePdfFinButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            generatePdfFinButton.ForeColor = Color.White;
            generatePdfFinButton.Location = new Point(66, 481);
            generatePdfFinButton.Margin = new Padding(3, 4, 3, 4);
            generatePdfFinButton.Name = "generatePdfFinButton";
            generatePdfFinButton.Size = new Size(153, 36);
            generatePdfFinButton.TabIndex = 49;
            generatePdfFinButton.Text = "Генерувати PDF";
            generatePdfFinButton.UseVisualStyleBackColor = false;
            generatePdfFinButton.Click += generatePdfFinButton_Click;
            // 
            // ReportsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(generateExcelFinButton);
            Controls.Add(generatePdfFinButton);
            Controls.Add(excelButton);
            Controls.Add(pdfButton);
            Controls.Add(pathButton);
            Controls.Add(txtpath);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(endDate);
            Controls.Add(startDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ReportsControl";
            Size = new Size(748, 640);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker startDate;
        private DateTimePicker endDate;
        private Label label4;
        private Label label5;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label txtpath;
        private Button pathButton;
        private Button pdfButton;
        private Button excelButton;
        private Button generateExcelFinButton;
        private Button generatePdfFinButton;
    }
}
