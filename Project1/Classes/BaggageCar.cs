using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Interfaces;

namespace Project1.Classes
{
    public class BaggageCar : RollingStockItem, IFreightItem
    {
        public BaggageCar(int weightNativet, string name, double freightCapacity, double freightWeight) 
            : base(weightNativet, name)
        {
            _freightCapacity = freightCapacity;
            _freightWeight = freightWeight;
        }

        private double _freightCapacity { get; set; }
        private double _freightWeight { get; set;  }

        public double FreightCapacity
        {
            get
            {
                return _freightCapacity;
            }
        }

        public double FreightWeight
        {
            get
            {
                return _freightWeight;
            }
        }

        public override double Weight()
        {
            return _weightNativet;
        }

        public override string Name()
        {
            return _name;
        }
    }
}
