using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
