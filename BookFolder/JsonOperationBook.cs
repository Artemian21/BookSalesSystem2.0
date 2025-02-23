using Newtonsoft.Json;

namespace BookSalesSystem2._0.BookFolder
{
    public class JsonOperationBook
    {
        private readonly string filePath = "books.json";

        public JsonOperationBook()
        {
            EnsureJsonFileExists();
        }

        private void EnsureJsonFileExists()
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]");
            }
        }

        public async Task AddBookToJson(Book book)
        {
            try
            {
                List<Book> books = await LoadBooksFromJsonAsync();
                books.Add(book);
                SaveBooksToJsonAsync(books);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка збереження даних в JSON: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task UpdateBookInJson(Book updatedBook)
        {
            try
            {
                List<Book> books = await LoadBooksFromJsonAsync();
                var book = books.Find(b => b.ID == updatedBook.ID);
                if (book != null)
                {
                    book.Title = updatedBook.Title;
                    book.Author = updatedBook.Author;
                    book.Genre = updatedBook.Genre;
                    book.ISBN = updatedBook.ISBN;
                    book.Price = updatedBook.Price;
                    book.Stock = updatedBook.Stock;
                    SaveBooksToJsonAsync(books);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка оновлення даних в JSON: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task RemoveBookFromJsonAsync(int bookID)
        {
            try
            {
                List<Book> books = await LoadBooksFromJsonAsync();
                books.RemoveAll(b => b.ID == bookID);
                SaveBooksToJsonAsync(books);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка видалення даних в JSON: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task<List<Book>> LoadBooksFromJsonAsync()
        {
            try
            {
                string json = await File.ReadAllTextAsync(filePath);
                return JsonConvert.DeserializeObject<List<Book>>(json) ?? new List<Book>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження даних з JSON: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Book>();
            }
        }

        public async void SaveBooksToJsonAsync(List<Book> books)
        {
            try
            {
                var json = JsonConvert.SerializeObject(books, Formatting.None);
                await File.WriteAllTextAsync(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка збереження даних в JSON: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
