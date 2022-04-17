using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class TheaterService
    {
        ProjectContext db = new ProjectContext();
        
        //CRUD

        //Create
         
        public string AddTheater(Theater theater)
        {
            try
            {
                db.Theaters.Add(theater);
                db.SaveChanges();
                return "Ekleme başarıyla tamamlandı";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        //List

        public List<Theater>  TheaterListele()
        {
            return db.Theaters.ToList();
        }

        //Update 

        public string UpdateTheater(Theater theater)
        {
            Theater updated = db.Theaters.FirstOrDefault(x=> x.TheaterID == theater.TheaterID);
            updated.MovieID = theater.MovieID;
            updated.SaloonID = theater.SaloonID;
            updated.SessionID= theater.SessionID;
            updated.WeekID = theater.WeekID;
            db.SaveChanges();
            return "guncelleme basarılı";
        }

        //Delete

        public string DeleteTheater(int id)
        {
            try
            {
                Theater deleted = db.Theaters.Find(id);
                db.Theaters.Remove(deleted);
                db.SaveChanges();
                return "Silme işlemi tamamlandı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        





    }
}
