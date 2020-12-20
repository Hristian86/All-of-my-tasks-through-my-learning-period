using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data;
using P01_StudentSystem.Data.Models;

namespace P01_StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentSystemContext())
            {
                context.Database.EnsureCreated();
                var result = context
                    .Students
                    .Where(x => x.StudentCourses != null)
                    .Select(c => c.StudentCourses)
                    .Select(w => w
                    .Select(f => f.Courses
                    .Where(i => i.Resources != null)));

                var results = result.Where(a => a != null)
                    .FirstOrDefault(x => x != null)
                    .FirstOrDefault();



                //foreach (var item in result)
                //{
                //    foreach (var it in item)
                //    {
                //        foreach (var t in it)
                //        {
                //            var content = t.Where(x => x.Content == "done").FirstOrDefault();
                //        }
                //    }
                //}


                //var id = result.Select(x => x.Select(i => i.StudentId));
                //var newRes = context.StudnetCourses.Where(x => x.StudentId.Equals(id));
                //var homework = context.Homeworks.Where(x => x.StudentId.Equals(id)).FirstOrDefault();

                Console.WriteLine((result == null ? "Null" : "Not NULL"));

                //var homework = result.Select(x => x.Select(h => h.Homeworks.Select(d => d.Content == "Done"))).ToList();

                
                //foreach (var item in result)
                //{
                //    foreach (var itm in item)
                //    {
                //        Console.WriteLine(itm.StudentCourses);
                //    }
                //    Console.WriteLine(item.StudentCourses);
                //}


            }
        }
    }
}
