using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public abstract class RollingStockItem
    {
        protected double _weightNativet;

        public RollingStockItem(int weightNativet)
        {
            _weightNativet = weightNativet;
        }

        public abstract double Weight();
    }
}
