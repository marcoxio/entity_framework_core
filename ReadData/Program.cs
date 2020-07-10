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

                //Relation many to many
                var courses = db.Course.Include(c => c.InstructorLink).ThenInclude(ci => ci.Instructor);
                foreach (var course in courses)
                {
                    Console.WriteLine(course.Title);
                    foreach (var isLink in course.InstructorLink)
                    {
                        Console.WriteLine("***********" + isLink.Instructor.Name);
                    }
                }

                // // //Relation  one to many
                // var courses = db.Course.Include(c => c.ListComment).AsNoTracking();  
                // foreach (var course in courses)
                // {
                //     Console.WriteLine(course.Title);
                //     foreach (var comment in course.ListComment)
                //     {
                //         Console.WriteLine("*************" + comment.TextComment);
                //     }
                // }
              
                
                
                // //Relation Data Include(entity price) one to one
                // var courses = db.Course.Include(p => p.PromotionPrice).AsNoTracking();
                // foreach (var course in courses)
                // {
                //    Console.WriteLine(course.Title + " ----- " + course.PromotionPrice.CurrentPrice);  
                // }


                // var courses = db.Course.AsNoTracking(); //array IQueryble
                // foreach (var course in courses)
                // {
                //     Console.WriteLine(course.Title + " ----- " + course.Description);
                // }
            }
        }
    }
}
