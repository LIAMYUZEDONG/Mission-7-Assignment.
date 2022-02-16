using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BookProject.Models;
using BookProject.Models.ViewModels;

namespace BookProject.Controllers
{
    public class HomeController : Controller
    {


        private IBookRepository repo;
      

        public HomeController (IBookRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(int pageNum = 1) // do not use "page" as variable name
        {
            int NumBooks = 10;

            var x = new ProjectsViewModel
            {
                Books = repo.Books
                .OrderBy(p => p.Title)
                .Skip((pageNum - 1) * NumBooks)
                .Take(NumBooks),

                PageInfo = new PageInfo
            {
                TotalNumProjects = repo.Books.Count(),
                ProjectsPerPage = NumBooks,
                CurrentPage = pageNum
            }

            };

     

              return View(x);
      
        }
    }
}
