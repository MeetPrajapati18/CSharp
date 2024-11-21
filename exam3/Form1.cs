using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            double total = 0.0;

            // Calculate cost for patties
            if (listBox1.SelectedItem != null)
            {
                string selectedPatty = listBox1.SelectedItem.ToString();

                switch (selectedPatty)
                {
                    case "Single-Burger ($2.50)":
                        total += 2.50;
                        break;
                    case "Double-Burger ($3.50)":
                        total += 3.50;
                        break;
                    case "Triple-Burger ($4.00)":
                        total += 4.00;
                        break;
                }
            }

            // Calculate cost for toppings
            if (lettuce.Checked) total += 0.25;
            if (tomato.Checked) total += 0.25;
            if (onion.Checked) total += 0.25;
            if (ketchup.Checked) total += 0.25;
            if (mustard.Checked) total += 0.25;

            // Calculate cost for side
            if (fires.Checked)
            {
                total += 3.25;
            }
            else if (salad.Checked)
            {
                total += 5.25;
            }
            // No cost for "No Side" if noside.Checked is true

            // Display the total value
            totalValue.Text = $"${total:0.00}";
        }

    }
}
