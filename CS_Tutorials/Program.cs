using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Tutorials
{
    internal class Program
    {
        static void Main(string[] args)
        {




            #region Döngüler

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------------");

            #endregion



            #region Diziler

            string[] kurslar = new string[]
            {
                "java","phython","csharp","php"
            };


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            #endregion



            #region class

            Console.WriteLine("-----------");

            Course course1 = new Course();

            course1.CourseName = "C#";
            course1.InstructorName = " Engin";
            course1.ViewRate = 65;


            Course course2 = new Course();

            course2.CourseName = "SQL";
            course2.InstructorName = "Hüseyin";
            course2.ViewRate = 45;


            Course[] courses = new Course[]
            {
            course1 , course2

            };

            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName +": "+ course.InstructorName +": "+ course.ViewRate);
            }
            #endregion

            



            Console.Read();
        }
    }


    class Course
    {
        public string CourseName { get; set; }
        public string InstructorName { get; set; }
        public int ViewRate{ get; set; }
    }
}
