using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace BookSalesSystem2._0.BookFolder
{
    public class ValidateBookInput
    {
        public readonly ErrorProvider errorProvider;

        public ValidateBookInput(ErrorProvider errorProvider)
        {
            this.errorProvider = errorProvider;
        }

        public bool Validate(Book book, TextBox title, TextBox author, TextBox genre, TextBox isbn, TextBox price, TextBox stock)
        {
            errorProvider.Clear();

            var validationContext = new ValidationContext(book);
            var validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(book, validationContext, validationResults, true);

            if (!isValid)
            {
                SetErrorMessages(validationResults, title, author, genre, isbn, price, stock);
                return false;
            }
            return true;
        }

        private void SetErrorMessages(List<ValidationResult> validationResults, TextBox title, TextBox author, TextBox genre, TextBox isbn, TextBox price, TextBox stock)
        {
            foreach (var validationResult in validationResults)
            {
                if (validationResult.MemberNames.Contains("Title"))
                    errorProvider.SetError(title, validationResult.ErrorMessage);
                if (validationResult.MemberNames.Contains("Author"))
                    errorProvider.SetError(author, validationResult.ErrorMessage);
                if (validationResult.MemberNames.Contains("Genre"))
                    errorProvider.SetError(genre, validationResult.ErrorMessage);
                if (validationResult.MemberNames.Contains("ISBN"))
                    errorProvider.SetError(isbn, validationResult.ErrorMessage);
                if (validationResult.MemberNames.Contains("Price"))
                    errorProvider.SetError(price, validationResult.ErrorMessage);
                if (validationResult.MemberNames.Contains("Stock"))
                    errorProvider.SetError(stock, validationResult.ErrorMessage);
            }
        }
    }
}
