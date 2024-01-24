using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;

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
			return View();
		}

		public ViewResult GetBook(int id)
		{
			//return $"book with id = {id}";
			var data =  bookRepository.GetBookById(id);
			return View();
		}


		//http://localhost:43862/book/searchbooks?bookName=MVCBooks&authorName=Nagarro
		public ViewResult SearchBooks(string bookName, string authorName)
		{
            var data = bookRepository.SearchBook(bookName, authorName);
            return View();
         }
	}
}
