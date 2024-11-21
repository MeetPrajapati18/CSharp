using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;

namespace Lab2A
{
    //I, Meetkumar Prajapati, 000922812 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            while (true)
            {
                Console.WriteLine("\nEnter the shape you want to create (rectangle, square, box, cube, ellipse, circle, cylinder, sphere, triangle, tetrahedron) or type 'Exit' to quit:");
                string userResponse = Console.ReadLine()?.ToLower();

                if (userResponse == "exit")
                {
                    break; // Exit the loop if the user types "Exit"
                }

                Shape shape = null;

                switch (userResponse)
                {
                    case "rectangle":
                        shape = new Rectangle();
                        break;
                    case "square":
                        shape = new Square();
                        break;
                    case "box":
                        shape = new Box();
                        break;
                    case "cube":
                        shape = new Cube();
                        break;
                    case "ellipse":
                        shape = new Ellipse();
                        break;
                    case "circle":
                        shape = new Circle();
                        break;
                    case "cylinder":
                        shape = new Cylinder();
                        break;
                    case "sphere":
                        shape = new Sphere();
                        break;
                    case "triangle":
                        shape = new Triangle();
                        break;
                    case "tetrahedron":
                        shape = new Tetrahedron();
                        break;
                    default:
                        Console.WriteLine("Invalid shape. Please enter a valid shape or 'Exit'.");
                        continue; // Go back to the start of the loop
                }

                shape.SetData(); // Prompt user for dimensions
                shapes.Add(shape); // Add to list
                Console.WriteLine(shape.ToString()); // Display details of the shape
            }

            // Display all created shapes
            Console.WriteLine("\nSummary of Created Shapes:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
