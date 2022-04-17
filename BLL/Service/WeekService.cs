using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class WeekService
    {
        ProjectContext db = new ProjectContext();

        //Crud

        //Add

        public string AddWeek(Week week)
        {
            try
            {
                db.Weeks.Add(week);
                db.SaveChanges();
                return "Belirttiginiz hafta eklendi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        //List 

        public List<Week> WeekList()
        {
            return db.Weeks.ToList();
        }

        //Guncelleme

        public string UpdateWeek(Week week)
        {
            Week updated = db.Weeks.FirstOrDefault(x => x.WeekID == week.WeekID);
            updated.WeekofTheYear = week.WeekofTheYear;
            updated.FirstDay = week.FirstDay;
            updated.LastDay = week.LastDay;
            db.SaveChanges();
            return "Guncelleme Başarılı";
        }

        //Silme 

        public string DeleteWeek(int id)
        {
            try
            {
                Week deleted = db.Weeks.Find(id);
                 db.Weeks.Remove(deleted);
                db.SaveChanges();
                return "Silme işlemi başarılı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
