using Project1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Classes
{
    public class Locomotive : RollingStockItem, INameItem
    {
        private int _powerkW { get; set; }
        private string _name { get; set; }

        public Locomotive(int weightNative, string name, int powerkW) 
            : base(weightNative)
        {
            _name = name;
            _powerkW = powerkW;
        }

        public override double Weight()
        {
            return _weightNativet;
        }

        public string Name
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
    }
}
