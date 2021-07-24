using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            var model = new MovieCategoryModel();

            model.Movies = MovieRepository.Movies;
            model.Categories = CategoryRepository.Categories;

            return View(model);
        }
        public IActionResult Details(int Id){
            MovieCategoryModel model = new MovieCategoryModel();
            model.Categories = CategoryRepository.Categories;
            model.Movie = MovieRepository.GetById(Id);

            return View(model);
        }
        public IActionResult Contact()
        {
          return View();
        }
    }
}