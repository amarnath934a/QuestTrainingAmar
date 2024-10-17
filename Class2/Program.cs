using System;
using System.Collections.Generic;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentManager = new StudentManager();

            while (true)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Update Student");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Search Student");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var newStudent = GetStudentData();
                        studentManager.Add(newStudent);
                        break;
                    case "2":
                        Console.Write("Enter the registration number to update: ");
                        var regNumberToUpdate = Console.ReadLine();
                        var updatedStudent = GetStudentData();
                        studentManager.Update(regNumberToUpdate, updatedStudent);
                        break;
                    case "3":
                        Console.Write("Enter the registration number to delete: ");
                        var regNumberToDelete = Console.ReadLine();
                        studentManager.Delete(regNumberToDelete);
                        break;
                    case "4":
                        Console.Write("Enter the registration number to search: ");
                        var regNumberToSearch = Console.ReadLine();
                        studentManager.Search(regNumberToSearch);
                        break;
                }
            }
        }

        private static Student GetStudentData()
        {
            Student student = new Student();

            Console.Write("Enter the student name: ");
            student.StudentName = Console.ReadLine();

            Console.Write("Enter the registration number: ");
            student.RegistrationNumber = Console.ReadLine();

            Console.Write("Enter the standard: ");
            student.standard = Console.ReadLine();

            Console.Write("Enter the number of subjects: ");
            int subjectCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < subjectCount; i++)
            {
                student.subjectMarks.Add(GetSubjectMark());
            }

            return student;
        }

        private static SubjectMarks GetSubjectMark()
        {
            SubjectMarks subject = new SubjectMarks();

            Console.Write("Enter the subject name: ");
            subject.SubjectName = Console.ReadLine();

            Console.Write("Enter the marks obtained: ");
            subject.MarksObtained = int.Parse(Console.ReadLine());

            Console.Write("Enter the maximum marks: ");
            subject.MaxMarks = int.Parse(Console.ReadLine());

            return subject;
        }
    }
}
