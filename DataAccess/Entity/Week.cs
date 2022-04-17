using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Week
    {
        public int WeekID { get; set; }

        public int WeekofTheYear { get; set; }

        public DateTime FirstDay { get; set; }

        public DateTime LastDay { get; set; }

    }
}
