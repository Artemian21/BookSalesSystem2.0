using System.ComponentModel.DataAnnotations;

namespace BookSalesSystem2._0.UserFolder
{
    public class ValidateUserInput
    {
        public static bool ValidateLogInput(ErrorProvider errorProvider, User userModel, TextBox txtEmail, TextBox txtPassword)
        {
            errorProvider.Clear();

            var validationContext = new ValidationContext(userModel);
            var validationResults = new List<ValidationResult>();

            Validator.TryValidateObject(userModel, validationContext, validationResults, true);

            // Фільтрація помилок, що не стосуються даної форми
            validationResults = validationResults
                .Where(x => !x.MemberNames.Contains("ConfirmPassword") &&
                            !x.MemberNames.Contains("FirstName") &&
                            !x.MemberNames.Contains("LastName") &&
                            !(x.MemberNames.Contains("Password") && x.ErrorMessage.Contains("Пароль повинен містити букви, цифри та спеціальні символи.")))
                .ToList();

            if (validationResults.Any())
            {
                foreach (var validationResult in validationResults)
                {
                    if (validationResult.MemberNames.Contains("Email"))
                    {
                        errorProvider.SetError(txtEmail, validationResult.ErrorMessage);
                    }
                    if (validationResult.MemberNames.Contains("Password"))
                    {
                        errorProvider.SetError(txtPassword, validationResult.ErrorMessage);
                    }
                }
                return false;
            }

            return true;
        }

        public static bool ValidateRegInput(ErrorProvider errorProvider, User userModel, TextBox textBoxFirstname, TextBox textBoxLastname, TextBox textBoxEmail, TextBox textBoxPassword, TextBox textBoxConfPassword)
        {
            errorProvider.Clear();

            var validationContext = new ValidationContext(userModel);
            var validationResults = new List<ValidationResult>();

            Validator.TryValidateObject(userModel, validationContext, validationResults, true);

            if (validationResults.Any())
            {
                foreach (var validationResult in validationResults)
                {
                    var field = validationResult.MemberNames.FirstOrDefault();
                    if (field == "FirstName")
                        errorProvider.SetError(textBoxFirstname, validationResult.ErrorMessage);
                    if (field == "LastName")
                        errorProvider.SetError(textBoxLastname, validationResult.ErrorMessage);
                    if (field == "Email")
                        errorProvider.SetError(textBoxEmail, validationResult.ErrorMessage);
                    if (field == "Password")
                        errorProvider.SetError(textBoxPassword, validationResult.ErrorMessage);
                    if (field == "ConfirmPassword")
                        errorProvider.SetError(textBoxConfPassword, validationResult.ErrorMessage);
                }
                return false;
            }

            return true;
        }
    }
}
