using System;
using Balta.ContentContext;

namespace Balta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var course = new Course();
            course.Level = ContentContext.Enums.EContentLevel.Beginner;

            var career = new Career();
            career.Items.Add(new CareerItem());
            Console.WriteLine(career.TotalCourses);

        }
    }
}


//VER AULA ... METODO CONSTRUTOR!!!