using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = "Nagarro";

            dynamic data = new ExpandoObject();
            data.Id = 1;
            data.Name = "Nagarro";
            ViewBag.Data = data;

            // ViewBag.Data = new { Id = 123, Name = "Nagarro" };

            ViewBag.Type = new BookModel() { Id = 5, Author = "This is author" };
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
