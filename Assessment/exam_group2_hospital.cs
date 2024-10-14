using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hospitalManagement
{
    internal class Program
    {
        static List<Dictionary<string,string> > departments = new List<Dictionary<string,string>>();
        static List<Dictionary<string,string>> doctors = new List<Dictionary<string,string>>();
        static List<Dictionary<string,string>> patients = new List< Dictionary<string,string>>();

        // adding department
        static void addDepartment()
        {
            var department = new Dictionary<string, string>();

            Console.Write("add department name: ");
            department.Add("name", Console.ReadLine());
            departments.Add(department);
        }
        // adding doctor
        static void addDoctors()
        {
            var doctor = new Dictionary<string, string>();

            Console.Write("enter doctor name: ");
            doctor.Add("name", Console.ReadLine());

            Console.Write("enter department of doctor: ");
            string department = Console.ReadLine();
            doctor.Add("department", department);
            doctors.Add(doctor);
        }

        // adding patient
        static void addPatients()
        {
            var patient = new Dictionary<string, string>();
            Console.Write("enter patientname: ");
            patient.Add("name", Console.ReadLine()); ;

            Console.Write("enter patient age: ");
            patient.Add("age", Console.ReadLine());

            Console.Write("enter doctr_name assigned: ");
            string doctor = Console.ReadLine();
            patient.Add("doctor", doctor);

            Console.Write("enter symptom: ");
            patient.Add("symptoms", Console.ReadLine());
            patients.Add(patient);
        }

        // searching patient by symptos
        static void PatientBySymptoms()
        {
            Console.Write("enter a symptom to search: ");
            string symptomSearch = Console.ReadLine();

            foreach (var patient in patients)
            {
                if (patient["symptoms"].Contains(symptomSearch))
                {
                    Console.WriteLine($"{patient["name"]}, {patient ["symptoms"]}");
                    return;
                }
            }
            Console.WriteLine("patieent not found: " + symptomSearch);
        }

        // finding all doctors of a department;
        static void DoctorsListByDepartment()
        {
            Console.Write("enter department to find all doctors: ");
            string dept = Console.ReadLine();

            foreach(var doctor in doctors)
            {
                if (doctor["department"] == dept)
                {
                    Console.WriteLine($"{doctor["name"]}");
                }
            }
        }

        // list of patients assighed to doctor
        static void PatientAssignedToDoctor()
        {
            Console.Write("enter a doctor to search: ");
            string doctorSearch = Console.ReadLine();

            foreach (var patient in patients)
            {
                if (patient["doctor"].Contains(doctorSearch))
                {
                    Console.WriteLine($"{patient["name"]}");
                    return;
                }
            }
            Console.WriteLine("patieent not found assignd to: " + doctorSearch);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Add department");
                Console.WriteLine("2.add doctor");
                Console.WriteLine("3.Add patient");
                Console.WriteLine("4.Search patient by symptom");
                Console.WriteLine("5.List doctors in department");
                Console.WriteLine("6.List patients assigned to doctor");
                Console.WriteLine("choose option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        addDepartment ();
                        break;
                    case "2":
                        addDoctors();
                        break;
                    case "3":
                        addPatients();
                        break;
                    case "4":
                        PatientBySymptoms();
                        break;
                    case "5":
                        DoctorsListByDepartment();
                        break;
                    case "6":
                        PatientAssignedToDoctor();
                        break;
                }
            }
        }
    }      
}