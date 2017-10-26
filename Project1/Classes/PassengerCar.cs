using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Interfaces;

namespace Project1.Classes
{
    public class PassengerCar : RollingStockItem, IPassengerItem, IComparable<PassengerCar>
    {
        private int _allSeatsNumber { get; set; }
        private int _occupiedSeatsNumber { get; set; }
        private QualityType _quality { get; set; }

        public PassengerCar(int weightNativet, string name, int allSeatsNumber, int occupiedSeatsNumber, QualityType quality)
            : base(weightNativet, name)
        {
            _allSeatsNumber = allSeatsNumber;
            _occupiedSeatsNumber = occupiedSeatsNumber;
            _quality = quality;
        }

        public int AllSeatsNumber
        {
            get
            {
                return _allSeatsNumber;
            }
        }

        public int OccupiedSeatsNumber
        {
            get
            {
                return _occupiedSeatsNumber;
            }
        }

        public override double Weight()
        {
            return _weightNativet;
        }

        public override string Name()
        {
            return _name;
        }

        public QualityType Quality()
        {
            return _quality;
        }

        public int CompareTo(PassengerCar other)
        {
            if (this.Quality() > other.Quality())
                return 1;
            if (this.Quality() < other.Quality())
                return -1;
            else
                return 0;
        }
    }
}
