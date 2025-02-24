using BookSalesSystem2._0.OrderFolder;

namespace BookSalesSystem2._0
{
    partial class UpdatedOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatedOrderForm));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            titleField = new TextBox();
            cancelButton = new Button();
            saveOrderButton = new Button();
            paymentStatus = new ComboBox();
            orderStatus = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            phoneNumberField = new TextBox();
            label4 = new Label();
            emailField = new TextBox();
            label3 = new Label();
            customerSurnameField = new TextBox();
            label8 = new Label();
            customerNameField = new TextBox();
            label9 = new Label();
            notesField = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 40, 179);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(873, 115);
            panel1.TabIndex = 45;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(101, 39, 253);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Palatino Linotype", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(873, 115);
            label1.TabIndex = 1;
            label1.Text = "Оновлення інформації про замовлення";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(101, 55);
            label2.Name = "label2";
            label2.Size = new Size(71, 27);
            label2.TabIndex = 43;
            label2.Text = "Назва:";
            // 
            // titleField
            // 
            titleField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titleField.Location = new Point(101, 86);
            titleField.Margin = new Padding(3, 4, 3, 4);
            titleField.Name = "titleField";
            titleField.Size = new Size(659, 30);
            titleField.TabIndex = 41;
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
            cancelButton.Location = new Point(469, 602);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 42);
            cancelButton.TabIndex = 40;
            cancelButton.Text = "Скасувати";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveOrderButton
            // 
            saveOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveOrderButton.AutoSize = true;
            saveOrderButton.BackColor = Color.FromArgb(101, 39, 253);
            saveOrderButton.Cursor = Cursors.Hand;
            saveOrderButton.FlatAppearance.BorderSize = 0;
            saveOrderButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            saveOrderButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            saveOrderButton.FlatStyle = FlatStyle.Flat;
            saveOrderButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            saveOrderButton.ForeColor = Color.White;
            saveOrderButton.Location = new Point(673, 602);
            saveOrderButton.Margin = new Padding(3, 4, 3, 4);
            saveOrderButton.Name = "saveOrderButton";
            saveOrderButton.Size = new Size(151, 42);
            saveOrderButton.TabIndex = 39;
            saveOrderButton.Text = "Зберегти зміни";
            saveOrderButton.UseVisualStyleBackColor = false;
            saveOrderButton.Click += saveOrderButton_Click;
            // 
            // paymentStatus
            // 
            paymentStatus.FormattingEnabled = true;
            paymentStatus.Items.AddRange(new object[] { PaymentStatus.Неоплачено, PaymentStatus.Оплачено, PaymentStatus.Відшкодовано });
            paymentStatus.Location = new Point(624, 335);
            paymentStatus.Name = "paymentStatus";
            paymentStatus.Size = new Size(169, 28);
            paymentStatus.TabIndex = 57;
            // 
            // orderStatus
            // 
            orderStatus.FormattingEnabled = true;
            orderStatus.Items.AddRange(new object[] { OrderStatus.Розгляд, OrderStatus.Обробка, OrderStatus.Завершено, OrderStatus.Скасовано });
            orderStatus.Location = new Point(147, 335);
            orderStatus.Name = "orderStatus";
            orderStatus.Size = new Size(169, 28);
            orderStatus.TabIndex = 56;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(465, 336);
            label7.Name = "label7";
            label7.Size = new Size(154, 27);
            label7.TabIndex = 55;
            label7.Text = "Статус оплати:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(49, 336);
            label6.Name = "label6";
            label6.Size = new Size(81, 27);
            label6.TabIndex = 54;
            label6.Text = "Статус:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(466, 248);
            label5.Name = "label5";
            label5.Size = new Size(175, 27);
            label5.TabIndex = 53;
            label5.Text = "Номер телефону:";
            // 
            // phoneNumberField
            // 
            phoneNumberField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            phoneNumberField.Location = new Point(466, 279);
            phoneNumberField.Margin = new Padding(3, 4, 3, 4);
            phoneNumberField.Name = "phoneNumberField";
            phoneNumberField.Size = new Size(358, 30);
            phoneNumberField.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(49, 248);
            label4.Name = "label4";
            label4.Size = new Size(69, 27);
            label4.TabIndex = 51;
            label4.Text = "Email:";
            // 
            // emailField
            // 
            emailField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            emailField.Location = new Point(49, 279);
            emailField.Margin = new Padding(3, 4, 3, 4);
            emailField.Name = "emailField";
            emailField.Size = new Size(358, 30);
            emailField.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(466, 165);
            label3.Name = "label3";
            label3.Size = new Size(212, 27);
            label3.TabIndex = 49;
            label3.Text = "Прізвище замовника:";
            // 
            // customerSurnameField
            // 
            customerSurnameField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            customerSurnameField.Location = new Point(466, 196);
            customerSurnameField.Margin = new Padding(3, 4, 3, 4);
            customerSurnameField.Name = "customerSurnameField";
            customerSurnameField.Size = new Size(358, 30);
            customerSurnameField.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(49, 165);
            label8.Name = "label8";
            label8.Size = new Size(156, 27);
            label8.TabIndex = 47;
            label8.Text = "Ім'я замовника:";
            // 
            // customerNameField
            // 
            customerNameField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            customerNameField.Location = new Point(49, 196);
            customerNameField.Margin = new Padding(3, 4, 3, 4);
            customerNameField.Name = "customerNameField";
            customerNameField.Size = new Size(358, 30);
            customerNameField.TabIndex = 46;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(49, 419);
            label9.Name = "label9";
            label9.Size = new Size(110, 27);
            label9.TabIndex = 59;
            label9.Text = "Примітки:";
            // 
            // notesField
            // 
            notesField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            notesField.Location = new Point(49, 450);
            notesField.Margin = new Padding(3, 4, 3, 4);
            notesField.Multiline = true;
            notesField.Name = "notesField";
            notesField.Size = new Size(775, 76);
            notesField.TabIndex = 58;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UpdatedOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 678);
            Controls.Add(label9);
            Controls.Add(notesField);
            Controls.Add(paymentStatus);
            Controls.Add(orderStatus);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(phoneNumberField);
            Controls.Add(label4);
            Controls.Add(emailField);
            Controls.Add(label3);
            Controls.Add(customerSurnameField);
            Controls.Add(label8);
            Controls.Add(customerNameField);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(titleField);
            Controls.Add(cancelButton);
            Controls.Add(saveOrderButton);
            Icon = Properties.Resources.BssIcon;
            Name = "UpdatedOrderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BSS";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox titleField;
        private Button cancelButton;
        private Button saveOrderButton;
        private ComboBox paymentStatus;
        private ComboBox orderStatus;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox phoneNumberField;
        private Label label4;
        private TextBox emailField;
        private Label label3;
        private TextBox customerSurnameField;
        private Label label8;
        private TextBox customerNameField;
        private Label label9;
        private TextBox notesField;
        private ErrorProvider errorProvider1;
    }
}