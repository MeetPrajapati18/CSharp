using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonTrip
{
    /// <summary>
    /// Class:  AstronautTrip
    /// Author: Nicholas J. Corkigian
    /// Date:   October 10, 2019
    /// 
    /// Purpose: This class models an astronaut's trip to the Moon.
    ///          We implement IComparable so that we can change the 
    ///          default sort behaviour.
    /// </summary>
    public class AstronautTrip : IComparable<AstronautTrip>
    {
        public String Name { get; }                      // Astronaut's name
        public DateTime Depart { get; }                  // Astronaut's departure time
        public DateTime Arrive { get; }                  // Astronaut's arrivale time

        /// <summary>
        /// AstronautTrip Constructor creates the trip entry.
        /// Arrival time takes 3 days, 8 hours, and 30 minutes.
        /// </summary>
        /// <param name="name">Astronaut's name</param>
        /// <param name="depart">Trip departure time</param>
        public AstronautTrip(String name, DateTime depart)
        {
            Name = name;
            Depart = depart;
            Arrive = Depart.AddDays(3).AddHours(8).AddMinutes(30);
        }

        /// <summary>
        /// This method allows us to check if two AstronautTrip objects are equal. 
        /// They are equal if they have the same departure time.
        /// </summary>
        /// <param name="other">An object to compare to</param>
        /// <returns>True if the departure times are the same</returns>
        public override bool Equals(object other)
        {
            if(other != null && other is AstronautTrip)
            {
                AstronautTrip otherAstronautTrip = (AstronautTrip)other;
                if (this.Depart == otherAstronautTrip.Depart)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Standard way to represent the AstronautTrip as a String.
        /// </summary>
        /// <returns>String represntation fo the object</returns>
        public override string ToString()
        {
            return $"[{Name} will be traveling from {Depart} to {Arrive}]";
        }

        #region IComparable

        /// <summary>
        /// This method determines how we compare on AstronautTrip object to another.
        /// This is require by IComparable to allow sorting on this field.
        /// </summary>
        /// <param name="rhs">The other AstronautTrip object</param>
        /// <returns>An positive integer if this object is greater than the other object. Negative integer if the reverse.</returns>
        public int CompareTo(AstronautTrip rhs)
        {
            return this.Depart.CompareTo(rhs.Depart);
        }

        #endregion
    }
}
