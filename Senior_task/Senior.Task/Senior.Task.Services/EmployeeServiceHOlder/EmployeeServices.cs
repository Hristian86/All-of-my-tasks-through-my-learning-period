using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Senior.Task.Domains.Entities;
using Senior.Task.Repository;
using Senior.Task.Mappings;
using System.Threading.Tasks;
using Senior.Task.ViewModels.EmployeeViewHolder;

namespace Senior.Task.Services.EmployeeServiceHOlder
{
    public class EmployeeServices : EmployeeLogic, IEmployeeService
    {
        private readonly IDeletableEntityRepository<Employee> employeeRepository;
        private readonly int ItemsPerPage = 5;

        public EmployeeServices(
            IDeletableEntityRepository<Employee> employeeRepository
            )
        {
            this.employeeRepository = employeeRepository;
        }

        public async Task<int> CreateAsync(EmployeeViewModel model)
        {
            Employee employee = new Employee()
            {
                Name = model.Name,
                Company = model.Company,
                Project = model.Project,
                Role = model.Role,
            };

            await this.employeeRepository.AddAsync(employee);
            await this.employeeRepository.SaveChangesAsync();
            return employee.Id;
        }

        public T GetById<T>(int id)
        {
            var post = this.employeeRepository.All().Where(x => x.Id == id);
            if (post == null)
            {
                throw new ArgumentNullException("The employee is not found");
            }

            return post.To<T>().FirstOrDefault();
        }

        public EmployeeProjectionViewModel GetAllWithPagination(string searchWord, int page)
        {
            if (page < 1)
            {
                page = 1;
            }

            var viewModel = new EmployeeProjectionViewModel();
            //viewModel.Employees = this.GetAll<EmployeeViewModel>(searchWord);

            var count = this.GetAll<EmployeeViewModel>(searchWord).Count();

            // Preventing exceptions for pagination
            if (this.GetCount() < this.ItemsPerPage)
            {
                // To Do.
                viewModel.Employees = this.GetAll<EmployeeViewModel>(searchWord);
                viewModel.PagesCount = this.GetCount();

                return viewModel;
            }

            var pageCount = (int)Math.Ceiling((double)count / ItemsPerPage);
            if (page > pageCount)
            {
                page = pageCount;
            }

            viewModel.PagesCount = pageCount;

            viewModel.Employees = this.GetAll<EmployeeViewModel>(searchWord, ItemsPerPage, (int)((page - 1) * ItemsPerPage));

            viewModel.CurrentPage = (int)page;

            return viewModel;
        }

        public IEnumerable<T> GetAll<T>(string searchWord, int? take = null, int skip = 0)
        {
            var query = this.employeeRepository.All();

            // Advance search options.
            if (searchWord != null && searchWord.Length > 1)
            {
                query = base.CheckSearchWord(query, searchWord);
            }

            query = query.OrderByDescending(x => x.CreatedOn)
            .Skip(skip);
            if (take.HasValue)
            {
                query = query.Take(take.Value);
            }

            return query.To<T>().ToList();
        }

        public bool EmployeeExists(int employeeID)
        {
            bool exists = this.employeeRepository.All()
                .Any(x => x.Id == employeeID);
            return exists;
        }

        public Employee CheckForDelete(int id)
        {
            var result = this.employeeRepository.All()
                .FirstOrDefault(x => x.Id == id);
            if (result == null)
            {
                throw new ArgumentNullException("Employee not found.");
            }

            return result;
        }

        public async Task<bool> Delete(int id)
        {
            var result = this.employeeRepository.All()
                .FirstOrDefault(x => x.Id == id);
            if (result == null)
            {
                throw new ArgumentNullException("Employee not found");
            }

            this.employeeRepository.Delete(result);
            await this.employeeRepository.SaveChangesAsync();
            return true;
        }

        public int GetCount()
        {
            var count = this.employeeRepository.All().Count();
            return count;
        }

        public async Task<bool> Edit(EmployeeViewModel model, int id)
        {
            var res = this.employeeRepository.All()
                .FirstOrDefault(x => x.Id == id);

            if (res == null)
            {
                throw new ArgumentNullException("Not found");
            }

            res.Name = model.Name;
            res.Company = model.Company;
            res.Project = model.Project;
            res.Role = model.Role;

            this.employeeRepository.Update(res);
            await this.employeeRepository.SaveChangesAsync();
            return true;
        }
    }
}