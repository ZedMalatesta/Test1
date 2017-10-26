using Project1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public abstract class Train : RollingStockItem
    { 
         protected Train(int weightNative, string name) 
            : base(weightNative, name)
        {
        }
        public override string Name()
        {
            return _name;
        }
    }
}
