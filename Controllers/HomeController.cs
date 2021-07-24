using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
          return View(Repository.Movies);
        }
        public IActionResult Details(int Id){
          return View(Repository.GetById(Id));
        }
        public IActionResult Contact()
        {
          return View();
        }
    }
}