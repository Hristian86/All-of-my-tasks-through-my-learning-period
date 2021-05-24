using System.Collections.Generic;
using System.Threading.Tasks;
using Senior.Task.Domains.Entities;
using Senior.Task.ViewModels.EmployeeViewHolder;

namespace Senior.Task.Services.EmployeeServiceHOlder
{
    public interface IEmployeeService
    {
        public Task<int> CreateAsync(EmployeeViewModel model);

        public T GetById<T>(int id);

        public Task<bool> Edit(EmployeeViewModel model, int id);

        public bool EmployeeExists(int employeeID);

        public Employee CheckForDelete(int id);

        public Task<bool> Delete(int id);

        public int GetCount();

        public IEnumerable<T> GetAll<T>(string searchWord, int? take = null, int skip = 0);

        public EmployeeProjectionViewModel GetAllWithPagination(string searchWord, int page);
    }
}