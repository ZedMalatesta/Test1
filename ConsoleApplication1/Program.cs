using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Classes;
using Project1.Interfaces;
using Project1;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            BaggageCarSequence BCS = new BaggageCarSequence(0, "1");
            BCS.Add(new BaggageCar(5, "KX-21", 2, 1));
            BCS.Add(new BaggageCar(5, "KX-22", 2, 1.4));
            BCS.Add(new BaggageCar(5, "KX-23", 2, 1.7));
            PassengerCarSequence PCS = new PassengerCarSequence(0, "1");
            PCS.Add(new PassengerCar(3, "UO-12", 54, 25, Project1.QualityType.Standart));
            PCS.Add(new PassengerCar(3, "UO-13", 54, 27, Project1.QualityType.Econom));
            PCS.Add(new PassengerCar(3, "UO-16", 54, 12, Project1.QualityType.Luxury));
            PCS.Add(new PassengerCar(3, "UO-18", 54, 30, Project1.QualityType.Standart));
            Locomotive Loco = new Locomotive(6, "PPH", 1200);
            PassengerTrain PT = new PassengerTrain(0, "Illya Muromets", Loco, BCS, PCS);
            Console.WriteLine(PT.Weight());
            Console.WriteLine(PT.AllSeatsNumber);
            Console.WriteLine(PT.OccupiedSeatsNumber);
            Console.WriteLine(PT.FreightCapacity);
            Console.WriteLine(PT.FreightWeight);
            PT.Sort();
            foreach (PassengerCar obj in PT.PC())
            {
                Console.WriteLine(obj.Name());
            }
            IEnumerable<PassengerCar> cars = PT.SearchForPassengerNumber(27);
            foreach (PassengerCar obj in cars)
            {
                Console.WriteLine(obj.Name());
            }
            IEnumerable<IPassengerItem> cars2 = PT.SearchForPassengerNumber(20, 28);
            foreach (PassengerCar obj in cars2)
            {
                Console.WriteLine(obj.Name());
            }
            Console.ReadLine();
        }
    }
}
