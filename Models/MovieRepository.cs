using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Models
{
    public class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository(){
            _movies = new List<Movie>()
            {
                new Movie() {
                    Id =1, 
                    Name="Shazam", 
                    Description="Shazam", 
                    LongDescription="<p>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nam iaculis</p>" ,
                    ImageUrl="1.jpg"},
                new Movie() {
                    Id =2, 
                    Name="Amazing Grace", 
                    Description="Amazing Grace", 
                    LongDescription="<p>Aenean consectetur facilisis efficitur. Integer molestie rutrum bibendum. Nam eget risus at justo imperdiet vestibulum</p>",
                    ImageUrl="2.jpg"},
                new Movie() {
                    Id =3, 
                    Name="High Life", 
                    Description="High Life", 
                    LongDescription="<p>Quisque eget massa mi. Sed lobortis purus ut nisl ultrices, nec porttitor mi dapibus. Integer</p>",
                    ImageUrl="3.jpg"},
                new Movie() {
                    Id =4, 
                    Name="Billboard", 
                    Description="Billboard",
                    LongDescription="<p>Vivamus a mauris pretium, lacinia mauris id, pulvinar mauris. Morbi eget odio eget urna eleifend</p>",
                    ImageUrl="4.jpg"},
                new Movie() {
                    Id =5, 
                    Name="Storm Boy", 
                    Description="Storm Boy",
                    LongDescription="<p>Sed mauris magna, varius quis neque at, suscipit mattis odio. Nullam ipsum felis, condimentum ut</p>",
                    ImageUrl="5.jpg"},
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie movie)
        {
            _movies.Add(movie);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}