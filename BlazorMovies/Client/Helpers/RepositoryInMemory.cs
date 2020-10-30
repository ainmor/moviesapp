using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie()
                {
                    Title = "Spider-Man: Far from Home",
                    ReleaseDate = new DateTime(2020, 07, 02),
                    Poster = "https://images-na.ssl-images-amazon.com/images/I/91A+eXyGmvL._RI_.jpg"
                },
                new Movie()
                {
                    Title = "Inception",
                    ReleaseDate = new DateTime(2019, 10, 13),
                    Poster = "https://images-na.ssl-images-amazon.com/images/I/719sOEQ-joL._SL1200_.jpg"
                },
                new Movie()
                {
                    Title = "Rockstar",
                    ReleaseDate = new DateTime(2010, 11, 28),
                    Poster = "https://images-na.ssl-images-amazon.com/images/I/818KQeyaHxL._AC_SX342_.jpg"
                }
            };
        }        
    }   
}
