using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class RailroadItem
    {
        public int _weightNative { get; private set; }

        public RailroadItem(int weightNative)
        {
            _weightNative = weightNative;
        }
    }
}
