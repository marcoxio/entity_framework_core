using System;
using Microsoft.EntityFrameworkCore;
using ReadData.Data;

namespace ReadData
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppSellCourseContext()){
                var courses = db.Course.AsNoTracking(); //array IQueryble
                foreach (var course in courses)
                {
                    Console.WriteLine(course.Title + " ----- " + course.Description);
                }
            }
        }
    }
}
