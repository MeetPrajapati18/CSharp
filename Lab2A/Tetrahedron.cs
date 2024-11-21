using Lab2;
using System;

namespace Lab2A
{
    //I, Meetkumar Prajapati, 000922812 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
    internal class Tetrahedron : Shape
    {
        private double edgeLength; // Length of the edges of the tetrahedron

        public Tetrahedron()
        {
            Type = "Tetrahedron"; // Setting the type of shape
        }

        /// <summary>
        /// Prompts the user to enter the edge length of the tetrahedron.
        /// Ensures the value entered is greater than zero.
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter the length of the edge of the Tetrahedron:");
            edgeLength = GetPositiveDouble("Length of the edge of the Tetrahedron must be a positive value.");
        }

        /// <summary>
        /// Calculates the surface area of the tetrahedron.
        /// </summary>
        /// <returns>The surface area of the tetrahedron.</returns>
        public override double CalculateArea()
        {
            return Math.Sqrt(3) * (edgeLength * edgeLength); // Surface area formula for a tetrahedron
        }

        /// <summary>
        /// Calculates the volume of the tetrahedron.
        /// </summary>
        /// <returns>The volume of the tetrahedron.</returns>
        public override double CalculateVolume()
        {
            return (edgeLength * edgeLength * edgeLength) / (6 * Math.Sqrt(2)); // Volume formula for a tetrahedron
        }

        /// <summary>
        /// Returns a string representation of the tetrahedron's details.
        /// </summary>
        /// <returns>Details of the tetrahedron including area and volume.</returns>
        public override string ToString()
        {
            return $"{Type}: Edge Length = {edgeLength}, Area = {CalculateArea()}, Volume = {CalculateVolume()}";
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
