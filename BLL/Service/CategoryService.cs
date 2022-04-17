using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class CategoryService
    {
        ProjectContext db = new ProjectContext();
        //CRUD

        //Ekleme
        public string AddCategory(Category category)
        {
            try
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return $"{category.CategoryName}  adlı kategori eklendi.";


            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        //Listeleme

        public List<Category> CategoryList()
        {
            return db.Categories.ToList();
        }

        //Guncelleme

        public string UpdateCategory(Category category)
        {
            //db.Entry(category).State = System.Data.Entity.EntityState.Modified;
            Category updated = db.Categories.FirstOrDefault(x => x.CategoryID == category.CategoryID);
            updated.CategoryName = category.CategoryName;

            db.SaveChanges();
            return "Guncelleme tamamlandı";
        }

        //Silme
        public string DeleteCategory(int id)
        {
            try
            {
                Category deleted = db.Categories.Find(id);
                db.Categories.Remove(deleted);
                db.SaveChanges();
                return "Kategori silindi";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

    }
}
