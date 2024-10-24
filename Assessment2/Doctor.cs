using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string Gender { get; set; }
        public int PatientId { get; set; }

        public Doctor(string name, string gender, string specialization, int patientId)
        {
            Name = name;
            Gender = gender;
            Specialization = specialization;
            PatientId = patientId;
        }
    }
}
