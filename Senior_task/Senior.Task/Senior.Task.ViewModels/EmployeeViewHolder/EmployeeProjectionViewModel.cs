using System;
using System.Collections.Generic;
using System.Text;

namespace Senior.Task.ViewModels.EmployeeViewHolder
{
    public class EmployeeProjectionViewModel
    {
        public IEnumerable<EmployeeViewModel> Employees { get; set; }

        public string SearchWord { get; set; }

        public int PagesCount { get; set; }

        public int ItemsCount { get; set; }

        public int CurrentPage { get; set; }
    }
}
