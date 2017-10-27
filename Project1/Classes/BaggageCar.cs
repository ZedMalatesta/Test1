using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Interfaces;

namespace Project1.Classes
{
    public class BaggageCar : RollingStockItem, IFreightItem, INameItem
    {
        private double _freightCapacity;
        private double _freightWeight;
        private string _name;

        public BaggageCar(int weightNativet, string name, double freightCapacity, double freightWeight) 
            : base(weightNativet)
        {
            _freightCapacity = freightCapacity;
            _freightWeight = freightWeight;
            _name = name;
        }

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

        string INameItem.Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public override double Weight()
        {
            return _weightNativet;
        }
    }
}
