using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LabExercise11
{
    /// <summary>
    /// Class:  Ball
    /// Author: Nicholas J. Corkigian
    /// Date:   November 22, 2019
    /// 
    /// Purpose: This class encapsulates the physical attributes of a 2D Ball, 
    /// a method to draw the Ball and a way to calculate whether or not a point 
    /// is inside the Ball
    /// </summary>
    class Ball
    {
        public int X { get; private set; }                      // The ball's X-coordinate
        public int Y { get; private set; }                      // The ball's Y-coordinate
        public int Radius { get; private set; }                 // The ball's radius
        public Color BallColour { get; private set; }           // The ball's colour

        /// <summary>
        /// Creat an instance of a Ball.
        /// </summary>
        /// <param name="x1">The ball's X-coordinate</param>
        /// <param name="y1">The ball's Y-coordinate</param>
        /// <param name="radius">The ball's radius</param>
        /// <param name="color">The ball's colour</param>
        public Ball(int x1, int y1, int radius, Color color)
        {
            X = x1;
            Y = y1;
            Radius = radius;
            BallColour = color;
        }

        /// <summary>
        /// Draw the Ball on the screen.
        /// </summary>
        /// <param name="g">A graphics object</param>
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(BallColour);
            g.FillEllipse(b, X, Y, Radius * 2, Radius * 2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The X-coordinate of where the mouse clicked</param>
        /// <param name="y">The Y-coordinate of where the mouse clicked</param>
        /// <returns>A boolean value that indicates whether the Ball was successfuly clicked, or not</returns>
        public Boolean PointInBall(int x, int y)
        {
            // Determine the centre of the Ball
            double cx = X + Radius;
            double cy = Y + Radius;

            // Find the distance from the click point to the centre of the Ball
            double distance = Math.Sqrt(Math.Pow((cx - x), 2) + Math.Pow((cy - y), 2));

            // If the distance is within the radius, then the Ball was clicked on
            return distance <= Radius;
        }
    }
}
