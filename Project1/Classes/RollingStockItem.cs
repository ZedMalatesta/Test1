using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public abstract class RollingStockItem
    {
        private int weightNativet;

        protected double _weightNativet { get; private set; }
        protected string _name { get; private set; }

        public RollingStockItem(int weightNativet, string name)
        {
            _weightNativet = weightNativet;
            _name = name;
        }

        public RollingStockItem(int weightNativet)
        {
            this.weightNativet = weightNativet;
        }

        public abstract double Weight();
        public abstract string Name();
    }
}
