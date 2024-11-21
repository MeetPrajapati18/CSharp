using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExercise05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            namesListBox.Items.Add("Lee");
            namesListBox.Items.Add("Susan");
            namesListBox.Items.Add("Jessica");
            namesListBox.Items.Add("Carmen");
            namesListBox.Items.Add("Harsh");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != String.Empty)
            {
                namesListBox.Items.Add(nameTextBox.Text);
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Name added successfully to listbox";
                nameTextBox.Text = String.Empty;
            }
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Need to have some text in the name field";
            }
            nameTextBox.Focus();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (namesListBox.SelectedIndex >= 0)
            {
                namesListBox.Items.RemoveAt(namesListBox.SelectedIndex);
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Name was successfully deleted from listbox";
                nameTextBox.Focus();
            }
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Must first select a name to delete";
            }
        }

        private void MoveUpButton_Click(object sender, EventArgs e)
        {
            if (namesListBox.SelectedIndex >= 0)
            {
                String temp = namesListBox.Items[namesListBox.SelectedIndex].ToString();
                int index = namesListBox.SelectedIndex;
                if (index != 0)
                {
                    namesListBox.Items.RemoveAt(index);
                    namesListBox.Items.Insert(index - 1, temp);
                    namesListBox.SelectedIndex = index - 1;
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = "Name was successfully moved up";
                }
                else
                {
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "Name is already at the top of the list";
                }
            }
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Must first select a name to move up";
            }
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            if (namesListBox.SelectedIndex >= 0)
            {
                String temp = namesListBox.Items[namesListBox.SelectedIndex].ToString();
                int index = namesListBox.SelectedIndex;
                if (index != namesListBox.Items.Count - 1)
                {
                    namesListBox.Items.RemoveAt(index);
                    namesListBox.Items.Insert(index + 1, temp);
                    namesListBox.SelectedIndex = index + 1;
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = "Name was successfully moved down";
                }
                else
                {
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "Name is already at the bottom of the list";
                }
            }
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Must first select a name to move down";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            namesListBox.Items.Clear();
            statusLabel.ForeColor = Color.Green;
            statusLabel.Text = "Listbox has been successfully cleared";
            nameTextBox.Focus();
        }

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            clearButton.Enabled = namesListBox.Items.Count != 0;
            namesListBox.SelectedIndex = -1;
            addButton.Enabled = false;
            deleteButton.Enabled = false;
            moveUpButton.Enabled = false;
            moveDownButton.Enabled = false;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            addButton.Enabled = nameTextBox.Text != String.Empty;
        }

        private void NamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = namesListBox.SelectedIndex != -1;
            moveUpButton.Enabled = namesListBox.SelectedIndex != -1 && namesListBox.SelectedIndex != 0;
            moveDownButton.Enabled = namesListBox.SelectedIndex != -1 && namesListBox.SelectedIndex != namesListBox.Items.Count - 1;
        }
    }
}
