using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;

namespace DataAccess
{
    public class MovieDao
    {
        public MovieDao()
        { }
        protected const string DbConnectionString = @"Server=.\SQLEXPRESS;" +
            "Database=MovieDatabase;Integrated Security=SSPI;";
        protected SqlConnection DataBaseConnection = new SqlConnection(DbConnectionString);

        public void AddMovie(MovieDto MovieDto)
        {
            try
            {
                DataBaseConnection.Open();
                using (SqlCommand cmd = new SqlCommand("Addmovie", DataBaseConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MovieName", MovieDto.MovieName));
                    cmd.Parameters.Add(new SqlParameter("@MovieDirector", MovieDto.MovieDirector));
                    cmd.ExecuteNonQuery();
                }
            }
            catch { throw; }
        }
        public List<MovieDto> SelectMovies()
        {
            List<MovieDto> movies = new List<MovieDto>();
            try
            {
                DataBaseConnection.Open();
                using (SqlCommand cmd = new SqlCommand("SelectMovies", DataBaseConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                movies.Add(new MovieDto()
                                {
                                    ID = reader.GetInt32(0),
                                    MovieName = reader.GetString(1),
                                    MovieDirector = reader.GetString(2)
                                });
                            }
                        }
                    }
                }
            }
            catch { throw; }
            return movies;
        }
        public void RemoveMovie(int selection)
        {
            try
            {
                DataBaseConnection.Open();
                using (SqlCommand cmd = new SqlCommand("RemoveMovie", DataBaseConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", selection));
                    cmd.ExecuteNonQuery();
                }
            }
            catch { throw; }
        }
        public void UpdateMovie(MovieDto MovieDto)
        {
            try
            {
                DataBaseConnection.Open();
                using (SqlCommand cmd = new SqlCommand("UpdateMovie", DataBaseConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", MovieDto.ID));
                    cmd.Parameters.Add(new SqlParameter("@MovieName", MovieDto.MovieName));
                    cmd.Parameters.Add(new SqlParameter("@MovieDirector", MovieDto.MovieDirector));
                    cmd.ExecuteNonQuery();
                }
            }
            catch { throw; }
        }
        public MovieDto SelectSingleMovie(string movieName)
        {
            MovieDto movieDto = null;

            try
            {
                DataBaseConnection.Open();
                using (SqlCommand cmd = new SqlCommand("SelectSingleMovie", DataBaseConnection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MovieName", movieName));
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                movieDto = new MovieDto()
                                {
                                    ID = reader.GetInt32(0),
                                    MovieName = reader.GetString(1),
                                    MovieDirector = reader.GetString(2)
                                };
                            }
                        }
                    }
                }
            }
            catch { throw; }
            return movieDto;
        }
    }
}