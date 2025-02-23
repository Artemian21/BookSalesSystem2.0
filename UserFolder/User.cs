using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookSalesSystem2._0.UserFolder
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Це обов'язкове поле")]
        [EmailAddress(ErrorMessage = "Некоректний формат пошти")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Це обов'язкове поле")]
        [MinLength(8, ErrorMessage = "Має бути мінімум 8 символів")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]+$",
    ErrorMessage = "Пароль повинен містити букви, цифри та спеціальні символи.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Це обов'язкове поле")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Це обов'язкове поле")]
        public string LastName { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Це обов'язкове поле")]
        [Compare("Password", ErrorMessage = "Паролі не співпадають")]
        public string ConfirmPassword { get; set; }

        public bool Authenticate(string inputPassword)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputPassword));
                string hashInputPassword = Convert.ToBase64String(hashBytes);

                return Password == hashInputPassword;
            }
        }

        public void SetPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                Password = Convert.ToBase64String(hashBytes);
            }
        }
    }
}
