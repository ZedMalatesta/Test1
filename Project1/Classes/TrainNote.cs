using Project1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Classes
{
    public class TrainNote : IExplotationInf
    {
        public TrainNote(DateTime startOfExplotation, int yearsInExplotation, Train train) 
        {
            StartOfExplotation = startOfExplotation;
            YearsInExplotation = yearsInExplotation;
            TrainOb = train;
        }

        public DateTime StartOfExplotation
        {
            get;
            private set;
        }

        public int YearsInExplotation
        {
            get;
            private set;
        }

        public Train TrainOb
        {
            get;
            private set;
        }

        public override string ToString()
        {
            return StartOfExplotation.ToString() + " " + YearsInExplotation.ToString() + " " + TrainOb.ToString();
        }
    }
}
