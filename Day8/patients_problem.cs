using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{

    internal class Program
    {
        static List<Dictionary<string, string>> patients = new List<Dictionary<string, string>>();

        static int patientId = 1;

        static void AddPatient()
        {
            var patient = new Dictionary<string, string>();

            patient.Add("id", patientId.ToString());

            Console.Write("Enter patient name: ");
            patient.Add("name", Console.ReadLine());

            Console.Write("Enter the patient age: ");
            patient.Add("age", Console.ReadLine());

            Console.Write("Enter symptoms with coma separation: ");
            patient.Add("symptoms", Console.ReadLine());

            // Add patient to the list
            patients.Add(patient);

            Console.WriteLine("Patient added successfully with ID: " + patient["id"]);

            patientId++;
        }

        // search patient details by ID
        static void GetPatientDetailsById()
        {
            Console.WriteLine("Enter the patient ID to search: ");
            string id = Console.ReadLine();

            foreach (var patient in patients)
            {
                if (patient["id"] == id)
                {
                    Console.WriteLine($"ID: {patient["id"]}, Name: {patient["name"]}, Age: {patient["age"]}, Symptoms: {patient["symptoms"]}");
                    return;
                }
            }
            Console.WriteLine("Patient ID not found: " + id);
        }

        // patient id with symptoms
        static void GetPatientIdBySymptoms()
        {
            Console.WriteLine("Enter the symptom: ");
            string symptomToSearch = Console.ReadLine();

            foreach (var patient in patients)
            {
                if (patient["symptoms"].Contains(symptomToSearch))
                {
                    Console.WriteLine($"{patient["id"]}, Name: {patient["name"]}, Symptoms: {patient["symptoms"]}");
                    return;
                }
            }

            Console.WriteLine("No patient found: " + symptomToSearch);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Add Patient");
                Console.WriteLine("2.Search Patient by ID");
                Console.WriteLine("3.Search Patient by Symptom");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddPatient();
                        break;
                    case "2":
                        GetPatientDetailsById();
                        break;
                    case "3":
                        GetPatientIdBySymptoms();
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

    }
}

   

