using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSalesSystem2._0.BookFolder
{
    public class BookManager
    {
        private readonly BookService _bookService;

        public BookManager()
        {
            _bookService = new BookService();
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            return await _bookService.GetBooksAsync() ?? new List<Book>();
        }

        public async Task<bool> DeleteBookAsync(int bookId)
        {
            return await _bookService.RemoveBookAsync(bookId);
        }

        public async Task<bool> UpdateBookAsync(Book updatedBook)
        {
            return await _bookService.UpdateBookAsync(updatedBook);
        }
    }
}
