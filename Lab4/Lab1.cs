using System;
using System.Collections.Generic;
using System.IO;

namespace Lab1
{
    /// <summary>
    /// The Lab1 class is responsible for managing a list of employees, reading employee data from a file, sorting employees based on various criteria, and displaying them.
    /// </summary>
    internal class Lab1
    {
        // List to store Employee objects.
        private List<Employee> employees = new(); // Using List<Employee> instead of an array for dynamic size.

        /// <summary>
        /// It'll load the file according to the provided the path of the file and then it'll reads the content of the file and thel it'll load the file contnet and sort data of the file according to user's preference and then it'll print that data.
        /// </summary>
        /// <param name="args">Command-line arguments (not used in this case).</param>
        static void Main(string[] args)
        {
            // printing statement of authorship
            Console.WriteLine("I, Meetkumar Prajapati, 000922812 certify that this material is my original work. No other person's work has been used without due acknowledgement.");

            // Create an instance of the Lab1 class to manage employees
            Lab1 lab = new();

            // Define the path to the employee data file
            string fiePath = @"C:\Users\meet1\source\repos\Lab4\employees.txt";

            // Read employee data from the file
            lab.ReadEmployees(fiePath);

            // running infinite loop until user want to exit the application
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Sort by Employee Name (ascending)");
                Console.WriteLine("2. Sort by Employee Number (ascending)");
                Console.WriteLine("3. Sort by Employee Pay Rate (descending)");
                Console.WriteLine("4. Sort by Employee Hours (descending)");
                Console.WriteLine("5. Sort by Employee Gross Pay (descending)");
                Console.WriteLine("6. Exit");

                // Read and validate user input for menu options
                if (!int.TryParse(Console.ReadLine(), out int option) || option < 1 || option > 6)
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    continue; // Continue the loop if the option is invalid
                }

                // Exit the program if the option is 6
                if (option == 6) break;

                // Sort employees based on the selected option
                lab.SortEmployees(option);

                // Print the sorted employees
                lab.PrintEmployees();
            }
        }

        /// <summary>
        /// Reads employee data from the specified file and stores it in the employees list.
        /// </summary>
        /// <param name="path">The path to the employee data file.</param>
        public void ReadEmployees(string path)
        {
            try
            {
                // Check if the file exists, if not, throw an exception
                if (!File.Exists(path))
                    throw new FileNotFoundException("The file could not be found.");

                // Read each line from the file
                foreach (string line in File.ReadLines(path))
                {
                    // Split the line by commas and parse the fields
                    string[] fields = line.Split(',');

                    // Ensure there are exactly 4 fields per line
                    if (fields.Length == 4)
                    {
                        // Create a new Employee object and add it to the list
                        employees.Add(new Employee(
                            fields[0].Trim(), // Employee Name
                            int.Parse(fields[1].Trim()), // Employee Number
                            decimal.Parse(fields[2].Trim()), // Pay Rate
                            double.Parse(fields[3].Trim()) // Hours worked
                        ));
                    }
                }
                // Display success message after loading employees
                Console.WriteLine("Employees loaded successfully.");
            }
            catch (Exception e)
            {
                // Handle any exceptions that occur while reading the file
                Console.WriteLine($"Error reading file: {e.Message}");
            }
        }

        /// <summary>
        /// It'll print the list of employees  
        /// </summary>
        public void PrintEmployees()
        {
            // Iterate over each employee and print their details
            foreach (var employee in employees)
            {
                Console.WriteLine(employee); // Call ToString() method of Employee to display formatted information
            }
        }

        /// <summary>
        /// It'll sort the list of array according to user's preferance
        /// </summary>
        /// <param name="option">The option indicating the sort criteria.</param>
        public void SortEmployees(int option)
        {
            // Switch case to handle different sorting options
            switch (option)
            {
                case 1: // Sort by Name (ascending)
                    employees.Sort(); // Uses IComparable implementation for sorting by name
                    Console.WriteLine("Sorted by Employee Name (ascending).");
                    break;
                case 2: // Sort by Employee Number (ascending)
                    employees.Sort((e1, e2) => e1.Number.CompareTo(e2.Number)); // Sort by employee number
                    Console.WriteLine("Sorted by Employee Number (ascending).");
                    break;
                case 3: // Sort by Pay Rate (descending)
                    employees.Sort((e1, e2) => e2.Rate.CompareTo(e1.Rate)); // Sort by pay rate in descending order
                    Console.WriteLine("Sorted by Employee Pay Rate (descending).");
                    break;
                case 4: // Sort by Hours (descending)
                    employees.Sort((e1, e2) => e2.Hours.CompareTo(e1.Hours)); // Sort by hours worked in descending order
                    Console.WriteLine("Sorted by Employee Hours (descending).");
                    break;
                case 5: // Sort by Gross Pay (descending)
                    employees.Sort((e1, e2) => e2.GrossPay.CompareTo(e1.GrossPay)); // Sort by gross pay in descending order
                    Console.WriteLine("Sorted by Employee Gross Pay (descending).");
                    break;
            }
        }
    }
}
