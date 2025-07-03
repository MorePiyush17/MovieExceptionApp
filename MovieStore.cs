using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieException;

namespace MoviesAppWithList
{
    internal class MovieStore
    {
        public List<Movie> movies = new List<Movie>();
        public const int MaxMovies = 5;

        public MovieStore(List<Movie> movies)
        {
            this.movies = movies;
        }

        public void AddMovie(Movie movie)
        {
            if (movies.Count >= MaxMovies)
            {
                Console.WriteLine("Movie store is full.");
                return;
            }

            if (movies.Any(m => m.Id == movie.Id))
            {
                Console.WriteLine($"A movie with ID {movie.Id} already exists.");
                return;
            }

            movies.Add(movie);
            Console.WriteLine($"Movie '{movie.Name}' added successfully.");
        }

        public void DisplayMovies()
        {
            if (movies.Count == 0)
            {
                Console.WriteLine("No movies available.");
                return;
            }

            Console.WriteLine("Movies in the store:");
            foreach (var movie in movies.OrderBy(m => m.Name))
            {
                Console.WriteLine(movie);
            }
        }

        public Movie FindMovieById(int id)
        {
            Movie movie = movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                Console.WriteLine($"Movie with ID {id} not found.");
                return null;
            }
            return movie;
        }

        public Movie RemoveMovieById(int id)
        {
            Movie movie = movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                Console.WriteLine($"Movie with ID {id} not found.");
                return null;
            }

            movies.Remove(movie);
            Console.WriteLine($"Movie '{movie.Name}' removed successfully.");
            return movie;
        }

        public void ClearMovies()
        {
            movies.Clear();
            Console.WriteLine("All movies have been cleared from the store.");
        }

        public List<Movie> GetMovies()
        {
            return movies;
        }
    }

}