using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSalesSystem2._0.OrderFolder
{
    public class ValidateOrderInput
    {
        public static bool ValidateInput(ErrorProvider errorProvider, Order order, TextBox nameBox, TextBox surnameBox, TextBox emailBox, TextBox phoneNumberBox, decimal priceBox, ComboBox orderStatusBox, ComboBox paymentStatusBox)
        {
            errorProvider.Clear();

            var validationContext = new ValidationContext(order);
            var validationResults = new List<ValidationResult>();

            Validator.TryValidateObject(order, validationContext, validationResults, true);

            bool isValid = validationResults.Count == 0;

            if (!isValid)
            {
                foreach (var validationResult in validationResults)
                {
                    if (validationResult.MemberNames.Contains("CustomerName"))
                        errorProvider.SetError(nameBox, validationResult.ErrorMessage);
                    if (validationResult.MemberNames.Contains("CustomerSurname"))
                        errorProvider.SetError(surnameBox, validationResult.ErrorMessage);
                    if (validationResult.MemberNames.Contains("CustomerEmail"))
                        errorProvider.SetError(emailBox, validationResult.ErrorMessage);
                    if (validationResult.MemberNames.Contains("PhoneNumber"))
                        errorProvider.SetError(phoneNumberBox, validationResult.ErrorMessage);
                    if (validationResult.MemberNames.Contains("Status"))
                        errorProvider.SetError(orderStatusBox, validationResult.ErrorMessage);
                    if (validationResult.MemberNames.Contains("PaymentStatus"))
                        errorProvider.SetError(paymentStatusBox, validationResult.ErrorMessage);
                }
                if (priceBox <= 0)
                    MessageBox.Show("Сума замовлення дорівнює 0. Ви нічого не обрали?", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool ValidateUpdateInput(ErrorProvider errorProvider, Order order, TextBox nameBox, TextBox surnameBox, TextBox emailBox, TextBox phoneNumberBox, ComboBox orderStatusBox, ComboBox paymentStatusBox)
        {
            errorProvider.Clear();

            var validationContext = new ValidationContext(order);
            var validationResults = new List<ValidationResult>();

            Validator.TryValidateObject(order, validationContext, validationResults, true);


            bool isValid = validationResults.Count == 0;

            if (!isValid)
            {
                foreach (var validationResult in validationResults)
                {
                    if (validationResult.MemberNames.Contains("CustomerName"))
                        errorProvider.SetError(nameBox, validationResult.ErrorMessage);
                    if (validationResult.MemberNames.Contains("CustomerSurname"))
                        errorProvider.SetError(surnameBox, validationResult.ErrorMessage);
                    if (validationResult.MemberNames.Contains("CustomerEmail"))
                        errorProvider.SetError(emailBox, validationResult.ErrorMessage);
                    if (validationResult.MemberNames.Contains("PhoneNumber"))
                        errorProvider.SetError(phoneNumberBox, validationResult.ErrorMessage);
                    if (validationResult.MemberNames.Contains("Status"))
                        errorProvider.SetError(orderStatusBox, validationResult.ErrorMessage);
                    if (validationResult.MemberNames.Contains("PaymentStatus"))
                        errorProvider.SetError(paymentStatusBox, validationResult.ErrorMessage);
                }
                return false;
            }
            return true;
        }
    }
}
