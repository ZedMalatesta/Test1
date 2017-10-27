using Project1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project1.Classes
{
    public abstract class Train : RollingStockItem
    {
        protected Locomotive _head;

        public Train(int weightNative, Locomotive head) 
            : base(weightNative)
        {
            _head = head;
        }

        public abstract Locomotive Head();

    }
}
