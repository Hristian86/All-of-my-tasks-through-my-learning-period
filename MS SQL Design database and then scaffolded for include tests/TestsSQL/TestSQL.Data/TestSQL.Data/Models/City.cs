using System;
using System.Collections.Generic;

namespace TestSQL.Data.TestSQL.Data.Models
{
    public partial class City
    {
        public City()
        {
            Students = new HashSet<Students>();
        }

        public int Id { get; set; }
        public string CurrentAddress { get; set; }

        public virtual ICollection<Students> Students { get; set; }
    }
}
