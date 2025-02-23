namespace BookSalesSystem2._0
{
    partial class UpdatedBookForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatedBookForm));
            stockField = new TextBox();
            priceField = new TextBox();
            isbnField = new TextBox();
            genreField = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            authorField = new TextBox();
            titleField = new TextBox();
            cancelButton = new Button();
            saveBookButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // stockField
            // 
            stockField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            stockField.Location = new Point(415, 423);
            stockField.Margin = new Padding(3, 4, 3, 4);
            stockField.Name = "stockField";
            stockField.Size = new Size(273, 30);
            stockField.TabIndex = 38;
            // 
            // priceField
            // 
            priceField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            priceField.Location = new Point(101, 423);
            priceField.Margin = new Padding(3, 4, 3, 4);
            priceField.Name = "priceField";
            priceField.Size = new Size(273, 30);
            priceField.TabIndex = 37;
            // 
            // isbnField
            // 
            isbnField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            isbnField.Location = new Point(415, 332);
            isbnField.Margin = new Padding(3, 4, 3, 4);
            isbnField.Name = "isbnField";
            isbnField.Size = new Size(273, 30);
            isbnField.TabIndex = 36;
            // 
            // genreField
            // 
            genreField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            genreField.Location = new Point(101, 332);
            genreField.Margin = new Padding(3, 4, 3, 4);
            genreField.Name = "genreField";
            genreField.Size = new Size(273, 30);
            genreField.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(415, 392);
            label7.Name = "label7";
            label7.Size = new Size(223, 27);
            label7.TabIndex = 34;
            label7.Text = "Кількість екземплярів:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(101, 392);
            label6.Name = "label6";
            label6.Size = new Size(60, 27);
            label6.TabIndex = 33;
            label6.Text = "Ціна:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(415, 301);
            label5.Name = "label5";
            label5.Size = new Size(65, 27);
            label5.TabIndex = 32;
            label5.Text = "ISBN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(101, 301);
            label4.Name = "label4";
            label4.Size = new Size(71, 27);
            label4.TabIndex = 31;
            label4.Text = "Жанр:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(78, 16, 230);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 115);
            panel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Palatino Linotype", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(799, 115);
            label1.TabIndex = 1;
            label1.Text = "Оновлення інформації про книгу";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(101, 214);
            label3.Name = "label3";
            label3.Size = new Size(75, 27);
            label3.TabIndex = 29;
            label3.Text = "Автор:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(101, 141);
            label2.Name = "label2";
            label2.Size = new Size(71, 27);
            label2.TabIndex = 28;
            label2.Text = "Назва:";
            // 
            // authorField
            // 
            authorField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            authorField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            authorField.Location = new Point(101, 245);
            authorField.Margin = new Padding(3, 4, 3, 4);
            authorField.Name = "authorField";
            authorField.Size = new Size(586, 30);
            authorField.TabIndex = 27;
            // 
            // titleField
            // 
            titleField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titleField.Location = new Point(101, 172);
            titleField.Margin = new Padding(3, 4, 3, 4);
            titleField.Name = "titleField";
            titleField.Size = new Size(586, 30);
            titleField.TabIndex = 26;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.AutoSize = true;
            cancelButton.BackColor = Color.WhiteSmoke;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.FlatAppearance.BorderColor = Color.LightGray;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cancelButton.ForeColor = Color.DimGray;
            cancelButton.Location = new Point(344, 549);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 42);
            cancelButton.TabIndex = 25;
            cancelButton.Text = "Скасувати";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveBookButton
            // 
            saveBookButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveBookButton.AutoSize = true;
            saveBookButton.BackColor = Color.FromArgb(78, 16, 230);
            saveBookButton.Cursor = Cursors.Hand;
            saveBookButton.FlatAppearance.BorderSize = 0;
            saveBookButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            saveBookButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            saveBookButton.FlatStyle = FlatStyle.Flat;
            saveBookButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            saveBookButton.ForeColor = Color.White;
            saveBookButton.Location = new Point(536, 549);
            saveBookButton.Margin = new Padding(3, 4, 3, 4);
            saveBookButton.Name = "saveBookButton";
            saveBookButton.Size = new Size(151, 42);
            saveBookButton.TabIndex = 24;
            saveBookButton.Text = "Зберегти зміни";
            saveBookButton.UseVisualStyleBackColor = false;
            saveBookButton.Click += saveBookButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UpdatedBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 639);
            Controls.Add(stockField);
            Controls.Add(priceField);
            Controls.Add(isbnField);
            Controls.Add(genreField);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(authorField);
            Controls.Add(titleField);
            Controls.Add(cancelButton);
            Controls.Add(saveBookButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UpdatedBookForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BSS";
            Click += UpdatedBookForm_Click;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox stockField;
        private TextBox priceField;
        private TextBox isbnField;
        private TextBox genreField;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox authorField;
        private TextBox titleField;
        private Button cancelButton;
        private Button saveBookButton;
        private ErrorProvider errorProvider1;
    }
}