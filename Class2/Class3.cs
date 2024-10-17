using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    //class A
    //{
    //    public string Name {  get; set; }

    //    public void Main() => Console.WriteLine("Method a");
    //}

    //class B : A
    //{
    //    public string Name { get; set; }

    //    new public void MainB() => Console.WriteLine("Method b");
    //}
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }

    public class SchoolStudent : Student
    {
        public string SchoolName { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, School: {SchoolName}");
        }
    }

    public class CollegeStudent : Student
    {
        public string CollegeName { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, collegr: {CollegeName}");
        }
    }

    public static void Main(string[] args)
    {
        SchoolStudent schoolStudent = new SchoolStudent
        {
            Name = "Alice",
            Age = 15,
            SchoolName = "Lincoln High School"
        };

        CollegeStudent collegeStudent = new CollegeStudent
        {
            Name = "Bob",
            Age = 20,
            CollegeName = "State University"
        };

        schoolStudent.DisplayInfo();
        collegeStudent.DisplayInfo();
    }
}
