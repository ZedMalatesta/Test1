using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    abstract class Train : RailroadItem
    {
        public Locomotive _head { get; private set; }
        public ICollection<RailroadCar> TrainComposition { get; private set; }

        public Train(int weightNative) 
            : base(weightNative)
        {
        }
    }
}
