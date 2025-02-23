using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookSalesSystem2._0.UserFolder
{
    public class UserService
    {
        public static bool Register(string email, string password, string confirmPassword, string firstName, string lastName)
        {
            using (var context = new BookSalesSystemContext())
            {
                var existingUser = context.Users.FirstOrDefault(u => u.Email == email);
                if (existingUser != null)
                {
                    MessageBox.Show("Користувач з такою поштою вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (password != confirmPassword)
                {
                    MessageBox.Show("Паролі не співпадають", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                var user = new User
                {
                    Email = email,
                    FirstName = firstName,
                    LastName = lastName
                };
                user.SetPassword(password);

                context.Users.Add(user);
                context.SaveChanges();

                MessageBox.Show("Реєстрація успішна!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        public static bool Login(string email, string password)
        {
            using (var context = new BookSalesSystemContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Email == email);
                if (user == null)
                {
                    MessageBox.Show("Користувача з такою поштою не існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!user.Authenticate(password))
                {
                    MessageBox.Show("Неправильний пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
        }
    }
}
