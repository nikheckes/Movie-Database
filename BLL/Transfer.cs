using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DataAccess;

namespace BLL
{
    public class Transfer
    {
        public Transfer()
        {}
        public void AddMovie(Movie movie)
        {
            MovieDao movieDao=new MovieDao();
            movieDao.AddMovie(MovieMapper.ConvertMovieToMovieDto(movie));
        }
        public void RemoveMovie(int selection)
        {
            MovieDao movieDao=new MovieDao();
            movieDao.RemoveMovie(selection);
        }
        public List<Movie>SelectMovies()
        {
            MovieDao movieDao=new MovieDao();
            return Utilities.ConvertListMovieDtoToListMovie(movieDao.SelectMovies());
        }
        public void UpdateMovie(Movie movie)
        {
            MovieDao movieDao = new MovieDao();
            movieDao.UpdateMovie(MovieMapper.ConvertMovieToMovieDto(movie));
        }
        public Movie SelectSingleMovie(string movieName)
        {
            MovieDao movieDao = new MovieDao();
            return MovieMapper.ConvertMovieDtoToMovie(movieDao.SelectSingleMovie(movieName));
        }
    }

}
