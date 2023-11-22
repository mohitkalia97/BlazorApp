using BlazorApp.Models;
namespace BlazorApp.Services.Interfaces
{
    public interface IBookService
    {
        public List<Book> getAllBooks();
        public void addBook(Book book);
    }
}
