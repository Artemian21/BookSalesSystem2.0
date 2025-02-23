using BookSalesSystem2._0.OrderFolder;

namespace BookSalesSystem2._0
{
    partial class OrderControl
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
            addOrderButton = new Button();
            viewOrderHistoryButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            customerNameField = new TextBox();
            label3 = new Label();
            customerSurnameField = new TextBox();
            label4 = new Label();
            emailField = new TextBox();
            label5 = new Label();
            phoneNumberField = new TextBox();
            label6 = new Label();
            label7 = new Label();
            orderStatus = new ComboBox();
            paymentStatus = new ComboBox();
            flowLayoutPanel = new FlowLayoutPanel();
            notesField = new TextBox();
            label8 = new Label();
            label9 = new Label();
            labelTotalPrice = new Label();
            errorProvider1 = new ErrorProvider(components);
            searchTextBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // addOrderButton
            // 
            addOrderButton.AutoSize = true;
            addOrderButton.BackColor = Color.FromArgb(101, 39, 253);
            addOrderButton.Cursor = Cursors.Hand;
            addOrderButton.FlatAppearance.BorderSize = 0;
            addOrderButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            addOrderButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            addOrderButton.FlatStyle = FlatStyle.Flat;
            addOrderButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addOrderButton.ForeColor = Color.White;
            addOrderButton.Location = new Point(854, 835);
            addOrderButton.Margin = new Padding(3, 4, 3, 4);
            addOrderButton.Name = "addOrderButton";
            addOrderButton.Size = new Size(222, 42);
            addOrderButton.TabIndex = 10;
            addOrderButton.Text = "Сформувати замовлення";
            addOrderButton.UseVisualStyleBackColor = false;
            addOrderButton.Click += addOrderButton_Click;
            // 
            // viewOrderHistoryButton
            // 
            viewOrderHistoryButton.AutoSize = true;
            viewOrderHistoryButton.BackColor = Color.FromArgb(101, 39, 253);
            viewOrderHistoryButton.Cursor = Cursors.Hand;
            viewOrderHistoryButton.FlatAppearance.BorderSize = 0;
            viewOrderHistoryButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            viewOrderHistoryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            viewOrderHistoryButton.FlatStyle = FlatStyle.Flat;
            viewOrderHistoryButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            viewOrderHistoryButton.ForeColor = Color.White;
            viewOrderHistoryButton.Location = new Point(63, 835);
            viewOrderHistoryButton.Margin = new Padding(3, 4, 3, 4);
            viewOrderHistoryButton.Name = "viewOrderHistoryButton";
            viewOrderHistoryButton.Size = new Size(273, 42);
            viewOrderHistoryButton.TabIndex = 11;
            viewOrderHistoryButton.Text = "Переглянути історію замовлень";
            viewOrderHistoryButton.UseVisualStyleBackColor = false;
            viewOrderHistoryButton.Click += viewOrderHistoryButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(101, 39, 253);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 115);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Palatino Linotype", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1144, 115);
            label1.TabIndex = 1;
            label1.Text = "Замовлення";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(129, 146);
            label2.Name = "label2";
            label2.Size = new Size(156, 27);
            label2.TabIndex = 18;
            label2.Text = "Ім'я замовника:";
            // 
            // customerNameField
            // 
            customerNameField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            customerNameField.Location = new Point(129, 177);
            customerNameField.Margin = new Padding(3, 4, 3, 4);
            customerNameField.Name = "customerNameField";
            customerNameField.Size = new Size(372, 30);
            customerNameField.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(622, 146);
            label3.Name = "label3";
            label3.Size = new Size(212, 27);
            label3.TabIndex = 20;
            label3.Text = "Прізвище замовника:";
            // 
            // customerSurnameField
            // 
            customerSurnameField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            customerSurnameField.Location = new Point(622, 177);
            customerSurnameField.Margin = new Padding(3, 4, 3, 4);
            customerSurnameField.Name = "customerSurnameField";
            customerSurnameField.Size = new Size(372, 30);
            customerSurnameField.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(129, 229);
            label4.Name = "label4";
            label4.Size = new Size(69, 27);
            label4.TabIndex = 22;
            label4.Text = "Email:";
            // 
            // emailField
            // 
            emailField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            emailField.Location = new Point(129, 260);
            emailField.Margin = new Padding(3, 4, 3, 4);
            emailField.Name = "emailField";
            emailField.Size = new Size(372, 30);
            emailField.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(622, 229);
            label5.Name = "label5";
            label5.Size = new Size(175, 27);
            label5.TabIndex = 24;
            label5.Text = "Номер телефону:";
            // 
            // phoneNumberField
            // 
            phoneNumberField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            phoneNumberField.Location = new Point(622, 260);
            phoneNumberField.Margin = new Padding(3, 4, 3, 4);
            phoneNumberField.Name = "phoneNumberField";
            phoneNumberField.Size = new Size(372, 30);
            phoneNumberField.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(129, 317);
            label6.Name = "label6";
            label6.Size = new Size(81, 27);
            label6.TabIndex = 26;
            label6.Text = "Статус:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(621, 317);
            label7.Name = "label7";
            label7.Size = new Size(154, 27);
            label7.TabIndex = 28;
            label7.Text = "Статус оплати:";
            // 
            // orderStatus
            // 
            orderStatus.FormattingEnabled = true;
            orderStatus.Items.AddRange(new object[] { OrderStatus.Розгляд, OrderStatus.Обробка, OrderStatus.Завершено, OrderStatus.Скасовано });
            orderStatus.Location = new Point(227, 316);
            orderStatus.Name = "orderStatus";
            orderStatus.Size = new Size(183, 28);
            orderStatus.TabIndex = 29;
            // 
            // paymentStatus
            // 
            paymentStatus.FormattingEnabled = true;
            paymentStatus.Items.AddRange(new object[] { PaymentStatus.Неоплачено, PaymentStatus.Оплачено, PaymentStatus.Відшкодовано });
            paymentStatus.Location = new Point(780, 316);
            paymentStatus.Name = "paymentStatus";
            paymentStatus.Size = new Size(183, 28);
            paymentStatus.TabIndex = 30;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.BackColor = SystemColors.ButtonHighlight;
            flowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel.Font = new Font("Palatino Linotype", 12F);
            flowLayoutPanel.ForeColor = Color.Black;
            flowLayoutPanel.Location = new Point(60, 422);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(1016, 182);
            flowLayoutPanel.TabIndex = 31;
            // 
            // notesField
            // 
            notesField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            notesField.Location = new Point(60, 688);
            notesField.Margin = new Padding(3, 4, 3, 4);
            notesField.Multiline = true;
            notesField.Name = "notesField";
            notesField.Size = new Size(1016, 76);
            notesField.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(60, 657);
            label8.Name = "label8";
            label8.Size = new Size(110, 27);
            label8.TabIndex = 33;
            label8.Text = "Примітки:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(60, 377);
            label9.Name = "label9";
            label9.Size = new Size(284, 27);
            label9.TabIndex = 34;
            label9.Text = "Оберіть книгу та їх кількість:";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTotalPrice.Location = new Point(828, 621);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(166, 27);
            labelTotalPrice.TabIndex = 35;
            labelTotalPrice.Text = "До сплати: 0 грн";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchTextBox.Location = new Point(704, 374);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Пошук книги";
            searchTextBox.Size = new Size(372, 30);
            searchTextBox.TabIndex = 36;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // OrderControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(searchTextBox);
            Controls.Add(labelTotalPrice);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(notesField);
            Controls.Add(flowLayoutPanel);
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
            Controls.Add(label2);
            Controls.Add(customerNameField);
            Controls.Add(panel1);
            Controls.Add(viewOrderHistoryButton);
            Controls.Add(addOrderButton);
            Name = "OrderControl";
            Size = new Size(1147, 930);
            Click += OrderControl_Click;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addOrderButton;
        private Button viewOrderHistoryButton;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox customerNameField;
        private Label label3;
        private TextBox customerSurnameField;
        private Label label4;
        private TextBox emailField;
        private Label label5;
        private TextBox phoneNumberField;
        private Label label6;
        private Label label7;
        private ComboBox orderStatus;
        private ComboBox paymentStatus;
        private FlowLayoutPanel flowLayoutPanel;
        private TextBox notesField;
        private Label label8;
        private Label label9;
        private Label labelTotalPrice;
        private ErrorProvider errorProvider1;
        private TextBox searchTextBox;
    }
}
