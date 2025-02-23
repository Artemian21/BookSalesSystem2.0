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
    public partial class BookControl : UserControl
    {
        private readonly BookManager _bookManager;
        private List<Book> _booksList;
        private BindingList<Book> _filteredList;

        public BookControl()
        {
            InitializeComponent();
            _bookManager = new BookManager();
            _filteredList = new BindingList<Book>();
            LoadBooks();
        }

        private async void LoadBooks()
        {
            dataGridView1.AutoGenerateColumns = false;
            try
            {
                _booksList = await _bookManager.GetBooksAsync();
                UpdateDataGrid(_booksList);
            }
            catch (Exception ex)
            {
                ShowError("Помилка завантаження книг: " + ex.Message);
            }
        }

        private void UpdateDataGrid(List<Book> books)
        {
            _filteredList.Clear();
            books.ForEach(book => _filteredList.Add(book));
            dataGridView1.DataSource = _filteredList;
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var book = dataGridView1.Rows[e.RowIndex].DataBoundItem as Book;
            if (book == null) return;

            if (e.ColumnIndex == dataGridView1.Columns["deleteButton"].Index)
            {
                await HandleDeleteBook(book);
            }
            else if (e.ColumnIndex == dataGridView1.Columns["editButton"].Index)
            {
                await HandleEditBook(book);
            }
        }

        private async Task HandleDeleteBook(Book book)
        {
            if (MessageBox.Show("Ви впевнені, що хочете видалити цю книгу?",
                                "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (await _bookManager.DeleteBookAsync(book.ID))
                    RefreshBooks();
                else
                    ShowError("Не вдалося видалити книгу.");
            }
        }

        private async Task HandleEditBook(Book book)
        {
            using (var updatedBookForm = new UpdatedBookForm(book))
            {
                if (updatedBookForm.ShowDialog(this) == DialogResult.OK)
                {
                    if (await _bookManager.UpdateBookAsync(updatedBookForm.UpdatedBook))
                        RefreshBooks();
                    else
                        ShowError("Не вдалося оновити книгу.");
                }
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is MainForm mainForm)
            {
                mainForm.LoadControl(new AddBookControl(mainForm));
            }
        }

        public void RefreshBooks()
        {
            LoadBooks();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string query = searchBox.Text.ToLower();
            var filteredBooks = string.IsNullOrWhiteSpace(query) ? _booksList :
                _booksList.Where(b => b.Title.ToLower().Contains(query) ||
                                      b.Author.ToLower().Contains(query) ||
                                      b.Genre.ToLower().Contains(query) ||
                                      b.ISBN.ToLower().Contains(query) ||
                                      b.Price.ToString().Contains(query)).ToList();

            UpdateDataGrid(filteredBooks);
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
