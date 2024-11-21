using Lab2;
using System;

namespace Lab2A
{
    //I, Meetkumar Prajapati, 000922812 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
    internal class Circle : Shape
    {
        private double radius; // The radius of the circle

        public Circle()
        {
            Type = "Circle"; // Setting the type of shape
        }

        /// <summary>
        /// Prompts the user to enter the radius of the circle.
        /// Ensures the value entered is greater than zero.
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter the radius of the Circle:");
            radius = GetPositiveDouble("Value of radius must be a positive value.");
        }

        /// <summary>
        /// Calculates the area of the circle.
        /// </summary>
        /// <returns>The area of the circle.</returns>
        public override double CalculateArea()
        {
            return PI * radius * radius; // Area formula for a circle
        }

        /// <summary>
        /// Calculates the volume of the circle.
        /// Not applicable for a 2D shape.
        /// </summary>
        /// <returns>0 as volume is not applicable for 2D shapes.</returns>
        public override double CalculateVolume()
        {
            return 0; // Not applicable for 2D shape
        }

        /// <summary>
        /// Returns a string representation of the circle's details.
        /// </summary>
        /// <returns>Details of the circle including area.</returns>
        public override string ToString()
        {
            return $"{Type}: Radius = {radius}, Area = {CalculateArea()}";
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
