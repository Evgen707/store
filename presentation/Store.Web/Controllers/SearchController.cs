using System;
using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly IBookRepository BookRepository;

        public SearchController(IBookRepository BookRepository)
        {
            this.BookRepository = BookRepository;
        }

        public IActionResult Index(string query)
        {
            var books = BookRepository.GetAllByTitle(query);

            return View(books);
        }
    }
}
