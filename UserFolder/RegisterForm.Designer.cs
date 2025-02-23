namespace BookSalesSystem2._0
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            topPanel = new Panel();
            label1 = new Label();
            regLastNameField = new TextBox();
            regFirstNameField = new TextBox();
            regEmailField = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            signUpButton = new Button();
            canselButton = new Button();
            regPasswordField = new TextBox();
            label6 = new Label();
            regConfirmPasswordBox = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(101, 39, 253);
            topPanel.Controls.Add(label1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(571, 108);
            topPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(101, 39, 253);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Palatino Linotype", 22.2F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(571, 108);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // regLastNameField
            // 
            regLastNameField.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            regLastNameField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            regLastNameField.Location = new Point(276, 207);
            regLastNameField.Margin = new Padding(3, 4, 3, 4);
            regLastNameField.Name = "regLastNameField";
            regLastNameField.Size = new Size(236, 30);
            regLastNameField.TabIndex = 2;
            regLastNameField.TextChanged += regLastNameField_TextChanged;
            // 
            // regFirstNameField
            // 
            regFirstNameField.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            regFirstNameField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            regFirstNameField.Location = new Point(276, 151);
            regFirstNameField.Margin = new Padding(3, 4, 3, 4);
            regFirstNameField.Name = "regFirstNameField";
            regFirstNameField.Size = new Size(236, 30);
            regFirstNameField.TabIndex = 3;
            regFirstNameField.TextChanged += regFirstNameField_TextChanged;
            // 
            // regEmailField
            // 
            regEmailField.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            regEmailField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            regEmailField.Location = new Point(276, 258);
            regEmailField.Margin = new Padding(3, 4, 3, 4);
            regEmailField.Name = "regEmailField";
            regEmailField.Size = new Size(236, 30);
            regEmailField.TabIndex = 4;
            regEmailField.TextChanged += regEmailField_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(62, 154);
            label2.Name = "label2";
            label2.Size = new Size(167, 27);
            label2.TabIndex = 6;
            label2.Text = "Enter your name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(62, 314);
            label3.Name = "label3";
            label3.Size = new Size(182, 27);
            label3.TabIndex = 7;
            label3.Text = "Create a password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(62, 206);
            label4.Name = "label4";
            label4.Size = new Size(196, 27);
            label4.TabIndex = 8;
            label4.Text = "Enter your surname:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(62, 261);
            label5.Name = "label5";
            label5.Size = new Size(167, 27);
            label5.TabIndex = 9;
            label5.Text = "Enter your email:";
            // 
            // signUpButton
            // 
            signUpButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            signUpButton.AutoSize = true;
            signUpButton.BackColor = Color.FromArgb(101, 39, 253);
            signUpButton.Cursor = Cursors.Hand;
            signUpButton.FlatAppearance.BorderSize = 0;
            signUpButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            signUpButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            signUpButton.FlatStyle = FlatStyle.Flat;
            signUpButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            signUpButton.ForeColor = Color.White;
            signUpButton.Location = new Point(410, 458);
            signUpButton.Margin = new Padding(3, 4, 3, 4);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(102, 38);
            signUpButton.TabIndex = 10;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // canselButton
            // 
            canselButton.AutoSize = true;
            canselButton.BackColor = Color.WhiteSmoke;
            canselButton.Cursor = Cursors.Hand;
            canselButton.FlatAppearance.BorderColor = Color.LightGray;
            canselButton.FlatStyle = FlatStyle.Flat;
            canselButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            canselButton.ForeColor = Color.DimGray;
            canselButton.Location = new Point(276, 458);
            canselButton.Margin = new Padding(3, 4, 3, 4);
            canselButton.Name = "canselButton";
            canselButton.Size = new Size(102, 38);
            canselButton.TabIndex = 11;
            canselButton.Text = "Cancel";
            canselButton.UseVisualStyleBackColor = false;
            canselButton.Click += canselButton_Click;
            // 
            // regPasswordField
            // 
            regPasswordField.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            regPasswordField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            regPasswordField.Location = new Point(276, 311);
            regPasswordField.Margin = new Padding(3, 4, 3, 4);
            regPasswordField.Name = "regPasswordField";
            regPasswordField.PasswordChar = '*';
            regPasswordField.Size = new Size(236, 30);
            regPasswordField.TabIndex = 12;
            regPasswordField.UseSystemPasswordChar = true;
            regPasswordField.TextChanged += regPasswordField_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(62, 366);
            label6.Name = "label6";
            label6.Size = new Size(183, 27);
            label6.TabIndex = 13;
            label6.Text = "Confirm password:";
            // 
            // regConfirmPasswordBox
            // 
            regConfirmPasswordBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            regConfirmPasswordBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            regConfirmPasswordBox.Location = new Point(276, 363);
            regConfirmPasswordBox.Margin = new Padding(3, 4, 3, 4);
            regConfirmPasswordBox.Name = "regConfirmPasswordBox";
            regConfirmPasswordBox.PasswordChar = '*';
            regConfirmPasswordBox.Size = new Size(236, 30);
            regConfirmPasswordBox.TabIndex = 14;
            regConfirmPasswordBox.UseSystemPasswordChar = true;
            regConfirmPasswordBox.TextChanged += regConfirmPasswordBox_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(571, 532);
            Controls.Add(regConfirmPasswordBox);
            Controls.Add(label6);
            Controls.Add(regPasswordField);
            Controls.Add(canselButton);
            Controls.Add(signUpButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(regEmailField);
            Controls.Add(regFirstNameField);
            Controls.Add(regLastNameField);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BSS";
            Load += RegisterForm_Load;
            Click += RegisterForm_Click;
            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel topPanel;
        private Label label1;
        private TextBox regLastNameField;
        private TextBox regFirstNameField;
        private TextBox regEmailField;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button signUpButton;
        private Button canselButton;
        private TextBox regPasswordField;
        private Label label6;
        private TextBox regConfirmPasswordBox;
        private ErrorProvider errorProvider1;
    }
}