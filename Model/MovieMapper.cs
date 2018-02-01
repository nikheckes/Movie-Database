using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class MovieMapper
    {
        public MovieMapper()
        { }
        static public Movie ConvertMovieDtoToMovie(MovieDto movieDto)
        {
            return new Movie(movieDto.ID, movieDto.MovieName, movieDto.MovieDirector);
        }
        static public MovieDto ConvertMovieToMovieDto(Movie movie)
        {
            return new MovieDto(movie.ID, movie.MovieName, movie.MovieDirector);
        }
    }
}
