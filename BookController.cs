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
        public List<BookModel> GetAllBooks()
		{
			//return "All books";
			return bookRepository.GetAllBooks();
		}

		public BookModel GetBook(int id)
		{
			//return $"book with id = {id}";
			return bookRepository.GetBookById(id);
		}


		//http://localhost:43862/book/searchbooks?bookName=MVCBooks&authorName=Nagarro
		public List<BookModel> SearchBooks(string bookName, string authorName)
		{
			//return $"Book with name = {bookName} & Author = {authorName}";
			return bookRepository.SearchBook(bookName, authorName);
		}
	}
}
