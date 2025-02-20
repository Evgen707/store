using System;
using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers
{
    public class SearchController1 : Controller
    {
        private readonly IBookRepository bookRepository;

        public SearchController1(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public IActionResult Index(string query)
        {
            return View();
        }
    }
}
