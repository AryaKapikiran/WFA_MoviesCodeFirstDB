using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class MovieService
    {
        ProjectContext db = new ProjectContext();
        //CRUD

        //Create
        public string AddMovie(Movie movie)
        {
            try
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return $"{movie.MovieName} +  adlı film eklendi.";


            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        //List 

        public List<Movie> MovieList()
        {
            return db.Movies.ToList();
        }

        //Update

        public string UpdateMovie(Movie movie)
        {
            Movie updated = db.Movies.FirstOrDefault(x => x.MovieID == movie.MovieID);
            updated.MovieName = movie.MovieName;
            db.SaveChanges();
            return "Guncelleme Tamamlandı";
        }

        //Delete

        public string DeleteMovie(int id)
        {
            try
            {
              Movie deleted = db.Movies.Find(id);
               db.Movies.Remove(deleted);
               db.SaveChanges();
               return "Film kaldırıldı";
            }

            catch(Exception ex)
            {
                return ex.Message;
            }
           
        }
    }
}
