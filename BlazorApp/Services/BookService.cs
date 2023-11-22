﻿using BlazorApp.DB;
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

        public Task addBook(Book book)
        {
            _bookDbContext.Books.Add(book); 
            _bookDbContext.SaveChanges();

            return Task.CompletedTask;

        }

        public List<Book> getAllBooks()
        {
            return _bookDbContext.Books.ToList();
        }
 

    }
}
