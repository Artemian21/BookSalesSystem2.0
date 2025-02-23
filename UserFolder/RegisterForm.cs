using BookSalesSystem2._0.UserFolder;

namespace BookSalesSystem2._0
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void canselButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            var userModel = new User
            {
                Email = regEmailField.Text,
                Password = regPasswordField.Text,
                ConfirmPassword = regConfirmPasswordBox.Text,
                FirstName = regFirstNameField.Text,
                LastName = regLastNameField.Text
            };
            bool validate = ValidateUserInput.ValidateRegInput(errorProvider1, userModel, regFirstNameField, regLastNameField, regEmailField, regPasswordField, regConfirmPasswordBox);

            if (validate)
            {
                if (UserService.Register(userModel.Email, userModel.Password, regConfirmPasswordBox.Text, userModel.FirstName, userModel.LastName))
                {
                    this.Close();
                }
            }
        }

        private void regConfirmPasswordBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(regConfirmPasswordBox, "");
        }

        private void regPasswordField_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(regPasswordField, "");
        }

        private void regFirstNameField_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(regFirstNameField, "");
        }

        private void regEmailField_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(regEmailField, "");
        }

        private void regLastNameField_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(regLastNameField, "");
        }
    }
}
