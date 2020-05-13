using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TestSQL.Data.TestSQL.Data.Models;

namespace TestsSQL
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SoftUniContext db = new SoftUniContext();
            Students student = db.Students
                .Where(x => x.Id == 2)
                .Select(x => x)
                .Include(c => c.City)
                .Include(m => m.Minions)
                .Include(b => b.Banana)
                .FirstOrDefault();

            Console.WriteLine(student.Id);
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.MidleName);
            Console.WriteLine(student.CityId);
            Console.WriteLine(student.City.CurrentAddress);
            Console.WriteLine(student.Minions.Sname);
            Console.WriteLine(student.Banana.NumberOfBananas);
            Console.WriteLine();

            Print1(db);
            Print2(db);
        }

        private static void Print2(SoftUniContext db)
        {
            Students student = db.Students
                .Where(x => x.Id == 1)
                .Select(x => x)
                .Include(c => c.City)
                .Include(m => m.Minions)
                .Include(b => b.Banana)
                .FirstOrDefault();

            Console.WriteLine(student.Id);
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.MidleName);
            Console.WriteLine(student.CityId);
            Console.WriteLine(student.City.CurrentAddress);
            Console.WriteLine(student.Minions.Sname);
            Console.WriteLine(student.Banana.NumberOfBananas);
            Console.WriteLine();
        }

        private static void Print1(SoftUniContext db)
        {
            Students student = db.Students
                .Where(x => x.Id == 3)
                .Select(x => x)
                .Include(c => c.City)
                .Include(m => m.Minions)
                .Include(b => b.Banana)
                .FirstOrDefault();

            Console.WriteLine(student.Id);
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.MidleName);
            Console.WriteLine(student.CityId);
            Console.WriteLine(student.City.CurrentAddress);
            Console.WriteLine(student.Minions.Sname);
            Console.WriteLine(student.Banana.NumberOfBananas);
            Console.WriteLine();
        }
    }
}