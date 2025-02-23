namespace BookSalesSystem2._0
{
    partial class AddBookControl
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
            components = new System.ComponentModel.Container();
            cancelButton = new Button();
            addBookButton = new Button();
            label3 = new Label();
            label2 = new Label();
            authorField = new TextBox();
            titleField = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            genreField = new TextBox();
            isbnField = new TextBox();
            priceField = new TextBox();
            stockField = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
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
            cancelButton.Location = new Point(278, 546);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 42);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Скасувати";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // addBookButton
            // 
            addBookButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addBookButton.AutoSize = true;
            addBookButton.BackColor = Color.FromArgb(101, 39, 253);
            addBookButton.Cursor = Cursors.Hand;
            addBookButton.FlatAppearance.BorderSize = 0;
            addBookButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            addBookButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            addBookButton.FlatStyle = FlatStyle.Flat;
            addBookButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addBookButton.ForeColor = Color.White;
            addBookButton.Location = new Point(450, 546);
            addBookButton.Margin = new Padding(3, 4, 3, 4);
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(151, 42);
            addBookButton.TabIndex = 9;
            addBookButton.Text = "Додати книгу";
            addBookButton.UseVisualStyleBackColor = false;
            addBookButton.Click += addBookButton_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(50, 205);
            label3.Name = "label3";
            label3.Size = new Size(75, 27);
            label3.TabIndex = 14;
            label3.Text = "Автор:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(50, 132);
            label2.Name = "label2";
            label2.Size = new Size(71, 27);
            label2.TabIndex = 13;
            label2.Text = "Назва:";
            // 
            // authorField
            // 
            authorField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            authorField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            authorField.Location = new Point(50, 236);
            authorField.Margin = new Padding(3, 4, 3, 4);
            authorField.Name = "authorField";
            authorField.Size = new Size(587, 30);
            authorField.TabIndex = 12;
            // 
            // titleField
            // 
            titleField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titleField.Location = new Point(50, 163);
            titleField.Margin = new Padding(3, 4, 3, 4);
            titleField.Name = "titleField";
            titleField.Size = new Size(587, 30);
            titleField.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(101, 39, 253);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 115);
            panel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Palatino Linotype", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-3, 0);
            label1.Name = "label1";
            label1.Size = new Size(696, 115);
            label1.TabIndex = 1;
            label1.Text = "Додавання книги";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(50, 292);
            label4.Name = "label4";
            label4.Size = new Size(71, 27);
            label4.TabIndex = 16;
            label4.Text = "Жанр:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(364, 292);
            label5.Name = "label5";
            label5.Size = new Size(65, 27);
            label5.TabIndex = 17;
            label5.Text = "ISBN:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(50, 383);
            label6.Name = "label6";
            label6.Size = new Size(60, 27);
            label6.TabIndex = 18;
            label6.Text = "Ціна:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(364, 383);
            label7.Name = "label7";
            label7.Size = new Size(223, 27);
            label7.TabIndex = 19;
            label7.Text = "Кількість екземплярів:";
            // 
            // genreField
            // 
            genreField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            genreField.Location = new Point(50, 323);
            genreField.Margin = new Padding(3, 4, 3, 4);
            genreField.Name = "genreField";
            genreField.Size = new Size(273, 30);
            genreField.TabIndex = 20;
            // 
            // isbnField
            // 
            isbnField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            isbnField.Location = new Point(364, 323);
            isbnField.Margin = new Padding(3, 4, 3, 4);
            isbnField.Name = "isbnField";
            isbnField.Size = new Size(273, 30);
            isbnField.TabIndex = 21;
            // 
            // priceField
            // 
            priceField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            priceField.Location = new Point(50, 414);
            priceField.Margin = new Padding(3, 4, 3, 4);
            priceField.Name = "priceField";
            priceField.Size = new Size(273, 30);
            priceField.TabIndex = 22;
            // 
            // stockField
            // 
            stockField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            stockField.Location = new Point(364, 414);
            stockField.Margin = new Padding(3, 4, 3, 4);
            stockField.Name = "stockField";
            stockField.Size = new Size(273, 30);
            stockField.TabIndex = 23;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddBookControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
            Controls.Add(addBookButton);
            Name = "AddBookControl";
            Size = new Size(696, 637);
            Click += AddBookControl_Click;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button cancelButton;
        private Button addBookButton;
        private Label label3;
        private Label label2;
        private TextBox authorField;
        private TextBox titleField;
        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox genreField;
        private TextBox isbnField;
        private TextBox priceField;
        private TextBox stockField;
        private ErrorProvider errorProvider1;
    }
}
