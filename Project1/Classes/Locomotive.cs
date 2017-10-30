using Project1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project1.Classes
{
    public class Locomotive : RollingStockItem, IWeightItem
    {
        public int PowerkW { get; private set; }

        public Locomotive(double weightNative, string name, int powerkW) 
        {
            Name = name;
            PowerkW = powerkW;
            WeightNative = weightNative;

        }

        public override double Weight()
        {
            return WeightNative;
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

        public override string ToString()
        {
            return Name + "; weight = " + WeightNative + "; power = " + PowerkW + "kW";
        }
    }
}
