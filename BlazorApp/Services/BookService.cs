using BlazorApp.DB;
using BlazorApp.Models;
using BlazorApp.Services.Interfaces;

namespace BlazorApp.Services
{
    public class BookService : IBookService
    {
        private readonly BookDbContext _bookDbContext;

        public BookService(BookDbContext bookDbContext)
        {
            _bookDbContext = bookDbContext;   
        }

        public async Task<Book> addBook(Book book)
        {
            _bookDbContext.Books.Add(book); 
            _bookDbContext.SaveChanges();

            Book dbBook = await getBookById(book.Id.ToString());
            return dbBook;
        }

        public List<Book> getAllBooks()
        {
            return _bookDbContext.Books.ToList();
        }

        public async Task<Book> getBookById(string id)
        {
            Book book = _bookDbContext.Books.FirstOrDefault(b => b.Id.ToString() == id);
            return book;
        }

        public Task deleteBook(Book book)
        {
            _bookDbContext.Remove(book);
            _bookDbContext.SaveChanges();

            return Task.CompletedTask;
        }

        public async Task<Book> updateBook(Book book)
        {
            _bookDbContext.Update(book);
            _bookDbContext.SaveChanges();

            Book dbBook = await getBookById(book.Id.ToString());
            return dbBook;
        }
    }
}
