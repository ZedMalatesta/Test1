using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Locomotive : RailroadItem
    {
        public int _powerkW { get; private set; }

        public Locomotive(int weightNative, int powerkW) 
            : base(weightNative)
        {
            _powerkW = powerkW;
        }
    }
}
