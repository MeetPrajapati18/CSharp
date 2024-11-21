using Lab2;
using System;

namespace Lab2A
{
    //I, Meetkumar Prajapati, 000922812 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
    internal class Cylinder : Shape
    {
        private double radius; // The radius of the cylinder
        private double height; // The height of the cylinder

        public Cylinder()
        {
            Type = "Cylinder"; // Setting the type of shape
        }

        /// <summary>
        /// Prompts the user to enter the dimensions of the cylinder.
        /// Ensures the values entered are greater than zero.
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter the radius of the Cylinder:");
            radius = GetPositiveDouble("Radius must be a positive value.");
            Console.WriteLine("Enter the height of the Cylinder:");
            height = GetPositiveDouble("Height must be a positive value.");
        }

        /// <summary>
        /// Calculates the surface area of the cylinder.
        /// </summary>
        /// <returns>The surface area of the cylinder.</returns>
        public override double CalculateArea()
        {
            return 2 * (PI * radius * (radius + height)); // Surface area formula for a cylinder
        }

        /// <summary>
        /// Calculates the volume of the cylinder.
        /// </summary>
        /// <returns>The volume of the cylinder.</returns>
        public override double CalculateVolume()
        {
            return PI * (radius * radius) * height; // Volume formula for a cylinder
        }

        /// <summary>
        /// Returns a string representation of the cylinder's details.
        /// </summary>
        /// <returns>Details of the cylinder including area and volume.</returns>
        public override string ToString()
        {
            return $"{Type}: Radius = {radius}, Height = {height}, Area = {CalculateArea()}, Volume = {CalculateVolume()}";
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
