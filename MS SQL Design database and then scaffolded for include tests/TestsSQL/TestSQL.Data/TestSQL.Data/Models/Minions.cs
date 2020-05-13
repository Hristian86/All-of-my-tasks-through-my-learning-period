using System;
using System.Collections.Generic;

namespace TestSQL.Data.TestSQL.Data.Models
{
    public partial class Minions
    {
        public Minions()
        {
            Students = new HashSet<Students>();
        }

        public int Id { get; set; }
        public string Sname { get; set; }
        public int? Age { get; set; }

        public virtual ICollection<Students> Students { get; set; }
    }
}
