using Lab2;
using System;

namespace Lab2A
{
    //I, Meetkumar Prajapati, 000922812 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
    internal class Square : Shape
    {
        private double sideLength; // The length of the side of the square

        public Square()
        {
            Type = "Square"; // Setting the type of shape
        }

        /// <summary>
        /// Prompts the user to enter the length of the side of the square.
        /// Ensures the value entered is greater than zero.
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter the length of the side of the Square:");
            sideLength = GetPositiveDouble("Length must be greater than 0.");
        }

        /// <summary>
        /// Calculates the area of the square.
        /// </summary>
        /// <returns>The area of the square.</returns>
        public override double CalculateArea()
        {
            return sideLength * sideLength;
        }

        /// <summary>
        /// Calculates the volume of the square.
        /// Not applicable for a 2D shape.
        /// </summary>
        /// <returns>0 as volume is not applicable for 2D shapes.</returns>
        public override double CalculateVolume()
        {
            return 0; // Not applicable for 2D shape
        }

        /// <summary>
        /// Returns a string representation of the square's details.
        /// </summary>
        /// <returns>Details of the square including area.</returns>
        public override string ToString()
        {
            return $"{Type}: Side Length = {sideLength}, Area = {CalculateArea()}";
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
