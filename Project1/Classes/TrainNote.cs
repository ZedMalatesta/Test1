using Project1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Classes
{
    class TrainNote : IExplotationInf
    {
        private DateTime _startOfExplotation;
        private int _yearsInExplotation;
        private Train _train;

        public DateTime StartOfExplotation
        {
            get
            {
                return _startOfExplotation;
            }
        }

        public int YearsInExplotation
        {
            get
            {
                return _yearsInExplotation;
            }
        }

        public Train train
        {
            get
            {
                return _train;
            }
        }

        public override string ToString()
        {
            return _startOfExplotation.ToString() + " " + _yearsInExplotation.ToString() + " " + _train.ToString();
        }
    }
}
