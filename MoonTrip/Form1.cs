using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoonTrip
{
    /// <summary>
    /// Program: LabExercise06 (MoonTrip)
    /// Author: Nicholas J. Corkigian
    /// Date:   October 10, 2019
    /// 
    /// Purpose: Add astronauts to a listbox and schedule their departure times.
    ///          There is a maximum of three astronauts per trip.
    ///          An astronaut can't be on the same trip more than once.
    ///          Launches are only scheduled on the first Saturday of a month.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool validDate = false;                     // Set when a valid departure date is selected

        /// <summary>
        /// Validate the departure date to be the first Saturday of the month. If that date has passed, 
        /// reschedule for the following month.
        /// </summary>
        /// <param name="sender">Default sender</param>
        /// <param name="e">Default event arguments</param>
        private void DepartureMonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Assume the selected date is not valid
            statusLabel.ForeColor = Color.Red;
            validDate = false;

            // Create a date from the MonthCalendar object - this will be a bit easier to work with.
            DateTime date = new DateTime(departureMonthCalendar.SelectionStart.Year, departureMonthCalendar.SelectionStart.Month, departureMonthCalendar.SelectionStart.Day);

            // If we're not in the first week of the month, go back to the first of the month
            if (date.Day > 7)
                date = new DateTime(date.Year, date.Month, 1);

            // Keep advancing a day at a time until we get to the next available Saturday
            // The next available Saturday is a Saturday that has not passed and is the first Saturday of the month
            while (date < DateTime.Today || date.Day > 7 || date.DayOfWeek != DayOfWeek.Saturday)
                date = date.AddDays(1);

            // Display a message if we had to update the date on the user
            if(departureMonthCalendar.SelectionStart != date)
                statusLabel.Text = "Must be first Saturday.\nRescheduling to next available time.";

            // If the date selected was good, display that message instead
            else
            {
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Valid date selected.";
            }

            // Set the departure date and turn on the valid date flag
            departureMonthCalendar.SetDate(date);
            validDate = true;
        }

        /// <summary>
        /// Book the trip but creating an AstronautTrip object and adding it to the listbox.
        /// This can only be done with an astronaut's name and a selected date.
        /// An astronaut can only be listed once per trip.
        /// There is a maximum of three astronauts per trip.
        /// The lisatbox is sorted by departure date.
        /// </summary>
        /// <param name="sender">Default sender</param>
        /// <param name="e">Default event arguments</param>
        private void BookTripButton_Click(object sender, EventArgs e)
        {
            // Assume we'll be issuing error messages
            statusLabel.ForeColor = Color.Red;

            // Create an AstronautTrip object with the current values
            AstronautTrip newTrip = new AstronautTrip(astronautTextBox.Text, departureMonthCalendar.SelectionStart.AddHours(6).AddMinutes(15));

            int count = 0;             // How many astronauts are already booked for this trip
            bool booked = false;       // If this astronaut is already booked for this trip

            // Go through each entry in the listbox and determine how many match the selected departure date, and if the astronaut is already booked
            foreach (AstronautTrip trip in tripListBox.Items)
            {
                if (trip.Depart.Equals(newTrip.Depart))
                {
                    count++;

                    if (trip.Name.Equals(newTrip.Name))
                        booked = true;
                }
            }

            // Astronauts need a name
            if (newTrip.Name == String.Empty)
            {
                statusLabel.Text = "Astronaut name is required.";
                astronautTextBox.Focus();
            }

            // Astronauts can't be booked multiple times for the same trip
            else if (booked)
                statusLabel.Text = $"{newTrip.Name} is already booked for this trip.";

            // Each trip has a maximum of three astronauts that can be booked
            else if (count >= 3)
                statusLabel.Text = "Capsule can only carry 3 persons.";

            // A valid date needs to be selected
            else if (!validDate)
            {
                statusLabel.Text = "Valid date needs to be selected.";
                departureMonthCalendar.Focus();
            }

            // Everything is good, so add to the listbox
            else
            {
                tripListBox.Items.Add(newTrip);
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Trip successfully booked.";

                // Sort the listbox by departure date
                SortList();
                astronautTextBox.Focus();
            }
        }

        /// <summary>
        /// The exit button will close the form and end the program.
        /// </summary>
        /// <param name="sender">Default sender</param>
        /// <param name="e">Default event arguments</param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This method will sort the listbox contents. The listbox can only be default sorted
        /// as a string but we'd like to sort by departure times.
        /// 
        /// To do this, copy the contents out to a list, sort the list, then copy the list
        /// contents back to the listbox.
        /// </summary>
        private void SortList()
        {
            List<AstronautTrip> sortedList = tripListBox.Items.Cast<AstronautTrip>().ToList();

            sortedList.Sort();

            tripListBox.Items.Clear();

            tripListBox.Items.AddRange(sortedList.ToArray());
        }
    }
}
