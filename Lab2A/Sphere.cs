using Lab2;
using System;

namespace Lab2A
{
    //I, Meetkumar Prajapati, 000922812 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
    internal class Sphere : Shape
    {
        private double radius; // The radius of the sphere
        public Sphere()
        {
            Type = "Sphere"; // Setting the type of shape
        }

        /// <summary>
        /// Prompts the user to enter the radius of the sphere.
        /// Ensures the value entered is greater than zero.
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter the radius of the Sphere:");
            radius = GetPositiveDouble("Radius of the Sphere must be a positive value.");
        }

        /// <summary>
        /// Calculates the surface area of the sphere.
        /// </summary>
        /// <returns>The surface area of the sphere.</returns>
        public override double CalculateArea()
        {
            return 4 * PI * (radius * radius); // Surface area formula for a sphere
        }

        /// <summary>
        /// Calculates the volume of the sphere.
        /// </summary>
        /// <returns>The volume of the sphere.</returns>
        public override double CalculateVolume()
        {
            return (4.0 / 3.0) * PI * (radius * radius * radius); // Volume formula for a sphere
        }

        /// <summary>
        /// Returns a string representation of the sphere's details.
        /// </summary>
        /// <returns>Details of the sphere including area and volume.</returns>
        public override string ToString()
        {
            return $"{Type}: Radius = {radius}, Area = {CalculateArea()}, Volume = {CalculateVolume()}";
        }

        /// <summary>
        /// Helper method to ensure the input is a positive double.
        /// </summary>
        /// <param name="errorMessage">The error message to display if the input is invalid.</param>
        /// <returns>A positive double value.</returns>
        private double GetPositiveDouble(string errorMessage)
        {
            double value;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                {
                    return value;
                }
                Console.WriteLine(errorMessage);
                Console.Write("Please enter a positive number: ");
            }
        }
    }
}
