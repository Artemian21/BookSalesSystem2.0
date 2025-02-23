using Microsoft.EntityFrameworkCore;

namespace BookSalesSystem2._0.BookFolder
{
    public class BookService
    {
        private JsonOperationBook jsonOperation = new JsonOperationBook();
        public async Task<bool> AddBookAsync(Book book)
        {
            jsonOperation.AddBookToJson(book);

            if (DatabaseAvailable.IsDatabaseAvailable())
            {
                using (var context = new BookSalesSystemContext())
                {
                    if (await context.Books.AnyAsync(b => b.ISBN == book.ISBN))
                    {
                        MessageBox.Show("Книга з таким ISBN вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    context.Books.Add(book);
                    await context.SaveChangesAsync();
                }
            }

            return true;
        }

        public async Task<bool> RemoveBookAsync(int bookID)
        {
            jsonOperation.RemoveBookFromJsonAsync(bookID);

            if (DatabaseAvailable.IsDatabaseAvailable())
            {
                using (var context = new BookSalesSystemContext())
                {
                    var book = await context.Books.FindAsync(bookID);
                    if (book == null)
                    {
                        MessageBox.Show("Книги з таким ID не існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    context.Books.Remove(book);
                    await context.SaveChangesAsync();
                }
            }

            return true;
        }

        public async Task<bool> UpdateBookAsync(Book book)
        {
            jsonOperation.UpdateBookInJson(book);

            if (DatabaseAvailable.IsDatabaseAvailable())
            {
                using (var context = new BookSalesSystemContext())
                {
                    var editingBook = await context.Books.FindAsync(book.ID);
                    if (editingBook == null)
                    {
                        MessageBox.Show("Книги з таким ID не існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    editingBook.Title = book.Title;
                    editingBook.Author = book.Author;
                    editingBook.Genre = book.Genre;
                    editingBook.ISBN = book.ISBN;
                    editingBook.Price = book.Price;
                    editingBook.Stock = book.Stock;

                    await context.SaveChangesAsync();
                }
            }

            return true;
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            if (DatabaseAvailable.IsDatabaseAvailable())
            {
                using (var context = new BookSalesSystemContext())
                {
                    try
                    {
                        var books = await context.Books.ToListAsync();
                        jsonOperation.SaveBooksToJsonAsync(books);
                        return books;
                    }
                    catch (Exception)
                    {
                        return await jsonOperation.LoadBooksFromJsonAsync();
                    }
                }
            }
            return await jsonOperation.LoadBooksFromJsonAsync();
        }

        public async Task SyncJsonToDatabase()
        {
            if (DatabaseAvailable.IsDatabaseAvailable())
            {
                var jsonBooks = await jsonOperation.LoadBooksFromJsonAsync();
                using (var context = new BookSalesSystemContext())
                {
                    foreach (var book in jsonBooks)
                    {
                        var existingBook = await context.Books.FindAsync(book.ID);
                        if (existingBook == null)
                        {
                            context.Books.Add(book);
                        }
                        else
                        {
                            existingBook.Title = book.Title;
                            existingBook.Author = book.Author;
                            existingBook.Genre = book.Genre;
                            existingBook.ISBN = book.ISBN;
                            existingBook.Price = book.Price;
                            existingBook.Stock = book.Stock;
                        }
                    }
                    await context.SaveChangesAsync();
                    jsonOperation.SaveBooksToJsonAsync(await context.Books.ToListAsync());
                }
            }
        }
    }
}
