using Lab2;
using System;

namespace Lab2A
{
    //I, Meetkumar Prajapati, 000922812 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
    internal class Triangle : Shape
    {
        private double baseLength; // Base length of the triangle
        private double height;     // Height of the triangle

        public Triangle()
        {
            Type = "Triangle"; // Setting the type of shape
        }

        /// <summary>
        /// Prompts the user to enter the base and height of the triangle.
        /// Ensures the values entered are greater than zero.
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter the length of the base of the triangle:");
            baseLength = GetPositiveDouble("Base length must be a positive value.");
            Console.WriteLine("Enter the height of the triangle:");
            height = GetPositiveDouble("Height must be a positive value.");
        }

        /// <summary>
        /// Calculates the area of the triangle.
        /// </summary>
        /// <returns>The area of the triangle.</returns>
        public override double CalculateArea()
        {
            return (baseLength * height) / 2; // Area formula for a triangle
        }

        /// <summary>
        /// Volume calculation is not applicable for a 2D shape.
        /// </summary>
        /// <returns>Throws NotImplementedException.</returns>
        public override double CalculateVolume()
        {
            throw new NotImplementedException("Volume is not applicable for a triangle.");
        }

        /// <summary>
        /// Returns a string representation of the triangle's details.
        /// </summary>
        /// <returns>Details of the triangle including area.</returns>
        public override string ToString()
        {
            return $"{Type}: Base = {baseLength}, Height = {height}, Area = {CalculateArea()}";
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