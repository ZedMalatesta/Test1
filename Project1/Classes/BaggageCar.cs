using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Interfaces;

namespace Project1.Classes
{
    public class BaggageCar : RollingStockItem, IWeightItem, IFreightItem
    {

        public BaggageCar(double weightNative, string name, double freightCapacity, double freightWeight) 
        {
            FreightCapacity = freightCapacity;
            FreightWeight = freightWeight;
            Name = name;
            WeightNative = weightNative;
        }

        public double FreightCapacity
        {
            get;
            private set;
        }

        public double FreightWeight
        {
            get;
            private set;
        }

        public string Name
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

        public void ChangeFreightWeight(double value)
        {
            if (FreightWeightValidation(value)) FreightWeight = value;
        }

        public bool FreightWeightValidation(double value)
        {
            try
            {
                if (value < 0)
                {
                    throw new System.ArgumentException("Parameter cannot be negative");
                }
                if (value > FreightCapacity)
                {
                    throw new System.ArgumentException("Freight weight cannot be less than r");
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
            return Name + "; native weight = " + WeightNative + "; capacity = " + FreightCapacity + "; freight weight = " + FreightWeight;
        }

    }
}
