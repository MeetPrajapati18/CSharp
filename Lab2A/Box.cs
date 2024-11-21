using Lab2;
using System;

namespace Lab2A
{
    //I, Meetkumar Prajapati, 000922812 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
    internal class Box : Shape
    {
        private double length; // The length of the box
        private double width;  // The width of the box
        private double height; // The height of the box

        public Box()
        {
            Type = "Box"; // Setting the type of shape
        }

        /// <summary>
        /// Prompts the user to enter the dimensions of the box.
        /// Ensures the values entered are greater than zero.
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter the length of the box:");
            length = GetPositiveDouble("Length must be greater than 0.");
            Console.WriteLine("Enter the width of the box:");
            width = GetPositiveDouble("Width must be greater than 0.");
            Console.WriteLine("Enter the height of the box:");
            height = GetPositiveDouble("Height must be greater than 0.");
        }

        /// <summary>
        /// Calculates the surface area of the box.
        /// </summary>
        /// <returns>The surface area of the box.</returns>
        public override double CalculateArea()
        {
            return 2 * ((length * width) + (length * height) + (width * height)); // Surface area formula for a box
        }

        /// <summary>
        /// Calculates the volume of the box.
        /// </summary>
        /// <returns>The volume of the box.</returns>
        public override double CalculateVolume()
        {
            return length * width * height; // Volume formula for a box
        }

        /// <summary>
        /// Returns a string representation of the box's details.
        /// </summary>
        /// <returns>Details of the box including area and volume.</returns>
        public override string ToString()
        {
            return $"{Type}: Length = {length}, Width = {width}, Height = {height}, Area = {CalculateArea()}, Volume = {CalculateVolume()}";
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
