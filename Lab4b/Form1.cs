using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab4b
{
    /// <summary>
    /// Form1 class will load an html file and it reads the whole html file and all tags of html file, 
    /// checking the balance of HTML tags, and displaying the results.
    /// I, Meetkumar Prajapati, 000922812 certify that this material is my original work. No other person's work has been used without due acknowledgement.
    /// </summary>
    public partial class Form1 : Form
    {
        // it keeps empty value of file path untill any specific path value is give to path.
        private string filePath = string.Empty;

        /// <summary>
        /// Initializes a new instance of the Form1 class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// it'll load the html file and content of html file when it is clicked.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event data.</param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // OpenFileDialog to allow the user to select an HTML file.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";

            // Check if the user selected a file.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName; // Store the full path of the file.
                string fileName = Path.GetFileName(filePath); // Extract the file name from the full path.

                // Set the label text to show the loaded file's name.
                fileLoadedLabel.Text = $"Loaded file: {fileName}";
            }
        }

        /// <summary>
        /// Event handler for checking the tags in the loaded HTML file when the "Check Tags" menu item is clicked.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event data.</param>
        private void checkTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if the file has been loaded before attempting to check tags.
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please load an HTML file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if no file is loaded.
            }

            // Read the content of the loaded HTML file.
            string htmlContent = File.ReadAllText(filePath);
            string result = CheckHtmlTags(htmlContent); // Check the tags in the HTML content.

            // Display the result in the filePathTextBox.
            filePathTextBox.Text = result;
        }

        /// <summary>
        /// it'll check the html tags and then it'll print the sentence according to html tags.
        /// </summary>
        /// <param name="htmlContent">The content of the HTML file.</param>
        /// <returns>A string indicating whether the tags are balanced or not.</returns>
        private string CheckHtmlTags(string htmlContent)
        {
            // Stack to track opening tags.
            Stack<string> tagStack = new Stack<string>();

            // List of non-container tags that do not require closing tags.
            List<string> nonContainerTags = new List<string> { "br", "hr", "img", "meta", "input" };

            // Regular expression to match HTML tags.
            Regex tagRegex = new Regex(@"<(/?)(\w+)[^>]*>", RegexOptions.Compiled);

            // Find all matches of tags in the HTML content.
            MatchCollection matches = tagRegex.Matches(htmlContent);
            string output = ""; // To store the result of the tag check.
            int level = 0; // Tracks the depth of nested tags for better readability.

            // Iterate through all the matched tags in the HTML content.
            foreach (Match match in matches)
            {
                string tagType = match.Groups[1].Value; // "/" for closing, empty for opening tag.
                string tagName = match.Groups[2].Value.ToLower(); // The tag name (case-insensitive).

                // Handle non-container tags that do not require closing tags.
                if (nonContainerTags.Contains(tagName))
                {
                    output += $"{new string(' ', level * 2)}Found non-container tag: <{tagName}>\r\n";
                    continue; // Skip further checks for non-container tags.
                }

                // Check for opening tags (e.g., <div>).
                if (tagType == "") // Opening tag
                {
                    output += $"{new string(' ', level * 2)}Found opening tag: <{tagName}>\r\n";
                    tagStack.Push(tagName); // Push opening tag onto the stack.
                    level++; // Increase the nesting level.
                }
                else // Check for closing tags (e.g., </div>).
                {
                    // If no matching opening tag exists, report unbalanced tags.
                    if (tagStack.Count == 0 || tagStack.Peek() != tagName)
                    {
                        output += $"{new string(' ', level * 2)}Unbalanced closing tag: </{tagName}>\r\n";
                        return output + "Tags are not balanced.\r\n";
                    }
                    level--; // Decrease the nesting level after matching closing tag.
                    output += $"{new string(' ', level * 2)}Found closing tag: </{tagName}>\r\n";
                    tagStack.Pop(); // Pop the matched opening tag from the stack.
                }
            }

            // Final balance check after processing all tags.
            if (tagStack.Count == 0)
            {
                output += "Tags are balanced.\r\n"; // If stack is empty, all tags are balanced.
            }
            else
            {
                output += "Tags are not balanced.\r\n"; // If stack is not empty, tags are unbalanced.
            }

            return output; // Return the result.
        }

        /// <summary>
        /// it'll exit the application when exit is clicked in application
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event data.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit the application when the user clicks the "Exit" option.
            Application.Exit();
        }
    }
}
