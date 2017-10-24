using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Interfaces;

namespace Project1
{
    class FreightTrain : Train, IFreightItem
    {
        public FreightTrain(int weightNative) 
            : base(weightNative)
        {
        }

        public double Weight
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
