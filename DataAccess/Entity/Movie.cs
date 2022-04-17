using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Movie
    {
        public int MovieID { get; set; }

        public string MovieName { get; set; }

        //bir filmin birden fazla kategorisi olabilir

        public  List<Category> Categories { get; set; }
    }
}
