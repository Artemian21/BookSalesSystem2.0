using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookSalesSystem2._0.BookFolder;

namespace BookSalesSystem2._0
{
    public partial class UpdatedBookForm : Form
    {
        public Book UpdatedBook { get; private set; }
        private Book currentBook;
        private readonly ValidateBookInput bookValidator;

        public UpdatedBookForm(Book book)
        {
            InitializeComponent();
            currentBook = book;
            bookValidator = new ValidateBookInput(errorProvider1);

            titleField.Text = book.Title;
            authorField.Text = book.Author;
            genreField.Text = book.Genre;
            isbnField.Text = book.ISBN;
            priceField.Text = book.Price.ToString();
            stockField.Text = book.Stock.ToString();
        }

        private void saveBookButton_Click(object sender, EventArgs e)
        {
            var bookModel = new Book
            {
                ID = currentBook.ID,
                Title = titleField.Text,
                Author = authorField.Text,
                Genre = genreField.Text,
                ISBN = isbnField.Text,
                Price = ParsePrice(),
                Stock = ParseStock()
            };

            if (bookValidator.Validate(bookModel, titleField, authorField, genreField, isbnField, priceField, stockField))
            {
                UpdatedBook = bookModel;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private decimal ParsePrice()
        {
            decimal price;
            if (!decimal.TryParse(priceField.Text, out price) || price < 0)
            {
                MessageBox.Show("Введіть правильну ціну.");
                return -1;
            }
            return price;
        }

        private int ParseStock()
        {
            int stock;
            if (!int.TryParse(stockField.Text, out stock) || stock < 0)
            {
                MessageBox.Show("Введіть правильну кількість.");
                return -1;
            }
            return stock;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdatedBookForm_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
    }
}
