using Lab2;
using System;

namespace Lab2A
{
    //I, Meetkumar Prajapati, 000922812 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
    internal class Ellipse : Shape
    {
        private double longRadius; // The long radius of the ellipse
        private double smallRadius; // The small radius of the ellipse

        public Ellipse()
        {
            Type = "Ellipse"; // Setting the type of shape
        }

        /// <summary>
        /// Prompts the user to enter the dimensions of the ellipse.
        /// Ensures the values entered are greater than zero.
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter the long radius of the Ellipse:");
            longRadius = GetPositiveDouble("Value of long radius must be a positive value.");
            Console.WriteLine("Enter the small radius of the Ellipse:");
            smallRadius = GetPositiveDouble("Value of small radius must be a positive value.");
        }

        /// <summary>
        /// Calculates the area of the ellipse.
        /// </summary>
        /// <returns>The area of the ellipse.</returns>
        public override double CalculateArea()
        {
            return PI * longRadius * smallRadius; // Area formula for an ellipse
        }

        /// <summary>
        /// Calculates the volume of the ellipse.
        /// Not applicable for a 2D shape.
        /// </summary>
        /// <returns>0 as volume is not applicable for 2D shapes.</returns>
        public override double CalculateVolume()
        {
            return 0; // Not applicable for 2D shape
        }

        /// <summary>
        /// Returns a string representation of the ellipse's details.
        /// </summary>
        /// <returns>Details of the ellipse including area.</returns>
        public override string ToString()
        {
            return $"{Type}: Long Radius = {longRadius}, Small Radius = {smallRadius}, Area = {CalculateArea()}";
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
