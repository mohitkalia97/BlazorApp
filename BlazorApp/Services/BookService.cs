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

        public void addBook(Book book)
        {
            _bookDbContext.Books.Add(book); 
        }

        public List<Book> getAllBooks()
        {
            return _bookDbContext.Books.ToList();
        }
 

    }
}
