using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            var mcm = new MovieCategoryModel();

            mcm.Movies = MovieRepository.Movies;
            mcm.Categories = CategoryRepository.Categories;

            return View(mcm);
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