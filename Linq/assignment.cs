using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareManagement
{
    class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MedicalCondition {  get; set; }
    }

    class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string DoctorName { get; set; }
        public string AppointmentType { get; set; }
        public DateTime AppointmentDate { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Patient> patients = new List<Patient>
            {
                new Patient { Id = 1, Name = "Alice", Age = 65, Gender = "Female", MedicalCondition = "Diabetes" },
                new Patient { Id = 2, Name = "Bob", Age = 50, Gender = "Male", MedicalCondition = "Hypertension" },
                new Patient { Id = 3, Name = "Charlie", Age = 70, Gender = "Male", MedicalCondition = "Diabetes" },
                new Patient { Id = 4, Name = "Diana", Age = 45, Gender = "Female", MedicalCondition = "Asthma" },
                new Patient { Id = 5, Name = "Ethan", Age = 80, Gender = "Male", MedicalCondition = "Heart Disease" }
            };

            List<Appointment> appointments = new List<Appointment>
            {
                new Appointment { Id = 1, PatientId = 1, DoctorName = "Dr. Smith", AppointmentDate = DateTime.Now.AddDays(3), AppointmentType = "Consultation" },
                new Appointment { Id = 2, PatientId = 2, DoctorName = "Dr. Jones", AppointmentDate = DateTime.Now.AddDays(10), AppointmentType = "Follow-up" },
                new Appointment { Id = 3, PatientId = 3, DoctorName = "Dr. Brown", AppointmentDate = DateTime.Now.AddDays(5), AppointmentType = "Surgery" },
                new Appointment { Id = 4, PatientId = 1, DoctorName = "Dr. Smith", AppointmentDate = DateTime.Now.AddDays(-20), AppointmentType = "Consultation" },
                new Appointment { Id = 5, PatientId = 3, DoctorName = "Dr. Brown", AppointmentDate = DateTime.Now.AddDays(2), AppointmentType = "Consultation" },
                new Appointment { Id = 6, PatientId = 5, DoctorName = "Dr. White", AppointmentDate = DateTime.Now.AddDays(15), AppointmentType = "Check-up" }
            };

            DateTime today = DateTime.Now;
            DateTime nextWeek = today.AddDays(7);
            DateTime lastMonth = today.AddDays(-30);

            // upcoming appointments
            var upcomingAppointments = patients
                .Join(appointments,
                      p => p.Id,
                      a => a.PatientId,
                      (p, a) => new { Patient = p, Appointment = a })
                .Where(pa => pa.Appointment.AppointmentDate >= today && pa.Appointment.AppointmentDate <= nextWeek)
                .Select(pa => new
                {
                    pa.Patient.Name,
                    pa.Patient.Age,
                    pa.Patient.MedicalCondition
                })
                .ToList();
            Console.WriteLine("Upcoming appointments:");
            foreach (var patient in upcomingAppointments)
            {
                Console.WriteLine($"Name: {patient.Name}, Age: {patient.Age}, Medical condition: {patient.MedicalCondition}");
            }

            //group patient by medical condition
            var medicalConditionGroup = patients
                .Join(appointments,
                p => p.Id,
                a => a.PatientId,
                (p,a) => new { Patient = p,Appointment = a}
                )
                .Where(pa => pa.Appointment.AppointmentDate > today && pa.Appointment.AppointmentDate <= nextWeek)
                .GroupBy(pa => pa.Patient.MedicalCondition)
                .Select(group => new
                {
                    MedicalCondition = group.Key,
                    TotalPatients = group.Count()
                })
                .ToList();
            Console.WriteLine("total patients with medical condition who have upcoming appointments:");
            foreach (var group in medicalConditionGroup)
            {
                Console.WriteLine($"Medical condition: {group.MedicalCondition}, total Patients: {group.TotalPatients}");
            }

            //patient with most appointments in last 30 days
            var mostAppointments = patients
                .Join(appointments,
                    p => p.Id,
                    a => a.PatientId,
                    (p,a) => new { Patient = p,Appointments = a})
                .Where(pa => pa.Appointments.AppointmentDate >= lastMonth && pa.Appointments.AppointmentDate <= today)
                .GroupBy(pa => pa.Patient.Id)
                .Select(group => new
                {
                    PatientId = group.Key,
                    AppointmentsCount = group.Count()
                })
                .OrderByDescending(x => x.AppointmentsCount)
                .ToList();

            int maxAppointments = mostAppointments.FirstOrDefault()?.AppointmentsCount ?? 0;
            var patientsWithMostAppointments = mostAppointments
                .Where(p => p.AppointmentsCount == maxAppointments)
                .Join(patients,
                      p => p.PatientId,
                      patient => patient.Id,
                      (p, patient) => new
                      {
                          patient.Name,
                          p.AppointmentsCount
                      })
                .ToList();

            Console.WriteLine("\nPatient with the most appointments in the last 30 days:");
            foreach (var patient in patientsWithMostAppointments)
            {
                Console.WriteLine($"Name: {patient.Name}, Appointment Count: {patient.AppointmentsCount}");
            }

            var seniorPatientsRecentAppointments = patients
                .Where(p => p.Age > 60)
                .Join(appointments,
                      p => p.Id,
                      a => a.PatientId,
                      (p, a) => new { Patient = p, Appointment = a })
                .GroupBy(pa => pa.Patient)
                .Select(group => new
                {
                    PatientName = group.Key.Name,
                    MostRecentAppointment = group.OrderByDescending(pa => pa.Appointment.AppointmentDate).FirstOrDefault().Appointment
                })
                .ToList();

            Console.WriteLine("\nPatients over 60 with their most recent appointment:");
            foreach (var patient in seniorPatientsRecentAppointments)
            {
                Console.WriteLine($"Patient Name: {patient.PatientName}, Doctor: {patient.MostRecentAppointment.DoctorName}, Appointment Date: {patient.MostRecentAppointment.AppointmentDate}, Appointment Type: {patient.MostRecentAppointment.AppointmentType}");
            }

            Console.ReadKey();


        }
    }
}
