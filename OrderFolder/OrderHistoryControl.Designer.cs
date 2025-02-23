namespace BookSalesSystem2._0
{
    partial class OrderHistoryControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            searchOrderBox = new TextBox();
            orderDataGridView = new DataGridView();
            CustomerName = new DataGridViewTextBoxColumn();
            CustomerSurname = new DataGridViewTextBoxColumn();
            CustomerEmail = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            PaymentStatus = new DataGridViewTextBoxColumn();
            editButton = new DataGridViewButtonColumn();
            deleteButton = new DataGridViewButtonColumn();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)orderDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(115, 17);
            label2.Name = "label2";
            label2.Size = new Size(82, 27);
            label2.TabIndex = 18;
            label2.Text = "Пошук:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 7);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 17;
            // 
            // searchOrderBox
            // 
            searchOrderBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchOrderBox.Font = new Font("Times New Roman", 12F);
            searchOrderBox.Location = new Point(219, 17);
            searchOrderBox.Name = "searchOrderBox";
            searchOrderBox.Size = new Size(574, 30);
            searchOrderBox.TabIndex = 16;
            searchOrderBox.TextChanged += searchOrderBox_TextChanged;
            // 
            // orderDataGridView
            // 
            orderDataGridView.AllowUserToOrderColumns = true;
            orderDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderDataGridView.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(57, 40, 179);
            dataGridViewCellStyle1.Font = new Font("Palatino Linotype", 11.2F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            orderDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            orderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDataGridView.Columns.AddRange(new DataGridViewColumn[] { CustomerName, CustomerSurname, CustomerEmail, PhoneNumber, OrderDate, TotalPrice, Status, PaymentStatus, editButton, deleteButton });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Palatino Linotype", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            orderDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            orderDataGridView.EnableHeadersVisualStyles = false;
            orderDataGridView.GridColor = SystemColors.HotTrack;
            orderDataGridView.Location = new Point(14, 68);
            orderDataGridView.Name = "orderDataGridView";
            orderDataGridView.ReadOnly = true;
            orderDataGridView.RowHeadersWidth = 51;
            orderDataGridView.Size = new Size(861, 440);
            orderDataGridView.TabIndex = 15;
            orderDataGridView.CellContentClick += orderDataGridView_CellContentClick;
            // 
            // CustomerName
            // 
            CustomerName.DataPropertyName = "CustomerName";
            CustomerName.HeaderText = "Ім'я";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            // 
            // CustomerSurname
            // 
            CustomerSurname.DataPropertyName = "CustomerSurname";
            CustomerSurname.HeaderText = "Прізвище";
            CustomerSurname.MinimumWidth = 6;
            CustomerSurname.Name = "CustomerSurname";
            CustomerSurname.ReadOnly = true;
            // 
            // CustomerEmail
            // 
            CustomerEmail.DataPropertyName = "CustomerEmail";
            CustomerEmail.HeaderText = "Email";
            CustomerEmail.MinimumWidth = 6;
            CustomerEmail.Name = "CustomerEmail";
            CustomerEmail.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "Номер телефону";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            // 
            // OrderDate
            // 
            OrderDate.DataPropertyName = "OrderDate";
            OrderDate.HeaderText = "Дата";
            OrderDate.MinimumWidth = 6;
            OrderDate.Name = "OrderDate";
            OrderDate.ReadOnly = true;
            // 
            // TotalPrice
            // 
            TotalPrice.DataPropertyName = "TotalPrice";
            TotalPrice.HeaderText = "Сума";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Статус";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // PaymentStatus
            // 
            PaymentStatus.DataPropertyName = "PaymentStatus";
            PaymentStatus.HeaderText = "Оплата";
            PaymentStatus.MinimumWidth = 6;
            PaymentStatus.Name = "PaymentStatus";
            PaymentStatus.ReadOnly = true;
            // 
            // editButton
            // 
            editButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(79, 240, 83);
            dataGridViewCellStyle2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold | FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(53, 176, 55);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            editButton.DefaultCellStyle = dataGridViewCellStyle2;
            editButton.FillWeight = 85.5615F;
            editButton.HeaderText = "";
            editButton.MinimumWidth = 6;
            editButton.Name = "editButton";
            editButton.ReadOnly = true;
            editButton.Resizable = DataGridViewTriState.False;
            editButton.Text = "✏ Редагувати";
            editButton.UseColumnTextForButtonValue = true;
            // 
            // deleteButton
            // 
            deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 72, 65);
            dataGridViewCellStyle3.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(168, 48, 43);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            deleteButton.DefaultCellStyle = dataGridViewCellStyle3;
            deleteButton.FillWeight = 76.41129F;
            deleteButton.HeaderText = "";
            deleteButton.MinimumWidth = 6;
            deleteButton.Name = "deleteButton";
            deleteButton.ReadOnly = true;
            deleteButton.Resizable = DataGridViewTriState.False;
            deleteButton.Text = "❌ Видалити";
            deleteButton.UseColumnTextForButtonValue = true;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backButton.AutoSize = true;
            backButton.BackColor = Color.FromArgb(101, 39, 253);
            backButton.Cursor = Cursors.Hand;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            backButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(14, 524);
            backButton.Margin = new Padding(3, 4, 3, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(183, 42);
            backButton.TabIndex = 19;
            backButton.Text = "Повернутися назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // OrderHistoryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(backButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchOrderBox);
            Controls.Add(orderDataGridView);
            Name = "OrderHistoryControl";
            Size = new Size(888, 583);
            ((System.ComponentModel.ISupportInitialize)orderDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox searchOrderBox;
        private DataGridView orderDataGridView;
        private Button backButton;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn CustomerSurname;
        private DataGridViewTextBoxColumn CustomerEmail;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn PaymentStatus;
        private DataGridViewButtonColumn editButton;
        private DataGridViewButtonColumn deleteButton;
    }
}
