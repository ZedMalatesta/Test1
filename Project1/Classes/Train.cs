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

        public Train (Locomotive head) 
        {
            _head = head;
        }

        public abstract Locomotive Head();
        public abstract void ChangeHead(Locomotive value);
        public abstract double TractionForce();
        public abstract bool TractionForceTest();
    }
}
