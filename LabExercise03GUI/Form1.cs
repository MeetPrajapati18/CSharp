using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabExercise03;

namespace LabExercise03GUI
{
    public partial class Form1 : Form
    {
        private Car[] cars;

        public Form1()
        {
            InitializeComponent();

            cars = new Car[5];
            cars[0] = new Car("Honda", "Civic", 40, 550);
            cars[1] = new Car("Ford", "Mustang", 45, 432);
            cars[2] = new Car("VW", "Golf", 34, 667);
            cars[3] = new Car("Ford", "Focus", 39, 600);
            cars[4] = new Car("Chevrolet", "Cruz", 40, 525);
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            String output = String.Empty;

            foreach (Car c in cars)
                output += c + "\r\n";

            OutputTextBox.Text = output;
        }

        private void MileageButton_Click(object sender, EventArgs e)
        {
            double bestMileage = cars[0].CalculateFuelEfficiency();
            int bestCar = 0;

            for (int c = 1; c < cars.Length; c++)
                if (cars[c].CalculateFuelEfficiency() < bestMileage)
                {
                    bestMileage = cars[c].CalculateFuelEfficiency();
                    bestCar = c;
                }
            OutputTextBox.Text = $"The most efficient car is: {cars[bestCar]}";
        }

        private void FordButton_Click(object sender, EventArgs e)
        {
            String output = String.Empty;

            foreach (Car c in cars)
                if (c.GetMake() == "Ford")
                    output += c + "\r\n";

            OutputTextBox.Text = output;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
