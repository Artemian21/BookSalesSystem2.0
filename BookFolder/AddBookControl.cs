using BookSalesSystem2._0.BookFolder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSalesSystem2._0
{
    public partial class AddBookControl : UserControl
    {
        private readonly MainForm mainForm;
        private readonly ValidateBookInput bookValidator;

        public AddBookControl(MainForm mainForm)
        {
            InitializeComponent();
            this.bookValidator = new ValidateBookInput(errorProvider1);
            this.mainForm = mainForm;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.ParentForm;
            mainForm.LoadControl(new BookControl());
        }

        private async void addBookButton_Click(object sender, EventArgs e)
        {
            var bookModel = new Book
            {
                Title = titleField.Text,
                Author = authorField.Text,
                Genre = genreField.Text,
                ISBN = isbnField.Text,
                Price = ParsePrice(),
                Stock = ParseStock()
            };

            if (bookModel.Price == -1 || bookModel.Stock == -1) return;

            bool validate = bookValidator.Validate(bookModel, titleField, authorField, genreField, isbnField, priceField, stockField);
            if (!validate) return;

            BookService bookService = new BookService();
            bool isAdded = await bookService.AddBookAsync(bookModel);

            if (isAdded)
            {
                RefreshBooks();
            }
            else
            {
                MessageBox.Show("Не вдалося додати книгу.");
            }
        }

        private decimal ParsePrice()
        {
            decimal price;
            if (!decimal.TryParse(priceField.Text, out price) || price <= 0)
            {
                MessageBox.Show("Введіть коректну ціну.");
                return -1;
            }
            return price;
        }

        private int ParseStock()
        {
            int stock;
            if (!int.TryParse(stockField.Text, out stock) || stock < 0)
            {
                MessageBox.Show("Введіть кількість екземплярів книги.");
                return -1;
            }
            return stock;
        }

        private void RefreshBooks()
        {
            BookControl bookControl = new BookControl();
            bookControl.RefreshBooks();
            mainForm.LoadControl(bookControl);
        }

        private void AddBookControl_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
