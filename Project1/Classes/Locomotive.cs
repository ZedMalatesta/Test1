using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Classes
{
    public class Locomotive : RollingStockItem
    {
        public int _powerkW { get; private set; }

        public Locomotive(int weightNative, string name, int powerkW) 
            : base(weightNative, name)
        {
            _powerkW = powerkW;
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
