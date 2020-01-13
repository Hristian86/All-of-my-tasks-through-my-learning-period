using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> peoplesss = new List<Person>();

        public List<Person> FileterdByYear()
        {
            return this.peoplesss.Where(x => x.Age >= 30).ToList();
        }
        public void AddMembers(Person member)
        {
            this.peoplesss.Add(member);
        }
        public Person GetOldestMember()
        {
            return this.peoplesss.OrderByDescending(x => x.Age).FirstOrDefault();
        }

    }
}
