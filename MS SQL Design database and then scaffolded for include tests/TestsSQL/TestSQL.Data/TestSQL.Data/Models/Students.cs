using System;
using System.Collections.Generic;

namespace TestSQL.Data.TestSQL.Data.Models
{
    public partial class Students
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MidleName { get; set; }
        public int? CityId { get; set; }
        public string LastNames { get; set; }
        public int? Minionsid { get; set; }
        public int? BananaId { get; set; }

        public virtual Bananas Banana { get; set; }
        public virtual City City { get; set; }
        public virtual Minions Minions { get; set; }
    }
}
