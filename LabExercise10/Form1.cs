using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExercise10
{
    /// <summary>
    /// Program: LabExercise10 (Sorting)
    /// Author: Nicholas J. Corkigian
    /// Date:   November 14, 2019
    /// 
    /// Purpose: Demonstrate using Lambda expressions to override the
    ///          sort Comparer on a list of customized objects.
    ///          
    /// Note:    Implementing the Challenge is a non-trivial task.
    /// 
    ///          A standard List<T> collection does not raise any events
    ///          for observers to know when to update. So binding the
    ///          ListBox's DataSource to the List<T> doesn't update
    ///          the contents automatically.
    ///          
    ///          The suggestion is to instead use a BindingList<T> which
    ///          in theory will raise an event when the contents have
    ///          changed. However, BindingList<T> does not support a
    ///          Sort() method.
    ///          
    ///          The solution is to use both a List<T> and a BindingList<T>.
    ///          The List<T> is passed into the constructor of the
    ///          BindingList<T>, which asks as a backing variable for it.
    ///          The List<T> can support the Sort() functionality, while
    ///          the BackingList<T> can raise events when the data changes.
    ///          However, to get the two to operate together, the backing list
    ///          will need to have its ResetBindings() method manually
    ///          triggered to inform it that the underlying data has changed.
    ///          
    ///          It's my opinion that the Challenge is less useful or intuitive
    ///          than simply using the populateList() method.
    /// </summary>
    public partial class Form1 : Form
    {
        private readonly List<Student> students;                     // Used for its Sort() functionality
        private BindingList<Student> backingList;                    // Used to store the actual Student information

        /// <summary>
        /// The form's constructor creates the data structure and populates
        /// it with data.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            students = new List<Student>();
            backingList = new BindingList<Student>(students)
            {
                new Student("Joe", "Smith", 75, 87),
                new Student("Joanne", "Smith", 75, 88),
                new Student("Harsh", "Patel", 55, 91),
                new Student("Mitel", "Patel", 82, 66),
                new Student("Ishwar", "Patel", 91, 93),
                new Student("Amy", "Nguyen", 91, 65)
            };

            studentListBox.DataSource = backingList;
            populateList();
        }

        /// <summary>
        /// This method will clear the old contents of the ListBox and
        /// add the current contents of the List<T> back into it.
        /// This method is mostly redundant with the imlementation of the
        /// Challenge, however we still require the manual triggering of
        /// ResetBindings() as well as de-selecting the ListBox.
        /// </summary>
        private void populateList()
        {
            //studentListBox.Items.Clear();
            //foreach (Student s in students)
            //    studentListBox.Items.Add(s);

            backingList.ResetBindings();
            studentListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Sort by Last Name using a Lambda expression and calling the
        /// CompareTo() method of the string class.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void LastNameButton_Click(object sender, EventArgs e)
        {
            students.Sort((s1, s2) => s1.LastName.CompareTo(s2.LastName));
            populateList();
        }

        /// <summary>
        /// Sort by Grade 1 using a Lambda expression and calling the
        /// CompareTo() method of the double class.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void Grade1Button_Click(object sender, EventArgs e)
        {
            students.Sort((s1, s2) => s1.Grade1.CompareTo(s2.Grade1));
            populateList();
        }

        /// <summary>
        /// Sort by Grade 2 using a Lambda expression and calling the
        /// CompareTo() method of the double class.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void Grade2Button_Click(object sender, EventArgs e)
        {
            students.Sort((s1, s2) => s1.Grade2.CompareTo(s2.Grade2));
            populateList();
        }

        /// <summary>
        /// Sort by Average using a Lambda expression and calling the
        /// CompareTo() method of the double class.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void AverageButton_Click(object sender, EventArgs e)
        {
            students.Sort((s1, s2) => s1.Average.CompareTo(s2.Average));
            populateList();
        }

        /// <summary>
        /// Sort first by Grade 1 and then by Grade 2 using Lambda expressions.
        /// If the grades being compared are different, then use the same process
        /// as was done for the Grade1 sort. However, if the two grades are
        /// the same, then use the same process as was done for the Grade 2 sort.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void CompositeButton_Click(object sender, EventArgs e)
        {
            students.Sort((s1, s2) => 
            {
                // Same Grade 1 values requires a secondary sort for the Grade 2 values
                if (s1.Grade1 == s2.Grade1)
                    return s1.Grade2.CompareTo(s2.Grade2);

                // Otherwise use the Grade 1 sort
                else
                    return s1.Grade1.CompareTo(s2.Grade1);
            });
            populateList();
        }
    }
}
