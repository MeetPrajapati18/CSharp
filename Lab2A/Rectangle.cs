using Lab2;
using System;

namespace Lab2A
{
    //I, Meetkumar Prajapati, 000922812 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
    internal class Rectangle : Shape
    {
        private double width;  // Width of the rectangle
        private double height; // Height of the rectangle

        public Rectangle()
        {
            Type = "Rectangle"; // Setting the type of shape
        }

        /// <summary>
        /// Prompts the user to enter the width and height of the rectangle.
        /// Ensures the values entered are greater than zero.
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter the width of the rectangle:");
            width = GetPositiveDouble("Width must be greater than 0.");
            Console.WriteLine("Enter the height of the rectangle:");
            height = GetPositiveDouble("Height must be greater than 0.");
        }

        /// <summary>
        /// Calculates the area of the rectangle.
        /// </summary>
        /// <returns>The area of the rectangle.</returns>
        public override double CalculateArea()
        {
            return width * height; // Area formula for a rectangle
        }

        /// <summary>
        /// Volume calculation is not applicable for a 2D shape.
        /// </summary>
        /// <returns>Returns 0 for a 2D shape.</returns>
        public override double CalculateVolume()
        {
            return 0; // Not applicable for 2D shapes
        }

        /// <summary>
        /// Returns a string representation of the rectangle's details.
        /// </summary>
        /// <returns>Details of the rectangle including width, height, and area.</returns>
        public override string ToString()
        {
            return $"{Type}: Width = {width}, Height = {height}, Area = {CalculateArea()}";
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
