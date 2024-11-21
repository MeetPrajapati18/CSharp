using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExercise09
{
    /// <summary>
    /// Program: LabExercise09 (MoonTrip)
    /// Author: Nicholas J. Corkigian
    /// Date:   November 7, 2019
    /// 
    /// Purpose: Allow a user to use various Find and Replace techniques on a TextBox (note: Replaced TextBox with RichTextBox).
    ///          The capabilities are:
    ///             1. Find the first occurrence of a string in a RichTextBox, if there is an occurrence, and select it
    ///             2. Find the next occurrence of a string in a RichTextBox, until there are no more ocurrences
    ///             3. Replace the selected text in a RichTextBox with alternative text
    ///             4. Replace all occurrences of the selected word in a RichTextBox with alternative text
    /// </summary>
    public partial class Form1 : Form
    {
        // Some default starting text - learn about Hamilton
        private const string STORY_TEXT = "Hamilton, from the point at which it was first colonized by " + 
            "settlers, has benefited from its geographical proximity to major land and water " +
            "transportation routes along the Niagara Peninsula and Lake Ontario. " +
            "Its strategic importance has created, by Canadian standards, a rich military " +
            "history which the city preserves.\r\n\r\n" +
            "Tension between maximizing economic growth and minimizing environmental damage " +
            "was evident, even from the city's early development. The area between " +
            "Burlington Bay (also known as Hamilton Harbour) and the Niagara Escarpment has " +
            "been greatly altered for residential, industrial and recreational purposes. " +
            "Cootes Paradise in Dundas also known as the Dundas Marsh, was a very rich wetland " + 
            "with plenty of fish, birds and other game. Cootes Paradise was named after Captain " +
            "Thomas Coote, a British army officer of Irish extraction who was stationed in the " + 
            "area at the time of the American revolutionary war in the 18th century. The " +
            "richness of the valley led to population, and to degradation of the marsh, although " +
            "its legal protection, starting in the 1880s, and the efforts of civic officials and " +
            "others, have led to it still being of great environmental importance in the 21st century.\r\n\r\n" +
            "For about a century after achieving its status as a city in 1846, Hamilton has seen " +
            "itself in terms of industrial production. It adopted or acquired such nicknames as " + 
            "the Ambitious City, Steel City and the Birmingham of Canada. However, after this " + 
            "period, other sectors of the economy took over and Hamilton became a post-industrial " +
            "economy but failed to change its image and self-image to match. Here then follows the " +
            "growth of the Hamilton until the end of the Second World War.\r\n\r\n" +
            "Prior to colonization, Hamilton was occupied by the Chonnonton, or Attiwandaronk, an " +
            "Iroquois-speaking nation referred to by French explorers as the \"Neutral\" people. " +
            "Since then, there have been successive waves of immigration. \r\n\r\n" +
            "https://en.wikipedia.org/wiki/History_of_Hamilton,_Ontario";

        private int lastMatch;                          // The last matching position

        /// <summary>
        /// The form's constructor, used to initialize the TextBox.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            storyRichTextBox.Text = STORY_TEXT;         // Set the text for the RichTextBox
            storyRichTextBox.SelectionStart = 0;        // Set the selection to the start of the RichTextBox
        }

        /// <summary>
        /// Find the first occurrence of the search text in the RichTextBox and select it.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void FindButton_Click(object sender, EventArgs e)
        {
            // Do a case-insensitive search
            lastMatch = storyRichTextBox.Text.IndexOf(findTextBox.Text, StringComparison.CurrentCultureIgnoreCase);

            // Show a message box if the text is not in the TextBox
            if (lastMatch < 0)
            {
                MessageBox.Show($"The text provided, \"{findTextBox.Text}\", was not found.", "Find Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CheckState();
            }

            // Select the found text - can only see the highlight if the TextBox has focus
            else
            {
                storyRichTextBox.SelectionLength = findTextBox.Text.Length;
                storyRichTextBox.SelectionStart = lastMatch;
                storyRichTextBox.Focus();
                CheckState();
            }
        }

        /// <summary>
        /// Find the next occurrence of the search text in the RichTextBox and select it.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void FindNextButton_Click(object sender, EventArgs e)
        {
            // Do a case-insensitive search starting one character past the previous search
            lastMatch = storyRichTextBox.Text.IndexOf(findTextBox.Text, lastMatch + 1, StringComparison.CurrentCultureIgnoreCase);

            // Show a message box if we've reached the end of occurrences in the TextBox
            if (lastMatch < 0)
            {
                // Because this method can be called from the "Replace All", we only want this message box displaying if it was called from the "Find Next" button
                // Cast the sending control as a Button, and see what name the sender had
                Button button = (Button)sender;
                if( button.Name == "findNextButton" )
                    MessageBox.Show($"The text provided, \"{findTextBox.Text}\", has no more occurrences.", "Find Next Text", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Set the focus to the TextBox so we can see the highlight
                storyRichTextBox.Focus();
                CheckState();
            }

            // Select the next occurrence of the text
            else
            {
                storyRichTextBox.SelectionLength = findTextBox.Text.Length;
                storyRichTextBox.SelectionStart = lastMatch;
                storyRichTextBox.Focus();
                CheckState();
            }
        }

        /// <summary>
        /// Replace the selected text in the RichTextBox with alternative text.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            // Everytime the RichTextBox has text selected, it copies that text into the search TextBox
            // We want to save the orignal search text
            string findText = findTextBox.Text;

            // If we have selected text in the RichTextBox, replace it with the replacement text
            if (storyRichTextBox.SelectionLength >= 0)
            {
                lastMatch = storyRichTextBox.SelectionStart;     // Keep track of where we are in the RichTextBox
                int textStart = lastMatch;                       // Store this so we can use it later

                // Create a new string by grabbing everything before the search text, the replacement text, and 
                // everything after the search text, and put it back in the RichTextBox
                string firstHalf = storyRichTextBox.Text.Substring(0, lastMatch);
                string lastHalf = storyRichTextBox.Text.Substring(lastMatch + storyRichTextBox.SelectionLength);
                storyRichTextBox.Text = firstHalf + replaceTextBox.Text + lastHalf;

                // Because the RichTextBox has changed, we lost the selected text - let's put that back
                storyRichTextBox.SelectionStart = textStart;
                storyRichTextBox.SelectionLength = replaceTextBox.Text.Length;
                storyRichTextBox.Focus();
                findTextBox.Text = findText;
                CheckState();
            }

            // We can't replace text if there's no selected text to replace
            else
            {
                MessageBox.Show($"There must be highlighted text.", "Replace Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CheckState();
            }
        }

        /// <summary>
        /// Replace all occurrences of the selected text in the RichTextBox.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void ReplaceAllButton_Click(object sender, EventArgs e)
        {
            // Store the last state of the selected text
            lastMatch = -1;
            string replaceText = replaceTextBox.Text;
            string findText = findTextBox.Text;

            // Keep looking for and replacing text until we run off the end of the RichTextBox
            int count = 0;
            while(lastMatch >= -1)
            {
                FindNextButton_Click(sender, e);

                // If we didn't find a match, then there's nothing to replace
                if (lastMatch == -1) break;

                ReplaceButton_Click(sender, e);
                findTextBox.Text = findText;
                count++;
            }

            // We kept track of how many times we replaced the text, so let's show that
            MessageBox.Show($"A total of {count} occurrences of \"{findText}\" were replaced with \"{replaceText}\"", "Replace All Text", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            CheckState();
        }

        /// <summary>
        /// When the Find Text TextBox changes Text, we may need to change the enabled state of the Buttons.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            lastMatch = storyRichTextBox.SelectionStart;   // This allows us to find the next occurrence after the one we're on
            CheckState();
        }

        /// <summary>
        /// When the Replace Text TextBox changes Text, we may need to change the enabled state of the Buttons.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void ReplaceTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckState();
        }

        /// <summary>
        /// With a RichTextBox, we can let the user select text directly, and have it copy over the the Find Text TextBox.
        /// Note: A standard TextBox doesn't have the SelectionChanged event, but a RichTextBox does.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void StoryRichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            findTextBox.Text = storyRichTextBox.Text.Substring(storyRichTextBox.SelectionStart, storyRichTextBox.SelectionLength);
        }

        /// <summary>
        /// A method that is called after every event to set the correct state of the Buttons.
        /// </summary>
        private void CheckState()
        {
            // We can only find text if we have search text
            if(findTextBox.Text != string.Empty)
                findButton.Enabled = true;
            else
                findButton.Enabled = false;

            // We can only find the next occurrence if we have selected text and we still have search text
            if (storyRichTextBox.SelectionLength != 0 && findTextBox.Text != string.Empty)
                findNextButton.Enabled = true;
            else
                findNextButton.Enabled = false;

            // We can only replace text if we have selected text and we still have replacement text
            if (storyRichTextBox.SelectionLength != 0 && replaceTextBox.Text != string.Empty)
            {
                replaceButton.Enabled = true;
                replaceAllButton.Enabled = true;
            }
            else
            {
                replaceButton.Enabled = false;
                replaceAllButton.Enabled = false;
            }
        }

    }
}
