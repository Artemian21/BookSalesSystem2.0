using BookSalesSystem2._0.UserFolder;

namespace BookSalesSystem2._0
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void LoginForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var userModel = new User { Email = logEmailField.Text, Password = logPasswordField.Text};
            bool validate = ValidateUserInput.ValidateLogInput(errorProvider1, userModel, logEmailField, logPasswordField);

            if (validate)
            {
                try
                {
                    bool result = UserService.Login(userModel.Email, userModel.Password);
                    if (result)
                    {
                        MainForm mainForm = new MainForm();
                        this.Hide();
                        mainForm.ShowDialog();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}", "Помилка входу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void registerFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerForm = new RegisterForm();
            registerForm.FormClosed += (s, args) => this.Show();
            registerForm.Show();

        }

        private void logEmailField_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(logEmailField, "");
        }

        private void logPasswordField_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(logPasswordField, "");
        }
    }
}
