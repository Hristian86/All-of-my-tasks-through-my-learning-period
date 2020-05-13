using System;
using System.Collections.Generic;

namespace TestSQL.Data.TestSQL.Data.Models
{
    public partial class Bananas
    {
        public Bananas()
        {
            Students = new HashSet<Students>();
        }

        public int Id { get; set; }
        public int? NumberOfBananas { get; set; }

        public virtual ICollection<Students> Students { get; set; }
    }
}
