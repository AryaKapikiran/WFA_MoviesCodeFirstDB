using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class SaloonService
    {
       ProjectContext db = new ProjectContext();

        //Create 

        public string AddSaloon(Saloon saloon)
        {
            try
            {
                db.Saloons.Add(saloon);
                db.SaveChanges();
                return $"{saloon.SaloonName} +  adlı salon eklendi.";


            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }


        //Listeleme

        public List<Saloon> SaloonList()
        {
            return db.Saloons.ToList();
        }

        //Update

        public string UpdateSaloon(Saloon saloon)
        {
            Saloon updated = db.Saloons.FirstOrDefault(s => s.SaloonID == saloon.SaloonID);
            updated.SaloonName = saloon.SaloonName;
            updated.Capacity = saloon.Capacity;
            db.SaveChanges();
            return "Guncelleme tamamlandı";

        }

        //Delete

        public string DeleteSaloon(int id)
        {
            try
            {
              Saloon deleted = db.Saloons.Find(id);
              db.Saloons.Remove(deleted);
               db.SaveChanges();
               return "Salon silindi";

            }

            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }
    }
}
