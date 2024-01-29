using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository bookRepository = null;

        public BookController()
        {
            bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            //return "All books";
           var data =  bookRepository.GetAllBooks();
           return View(data);
        }

        [Route("book-details/{id}")]
        public ViewResult GetBook(int id)
        {
            //return $"book with id = {id}";

            var data =  bookRepository.GetBookById(id);
            return View(data);
        }


        //http://localhost:43862/book/searchbooks?bookName=MVCBooks&authorName=Nagarro
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            //return $"Book with name = {bookName} & Author = {authorName}";
            return bookRepository.SearchBook(bookName, authorName);
        }
    }
}
