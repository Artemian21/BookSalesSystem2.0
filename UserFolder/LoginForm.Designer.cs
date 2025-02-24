namespace BookSalesSystem2._0
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            topPanel = new Panel();
            label1 = new Label();
            logEmailField = new TextBox();
            logPasswordField = new TextBox();
            loginButton = new Button();
            label2 = new Label();
            label3 = new Label();
            registerFormButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(101, 39, 253);
            topPanel.Controls.Add(label1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(3, 4, 3, 4);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(496, 121);
            topPanel.TabIndex = 0;
            topPanel.Tag = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(101, 39, 253);
            label1.Font = new Font("Palatino Linotype", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(496, 121);
            label1.TabIndex = 0;
            label1.Text = "Welcome to our community";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logEmailField
            // 
            logEmailField.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logEmailField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logEmailField.Location = new Point(119, 200);
            logEmailField.Margin = new Padding(3, 4, 3, 4);
            logEmailField.Name = "logEmailField";
            logEmailField.Size = new Size(305, 30);
            logEmailField.TabIndex = 1;
            logEmailField.TextChanged += logEmailField_TextChanged;
            // 
            // logPasswordField
            // 
            logPasswordField.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logPasswordField.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logPasswordField.Location = new Point(119, 316);
            logPasswordField.Margin = new Padding(3, 4, 3, 4);
            logPasswordField.Name = "logPasswordField";
            logPasswordField.PasswordChar = '*';
            logPasswordField.Size = new Size(305, 30);
            logPasswordField.TabIndex = 2;
            logPasswordField.UseSystemPasswordChar = true;
            logPasswordField.TextChanged += logPasswordField_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loginButton.AutoSize = true;
            loginButton.BackColor = Color.FromArgb(101, 39, 253);
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 13, 182);
            loginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 16, 230);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(322, 430);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(102, 41);
            loginButton.TabIndex = 3;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(73, 158);
            label2.Name = "label2";
            label2.Size = new Size(114, 27);
            label2.TabIndex = 4;
            label2.Text = "Your email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(73, 272);
            label3.Name = "label3";
            label3.Size = new Size(150, 27);
            label3.TabIndex = 5;
            label3.Text = "Your password:";
            // 
            // registerFormButton
            // 
            registerFormButton.AutoSize = true;
            registerFormButton.BackColor = Color.WhiteSmoke;
            registerFormButton.Cursor = Cursors.Hand;
            registerFormButton.FlatAppearance.BorderColor = Color.LightGray;
            registerFormButton.FlatStyle = FlatStyle.Flat;
            registerFormButton.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registerFormButton.ForeColor = Color.DimGray;
            registerFormButton.Location = new Point(175, 430);
            registerFormButton.Margin = new Padding(3, 4, 3, 4);
            registerFormButton.Name = "registerFormButton";
            registerFormButton.Size = new Size(102, 41);
            registerFormButton.TabIndex = 6;
            registerFormButton.Text = "Register";
            registerFormButton.UseVisualStyleBackColor = false;
            registerFormButton.Click += registerFormButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconEmail;
            pictureBox1.Location = new Point(73, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.iconPassword;
            pictureBox2.Location = new Point(76, 316);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(496, 532);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(registerFormButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(loginButton);
            Controls.Add(logPasswordField);
            Controls.Add(logEmailField);
            Controls.Add(topPanel);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = Properties.Resources.BssIcon;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BSS";
            Load += LoginForm_Load_1;
            Click += LoginForm_Click;
            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox logEmailField;
        private System.Windows.Forms.TextBox logPasswordField;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerFormButton;
        private ErrorProvider errorProvider1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}