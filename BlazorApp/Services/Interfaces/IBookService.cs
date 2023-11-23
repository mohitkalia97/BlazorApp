using BlazorApp.Models;
namespace BlazorApp.Services.Interfaces
{
    public interface IBookService
    {
        public List<Book> getAllBooks();
        public Task<Book> getBookById(string id);
        public Task<Book> addBook(Book book);
        public Task deleteBook(Book book);
        public Task<Book> updateBook(Book book);

    }
}
