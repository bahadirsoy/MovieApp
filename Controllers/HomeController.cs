using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index(int? id)
        {
            var movies = MovieRepository.Movies;
            
            if(id != null){
                movies = movies.Where(i => i.CategoryId == id).ToList();
            }

            return View(movies);
        }
        public IActionResult Details(int Id){
            return View(MovieRepository.GetById(Id));
        }
        public IActionResult Contact()
        {
          return View();
        }
    }
}