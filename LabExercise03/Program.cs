using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabExercise03
{
    /// <summary>
    /// Program: LabExercise03
    /// Author: Nicholas J. Corkigian
    /// Date: September 19, 2019
    /// 
    /// Purpose: Read a file of car makes and models and present a menu interface to the user.
    /// </summary>
    class Program
    {
        /// <summary>
        /// This method sorts the car array.
        /// </summary>
        /// <param name="cars">Array of Car objects</param>
        public static void Sort(Car[] cars)
        {
            // Bubble Sort - with modification to sort on two keys.
            for (int p = 0; p < cars.Length - 1; p++)
                for (int s = 0; s < cars.Length - 1; s++)
                    if (cars[s].GetMake().CompareTo(cars[s + 1].GetMake()) > 0 ||
                       (cars[s].GetMake().CompareTo(cars[s + 1].GetMake()) == 0 && cars[s].GetModel().CompareTo(cars[s + 1].GetModel()) > 0))
                    {
                        Car temp = cars[s];
                        cars[s] = cars[s + 1];
                        cars[s + 1] = temp;
                    }
        }

        /// <summary>
        /// This method reads the data file, parses each line, and populates the Car array.
        /// </summary>
        /// <param name="fileName">The filename of the data file</param>
        /// <returns>A populated array of Cars</returns>
        public static Car[] Read(String fileName)
        {
            // File I/O should have exception checking
            try
            {
                StreamReader reader = new StreamReader(fileName);

                // 1. Create array of Cars with at least 6 elements
                Car[] cars = new Car[6];
                int count = 0;

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    // 2. Split line into fields using the String.Split method
                    String[] data = line.Split(',');

                    // 3. Create a Car object with the 4 properties.  You will need to convert
                    //    the last two properties to Double using the Parse method.
                    Car temp = new Car(data[0], data[1], Convert.ToDouble(data[2]), Convert.ToDouble(data[3]));
                    cars[count] = temp;
                    count++;
                }
                // Will return the Cars Array to Main
                reader.Close();
                return cars;
            }
            // 4.Catch any specific exceptions that could be thrown.
            //   (may be more than one)
            catch (IOException)
            {
                Console.WriteLine("*** ERROR *** File not found. Aborting program.");
                System.Environment.Exit(1);
            }

            return null; // If there was an error
        }

        /// <summary>
        /// The main method runs the show.
        /// </summary>
        /// <param name="args">Command line arguments are not used at this time</param>
        static void Main(string[] args)
        {
            Car[] cars = Read(@"..\..\Cars.csv");

            Console.WriteLine("C A R  A P P L I C A T I O N");
            Console.WriteLine("============================");

            String choice;

            // Keep displaying the menu until the user selects the exit option
            while ((choice = Menu()) != "5")
            {
                Console.WriteLine();

                switch (choice)
                {
                    // List all cars
                    case "1":
                        foreach (Car c in cars)
                            Console.WriteLine(c);
                        break;

                    // Determine the car with the best mileage (efficiency)
                    case "2":
                        double bestMileage = cars[0].CalculateFuelEfficiency();
                        int bestCar = 0;

                        for (int c = 1; c < cars.Length; c++)
                            if (cars[c].CalculateFuelEfficiency() < bestMileage)
                            {
                                bestMileage = cars[c].CalculateFuelEfficiency();
                                bestCar = c;
                            }
                        Console.WriteLine($"The most efficient car is: {cars[bestCar]}");
                        break;

                    // Display only Ford models
                    case "3":
                        foreach (Car c in cars)
                            if (c.GetMake() == "Ford")
                                Console.WriteLine(c);
                        break;

                    // Sort the cars
                    case "4":
                        Sort(cars);
                        break;
                }
            }
        }

        /// <summary>
        /// This method displays a menu of options for the user
        /// </summary>
        /// <returns>The user's menu selection</returns>
        private static String Menu()
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("1 - Display all of the Cars");
            Console.WriteLine("2 - List car with best Mileage");
            Console.WriteLine("3 - List all Cars from Ford");
            Console.WriteLine("4 - Sort Cars");
            Console.WriteLine("5 - Exit application");
            Console.Write("\nEnter Option: ");
            return Console.ReadLine();
        }
    }
}
