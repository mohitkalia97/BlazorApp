using BlazorApp.Models;
namespace BlazorApp.Services.Interfaces
{
    public interface IBookService
    {
        public List<Book> getAllBooks();
        public Task addBook(Book book);
    }
}
