using Lab2;
using System;

namespace Lab2A
{
    //I, Meetkumar Prajapati, 000922812 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
    internal class Cube : Shape
    {
        private double sideLength; // The length of a side of the cube

        public Cube()
        {
            Type = "Cube"; // Setting the type of shape
        }

        /// <summary>
        /// Prompts the user to enter the length of the side of the cube.
        /// Ensures the value entered is greater than zero.
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter the length of the side of the Cube:");
            sideLength = GetPositiveDouble("Length of side must be a positive value.");
        }

        /// <summary>
        /// Calculates the surface area of the cube.
        /// </summary>
        /// <returns>The surface area of the cube.</returns>
        public override double CalculateArea()
        {
            return 6 * (sideLength * sideLength); // Surface area formula for a cube
        }

        /// <summary>
        /// Calculates the volume of the cube.
        /// </summary>
        /// <returns>The volume of the cube.</returns>
        public override double CalculateVolume()
        {
            return sideLength * sideLength * sideLength; // Volume formula for a cube
        }

        /// <summary>
        /// Returns a string representation of the cube's details.
        /// </summary>
        /// <returns>Details of the cube including area and volume.</returns>
        public override string ToString()
        {
            return $"{Type}: Side Length = {sideLength}, Area = {CalculateArea()}, Volume = {CalculateVolume()}";
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
