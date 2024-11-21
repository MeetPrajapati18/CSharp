using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercise10
{
    /// <summary>
    /// Program: LabExercise10 (Sorting)
    /// Author: Nicholas J. Corkigian
    /// Date:   November 14, 2019
    /// 
    /// Purpose: Student class stores the first and last names
    ///          of a student, as well as their two grade values.
    /// </summary>

    class Student
    {
        /// <summary>
        /// Student's first name - read only.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// Student's last name - read only.
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// Student's first grade - read only.
        /// </summary>
        public double Grade1 { get; }

        /// <summary>
        /// Student's second grade - read only.
        /// </summary>
        public double Grade2 { get; }

        /// <summary>
        /// Student's average grade for both component grades - read only.
        /// </summary>
        public double Average
        {
            get
            {
                return (Grade1 + Grade2) / 2;
            }
        }

        /// <summary>
        /// The constructor just sets the object's data - no validation done.
        /// </summary>
        /// <param name="firstName">First name of student</param>
        /// <param name="lastName">Last name of student</param>
        /// <param name="grade1">First grade of student</param>
        /// <param name="grade2">Second grade of student</param>
        public Student(string firstName, string lastName, double grade1, double grade2)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade1 = grade1;
            Grade2 = grade2;
        }

        /// <summary>
        /// String representation of the student - formatted for the ListBox.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format($"{LastName,-12}{FirstName,-12}{Grade1,8}{Grade2,8}{Average,8:0.00}");
        }
    }
}
