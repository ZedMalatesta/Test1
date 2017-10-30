using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Interfaces;

namespace Project1.Classes
{
    public class PassengerCar : RollingStockItem, IPassengerItem, IWeightItem
    {
        public PassengerCar(double weightNative, string name, int allSeatsNumber, int occupiedSeatsNumber, QualityType quality)
        {
                WeightNative = weightNative;
                AllSeatsNumber = allSeatsNumber;
                OccupiedSeatsNumber = occupiedSeatsNumber;
                Quality = quality;
                Name = name;
        }

        public int AllSeatsNumber
        {
            get;
            private set;
        }

        public int OccupiedSeatsNumber
        {
            get;
            set;
        }

        public string Name
        {
            get;
            private set;
        }

        public QualityType Quality
        {
            get;
            private set;
        }

        public double WeightNative
        {
            get;
            private set;
        }

        public override double Weight()
        {
            return WeightNative;
        }

        public void ChangeOccupiedSeatsNumber(int value)
        {
            if (OccupiedSeatsNumberValidation(value)) OccupiedSeatsNumber = value;
        }

        public bool OccupiedSeatsNumberValidation(int value)
        {
            try
            {
                if (value < 0)
                {
                    throw new System.ArgumentException("Parameter cannot be negative");
                }
                if (value > AllSeatsNumber)
                {
                    throw new System.ArgumentException("Occupied seats number cannot be less than all seats number");
                }
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        public override string ToString()
        {
            return Name + "; seats = " + AllSeatsNumber + "; occupied = " + OccupiedSeatsNumber + " weight = " + WeightNative + "; quality = " + Quality;
        }
    }
}
