using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewData["property1"] = "Mohd Usmani";

            ViewData["book"] = new BookModel() { Author = "Nagarro", Id = 1 };
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
