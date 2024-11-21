using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercise03
{
    public class Car
    {
        private String make;
        private String model;
        private double fuel;
        private double mileage;

        public Car(String make, String model, Double fuel, Double mileage)
        {
            this.make = make;
            this.model = model;
            this.fuel = fuel;
            this.mileage = mileage;
        }

        public String GetMake()
        {
            return make;
        }

        public String GetModel()
        {
            return model;
        }

        public double CalculateFuelEfficiency()
        {
            return fuel / mileage * 100;
        }

        public override String ToString()
        {
            return String.Format($"[{make},{model},Fuel Used={fuel} Distance={mileage} Mileage = {CalculateFuelEfficiency():F}]");
        }
    }
}
