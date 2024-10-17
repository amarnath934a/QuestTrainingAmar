using System;
using System.Collections.Generic;

namespace StudentApp
{
    public class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void Add(Student student)
        {
            if (IsStudentExists(student.RegistrationNumber))
            {
                Console.WriteLine("Student already exists.");
            }
            else
            {
                students.Add(student);
                Console.WriteLine("Student added successfully.");
            }
        }

        public bool IsStudentExists(string registrationNumber)
        {
            foreach (var student in students)
            {
                if (student.RegistrationNumber == registrationNumber)
                {
                    Console.WriteLine("Student exist");
                    return true;
                }

            }
            return false;

        }

        public void Update(string registrationNumber, Student updatedStudent)
        {
            Student student = FindStudent(registrationNumber);
            if (student != null)
            {
                student.StudentName = updatedStudent.StudentName;
                student.standard = updatedStudent.standard;
                student.subjectMarks = updatedStudent.subjectMarks;
                Console.WriteLine("Student update successful.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void Delete(string registrationNumber)
        {
            Student student = FindStudent(registrationNumber);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student deleted successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void Search(string registrationNumber)
        {
            Student student = FindStudent(registrationNumber);
            if (student != null)
            {
                Console.WriteLine(student);
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public Student FindStudent(string registrationNumber)
        {
            foreach (var student in students)
            {
                if (student.RegistrationNumber == registrationNumber)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
