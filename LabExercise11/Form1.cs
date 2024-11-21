using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LabExercise11
{
    /// <summary>
    /// Program: LabExercise11 (Let's Play A Game)
    /// Author: Nicholas J. Corkigian
    /// Date:   November 22, 2019
    /// 
    /// Purpose: Create a simple game where each round the user clicks 
    ///          on drawn balls to remove them from the screen.
    ///          The game ends when the user has not cleared all the
    ///          balls off the screen before the 5-second timer expires.
    ///          
    /// </summary>

    public partial class Form1 : Form
    {
        private List<Ball> ballList;             // List of ball objects
        private int numberOfBalls = 0;           // Current ball count and round number
        private Random rnd = new Random();       // Used for random number generation

        /// <summary>
        /// Create the list of balls
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            ballList = new List<Ball>();

            // Load the Top Scores from the saved file, if it exists
            if (File.Exists("scores.dat"))
            {
                using (Stream stream = File.Open("scores.dat", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    List<Score> scores = (List<Score>)bin.Deserialize(stream);

                    // Copy each item in the list over to the listbox
                    foreach (Score s in scores)
                        scoresListBox.Items.Add(s);
                }
            }
        }

        /// <summary>
        /// Clicking the start button sets the initial state of a new game.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (startButton.Enabled)
            {
                // Disable controls that should not be accessed during the game
                startButton.Enabled = false;
                playerTextBox.Enabled = false;
                mouseGroupBox.Enabled = false;

                // Set the start of game values
                numberOfBalls = 0;
                countdownLabel.Text = "5";
                ballList.Clear();

                // Turn on the timers
                gameTimer.Enabled = true;
                countdownTimer.Enabled = true;
                countdownLabel.Visible = true;

                GameTimer_Tick(null, null);
            }
        }

        /// <summary>
        /// Whenever the game timer goes off, look to see if the game has been 
        /// lost.  If so, reset the initial conditions.  If not, then generate
        /// a new round of balls.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Check for end condition
            if (ballList.Count > 0 && numberOfBalls > 0)
            {
                // End of Game
                // Turn the timers off
                gameTimer.Enabled = false;
                countdownTimer.Enabled = false;
                countdownLabel.Visible = false;

                // Reset the initial start of game states
                countdownLabel.Text = "5";

                // Turn disabled controls back on
                startButton.Enabled = true;
                playerTextBox.Enabled = true;
                mouseGroupBox.Enabled = true;

                // Put up a message that Game is Over and tell them how 
                // many rounds they have completed
                MessageBox.Show($"You completed {numberOfBalls - 1} round{(numberOfBalls - 1 == 1 ? "" : "s")}, but the game is over!",
                                "Game Over Man", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Update the Top Scores box
                AddNewScore(new Score(playerTextBox.Text, numberOfBalls - 1, DateTime.Now));

                // Set focus back to the start button
                startButton.Focus();
            }

            // If the round was cleared...
            else
            {
                // Increment the number of balls for the next round
                numberOfBalls++;
                roundLabel.Text = $"Round {numberOfBalls}";

                // This will generate a Random set of Balls and put them into a List
                for (int i = 0; i < numberOfBalls; i++)
                {
                    int radius = rnd.Next(20, 50);
                    int x = rnd.Next(radius * 2, drawingPanel.Width - radius * 4);
                    int y = rnd.Next(radius * 2, drawingPanel.Height - radius * 4);
                    int red = rnd.Next(100, 255);
                    int green = rnd.Next(100, 255);
                    int blue = rnd.Next(100, 255);
                    ballList.Add(new Ball(x, y, radius, Color.FromArgb(red, green, blue)));
                }

                // Create a graphics object
                Graphics g = drawingPanel.CreateGraphics();

                // Add code to draw all of the Balls in the list to the screen
                g.Clear(Color.Black);
                foreach (Ball b in ballList)
                    b.Draw(g);

                g.Dispose();
            }
        }

        /// <summary>
        /// This countdown timer just updates the countdown clock.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            // Once the countdown runs out, reset back and update the label
            if (countdownLabel.Text == "1")
                countdownLabel.Text = "6";

            countdownLabel.Text = (Convert.ToInt32(countdownLabel.Text) - 1).ToString();
        }

        /// <summary>
        /// This method updates the Top Scores box.  Only the top five highest
        /// scores are kept.
        /// </summary>
        /// <param name="score">The score that may be added to the list</param>
        private void AddNewScore(Score score)
        {
            // Create an array that is one score larger than what's in the listbox
            Score[] topScores = new Score[scoresListBox.Items.Count + 1];

            // Copy the contents of the listbox to the array and add in the last score
            scoresListBox.Items.CopyTo(topScores, 0);
            topScores[scoresListBox.Items.Count] = score;

            // Sort the array (see the Score class for how scores are sorted)
            Array.Sort(topScores);

            // Wipe out the Top Scores listbox and copy the top 5 newly sorted
            // scores back to it
            scoresListBox.Items.Clear();
            for (int i = 0; i < Math.Min(topScores.Length, 5); i++)
                scoresListBox.Items.Add(topScores[i]);

            // Highlight the score that was just added
            scoresListBox.SelectedIndex = scoresListBox.Items.IndexOf(score);
        }

        /// <summary>
        /// Remove balls if the user clicks on them.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void DrawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            // If we're not looking for mouse clicks, get out of here
            if (!mouseClickRadioButton.Checked)
                return;

            // Otherwise get rid of the ball clicked on
            else
                RemoveBall(sender, e);
        }

        /// <summary>
        /// Remove balls if the user moves over them.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            // If we're not looking for mouse move overs, get out of here 
            if (!mouseMoveRadioButton.Checked)
                return;

            // Otherwise get rid of the ball moved over
            else
                RemoveBall(sender, e);
        }

        /// <summary>
        /// Remove a ball from the list and then redraw the screen.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void RemoveBall(object sender, MouseEventArgs e)
        {
            // Avoid re-drawing the screen if we didn't get a ball
            bool hit = false;

            if (gameTimer.Enabled)
            {
                // Check if we moved over a Ball
                // do this by iterating through list of balls and check using the PointInBall method
                // if (e,X, e.Y) is inside the Ball, remove from List and then
                // clear the objects and redraw the remaining objects on screen.

                foreach (Ball b in ballList)
                    if (b.PointInBall(e.X, e.Y))
                    {
                        ballList.Remove(b);
                        hit = true;
                        break;
                    }

                // Only re-draw the screen if we got a hit
                if (hit)
                {
                    Graphics g = drawingPanel.CreateGraphics(); //Create a graphics object

                    // Add code to draw all of the Balls in the list to the screen
                    g.Clear(Color.Black);
                    foreach (Ball b in ballList)
                        b.Draw(g);

                    g.Dispose();
                }
            }
        }

        /// <summary>
        /// Save the Top Scores when the program exits.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save the Top Scores to a file using serialization
            using (Stream stream = File.Open("scores.dat", FileMode.Create))
            {
                // Copy the listbox items to a list
                List<Score> scores = new List<Score>();
                foreach (Score s in scoresListBox.Items)
                    scores.Add(s);

                // Write the list to a file
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, scores);
            }
        }
    }
}
