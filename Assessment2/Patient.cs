using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        private int _age { get; set; }
        public string MedicalCondition { get; set; }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0 && value < 100)
                {
                    Age = value;
                }
                else
                {
                    //throw new ArgumentOutOfRangeException(nameof(Age),value,"Ahe must be in between 0 and 100 years");
                    Console.WriteLine("Age must be in between 0 and 100 years");
                }
            }
        }

        public Patient(string name, string gender, int age, string medicalCondition)
        {
            Name = name;
            Gender = gender;
            Age = age;
            MedicalCondition = medicalCondition;
        }
    }
}
