using System;
using System.Collections.Generic;
using System.IO;

namespace Lab1
{
    internal class Lab1
    {
        private List<Employee> employees = new(); // Use List<Employee> instead of an array

        static void Main(string[] args)
        {
            Console.WriteLine("I, Meetkumar Prajapati, 000922812 certify that this material is my original work. No other person's work has been used without due acknowledgement.");

            Lab1 lab = new();
            string path = "C:\Users\meet1\source\repos\Lab1\employees.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("File found!");
            }
            else
            {
                Console.WriteLine("File not found.");
            }


            //lab.ReadEmployees(path);

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Sort by Employee Name (ascending)");
                Console.WriteLine("2. Sort by Employee Number (ascending)");
                Console.WriteLine("3. Sort by Employee Pay Rate (descending)");
                Console.WriteLine("4. Sort by Employee Hours (descending)");
                Console.WriteLine("5. Sort by Employee Gross Pay (descending)");
                Console.WriteLine("6. Exit");

                if (!int.TryParse(Console.ReadLine(), out int option) || option < 1 || option > 6)
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    continue;
                }

                if (option == 6) break;

                lab.SortEmployees(option);
                lab.PrintEmployees();
            }
        }

        public void ReadEmployees(string path)
        {
            try
            {
                if (!File.Exists(path))
                    throw new FileNotFoundException("The file could not be found.");

                foreach (string line in File.ReadLines(path))
                {
                    string[] fields = line.Split(',');
                    if (fields.Length == 4)
                    {
                        employees.Add(new Employee(
                            fields[0].Trim(),
                            int.Parse(fields[1].Trim()),
                            decimal.Parse(fields[2].Trim()),
                            double.Parse(fields[3].Trim())
                        ));
                    }
                }
                Console.WriteLine("Employees loaded successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error reading file: {e.Message}");
            }
        }

        public void PrintEmployees()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        public void SortEmployees(int option)
        {
            switch (option)
            {
                case 1: // Sort by Name (ascending)
                    employees.Sort(); // Uses IComparable implementation
                    Console.WriteLine("Sorted by Employee Name (ascending).");
                    break;
                case 2: // Sort by Number (ascending)
                    employees.Sort((e1, e2) => e1.Number.CompareTo(e2.Number));
                    Console.WriteLine("Sorted by Employee Number (ascending).");
                    break;
                case 3: // Sort by Pay Rate (descending)
                    employees.Sort((e1, e2) => e2.Rate.CompareTo(e1.Rate));
                    Console.WriteLine("Sorted by Employee Pay Rate (descending).");
                    break;
                case 4: // Sort by Hours (descending)
                    employees.Sort((e1, e2) => e2.Hours.CompareTo(e1.Hours));
                    Console.WriteLine("Sorted by Employee Hours (descending).");
                    break;
                case 5: // Sort by Gross Pay (descending)
                    employees.Sort((e1, e2) => e2.GrossPay.CompareTo(e1.GrossPay));
                    Console.WriteLine("Sorted by Employee Gross Pay (descending).");
                    break;
            }
        }
    }
}
