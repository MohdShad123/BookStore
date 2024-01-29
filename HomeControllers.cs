using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string? CustomProperty { get; set; }

        [ViewData]
        public string? Title { get; set; }

        [ViewData]
        public BookModel? Book { get; set; }

        public ViewResult Index()
        {
            Title = "Home page from Controller";
            CustomProperty = "Custom value";

            Book = new BookModel() { Id = 1, Title = "Asp.Net" };
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
