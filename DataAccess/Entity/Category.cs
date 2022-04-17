﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Category
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

       //bir kategorinin birden fazla filmi olabilir

        public List<Movie> Movies { get; set; }
    }
}