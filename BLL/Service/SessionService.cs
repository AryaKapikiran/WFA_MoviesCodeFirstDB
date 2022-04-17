using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class SessionService
    {
        ProjectContext db = new ProjectContext();

        //CRUD

        //Create 
        public string AddSession(Session session)
        {
            try
            {
                db.Sessions.Add(session);
                db.SaveChanges();
                return "Seans basarıyla eklendi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        //Listele

        public List<Session> SessionList()
        {
            return db.Sessions.ToList();
        }

        //Guncelleme

        public string UpdateSession(Session session)
        {
            Session updated = db.Sessions.FirstOrDefault(s => s.SessionID == session.SessionID);
            updated.SessionTime = session.SessionTime;
            updated.Duration = session.Duration;
            db.SaveChanges();
            return "Guncelleme tamamlandı";
        }

        //Silme

        public string DeleteSession(int id)
        {
            try
            {
                Session deleted = db.Sessions.Find(id);
                db.Sessions.Remove(deleted);
                db.SaveChanges();
                return "Seans Silindi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
