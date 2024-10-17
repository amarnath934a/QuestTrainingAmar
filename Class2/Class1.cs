using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class Student
    {
        public string StudentName;
        public string RegistrationNumber;
        public string standard;
        public List<SubjectMarks> subjectMarks = new List<SubjectMarks>();

        public override string ToString()
        {
            return $"StudentName: {StudentName}, StudentNumber: {RegistrationNumber}, Standard: {standard}, Marks : {subjectMarks}";
        }
    }
}
