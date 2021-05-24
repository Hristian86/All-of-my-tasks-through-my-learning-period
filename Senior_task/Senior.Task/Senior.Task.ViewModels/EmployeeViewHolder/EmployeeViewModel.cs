using System;
using System.Collections.Generic;
using System.Text;
using Senior.Task.Common.Models;
using Senior.Task.Domains.Entities;
using Senior.Task.Mappings;

namespace Senior.Task.ViewModels.EmployeeViewHolder
{
    public class EmployeeViewModel : BaseDeletableModel<int>, IMapFrom<Employee>
    {
        public string Name { get; set; }

        public string Company { get; set; }

        public string Project { get; set; }

        public string Role { get; set; }
    }
}
