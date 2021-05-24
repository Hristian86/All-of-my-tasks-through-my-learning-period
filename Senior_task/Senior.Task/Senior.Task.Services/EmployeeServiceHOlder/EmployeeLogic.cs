using System;
using System.Linq;
using Senior.Task.Domains.Entities;

namespace Senior.Task.Services.EmployeeServiceHOlder
{
    public class EmployeeLogic
    {
        private readonly string AND = "and";
        private readonly string OR = "or";
        private readonly string NOT = "not";

        protected IQueryable<Employee> CheckSearchWord(IQueryable<Employee> query, string searchWord)
        {
            if (searchWord != null && searchWord.Length > 1)
            {
                var searchRes = searchWord.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (searchRes.Length > 1)
                {
                    query = this.SearchOptions(query, searchRes);

                    return query;
                }
                else
                {
                    query = this.AdjustQuery(query, searchWord);

                    return query;
                }
            }

            return query;
        }

        private IQueryable<Employee> SearchOptions(IQueryable<Employee> query, string[] searchRes)
        {
            for (int i = 0; i < searchRes.Length; i++)
            {
                if ((searchRes[i].ToLower() == this.AND
                    && i > 0
                    && i < searchRes.Length)
                    ||
                    (searchRes[i].ToLower() == this.OR
                    && i > 0
                    && i < searchRes.Length))
                {
                    query = this.AdjustQueryAndOr(query, searchRes[i - 1], searchRes[i + 1]);
                    //query = this.AdjustQuery(query, searchRes[i + 1]);
                }
                else if (searchRes[i].ToLower() == this.NOT)
                {
                    query = this.AdjustQuery(query, searchRes[i - 1]);
                    query = this.FilterQuery(query, searchRes[i + 1]);
                }
            }

            return query;
        }

        private IQueryable<Employee> AdjustQueryAndOr(IQueryable<Employee> query, string searchWord, string secondWord)
        {
            query = query.Where(x =>
                x.Name
                .ToLower()
                .Contains(searchWord.ToLower())
                || x.Company
                .ToLower()
                .Contains(searchWord.ToLower())
                || x.Project
                .ToLower()
                .Contains(searchWord.ToLower())
                || x.Role
                .ToLower()
                .Contains(searchWord.ToLower())
                ||
                x.Name
                .ToLower()
                .Contains(secondWord.ToLower())
                || x.Company
                .ToLower()
                .Contains(secondWord.ToLower())
                || x.Project
                .ToLower()
                .Contains(secondWord.ToLower())
                || x.Role
                .ToLower()
                .Contains(secondWord.ToLower())
                );

            return query;
        }

        private IQueryable<Employee> FilterQuery(IQueryable<Employee> query, string ignoreWord)
        {
            query = query.Where(x => !x.Name
                .ToLower()
                .Contains(ignoreWord.ToLower())
                && !x.Company
                .ToLower()
                .Contains(ignoreWord.ToLower())
                && !x.Project
                .ToLower()
                .Contains(ignoreWord.ToLower())
                && !x.Role
                .ToLower()
                .Contains(ignoreWord.ToLower()));

            return query;
        }

        private IQueryable<Employee> AdjustQuery(IQueryable<Employee> query, string searchWord)
        {
            query = query.Where(x => x.Name
                .ToLower()
                .Contains(searchWord.ToLower())
                || x.Company
                .ToLower()
                .Contains(searchWord.ToLower())
                || x.Project
                .ToLower()
                .Contains(searchWord.ToLower())
                || x.Role
                .ToLower()
                .Contains(searchWord.ToLower()));

            return query;
        }

    }
}