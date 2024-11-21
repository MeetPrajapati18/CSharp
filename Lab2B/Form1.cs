using System;
using System.Windows.Forms;

namespace Lab2B
{
    //I, Meetkumar Prajapati, 000922812 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
    public partial class Form1 : Form
    {
        // Variable to store the total price calculated
        public double total_price = 0;

        // Constructor to initialize the form components
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the Calculate button click event
        private void Calculate_Click(object sender, EventArgs e)
        {
            // Reset the total price before recalculating
            total_price = 0;

            // Calculate base price based on selected hairdresser
            if (Jane.Checked)
            {
                total_price += 30; // Price for Jane
            }
            else if (Laura.Checked)
            {
                total_price += 55; // Price for Laura
            }
            else if (Pat.Checked)
            {
                total_price += 45; // Price for Pat
            }
            else if (Ron.Checked)
            {
                total_price += 40; // Price for Ron
            }
            else if (Sue.Checked)
            {
                total_price += 50; // Price for Sue
            }

            // Validate and check the number of visits
            if (int.TryParse(NumberOfVisits.Text, out int visits) && visits > 0)
            {
                // Apply discounts based on the number of visits
                if (visits >= 4 && visits <= 8)
                {
                    total_price *= 0.95; // 5% discount
                }
                else if (visits > 8 && visits < 14)
                {
                    total_price *= 0.90; // 10% discount
                }
                else if (visits >= 14)
                {
                    total_price *= 0.85; // 15% discount
                }
            }
            else
            {
                // Show validation error if input is not a valid positive integer
                MessageBox.Show("Please enter a valid positive integer for the number of visits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NumberOfVisits.Focus(); // Set focus to the NumberOfVisits textbox
                return;
            }

            // Calculate additional services based on selected checkboxes
            if (Cut.Checked)
            {
                total_price += 30; // Price for a cut
            }
            if (Colour.Checked)
            {
                total_price += 40; // Price for colouring
            }
            if (Highlights.Checked)
            {
                total_price += 50; // Price for highlights
            }
            if (Extensions.Checked)
            {
                total_price += 200; // Price for extensions
            }

            // Apply client type discount based on selected radio button
            if (StandardAdult.Checked)
            {
                // No discount for standard adult
            }
            else if (Child.Checked)
            {
                total_price *= 0.90; // 10% discount for children
            }
            else if (Student.Checked)
            {
                total_price *= 0.95; // 5% discount for students
            }
            else if (Senior.Checked)
            {
                total_price *= 0.85; // 15% discount for seniors
            }

            // Display the final total price in the designated label
            totalPrice.Text = $"Total Price: ${total_price:F2}"; // Ensure proper formatting
        }

        // Event handler for the Clear button click event
        private void Clear_Click(object sender, EventArgs e)
        {
            // Clear input fields and reset selections
            NumberOfVisits.Clear();
            Jane.Checked = false;
            Laura.Checked = false;
            Pat.Checked = false;
            Ron.Checked = false;
            Sue.Checked = false;
            Cut.Checked = false;
            Colour.Checked = false;
            Highlights.Checked = false;
            Extensions.Checked = false;
            StandardAdult.Checked = false;
            Child.Checked = false;
            Student.Checked = false;
            Senior.Checked = false;
            total_price = 0; // Reset total price
            totalPrice.Text = "Total Price: "; // Reset displayed price
        }

        // Event handler for the Exit button click event
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the application
        }
    }
}
