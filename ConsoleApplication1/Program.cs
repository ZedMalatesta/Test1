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
            //Инициализируем параметры класса PassengerTrain
            BaggageCarSequence bcs = new BaggageCarSequence((JsonSerialize.DeserializationBaggageCar()).ToList());
            PassengerCarSequence pcs = new PassengerCarSequence((JsonSerialize.DeserializationPassengerCar()).ToList());
            Locomotive Loco = JsonSerialize.DeserializationLocomotive();

            //Создаем объект типа PassengerTrain
            PassengerTrain PT = new PassengerTrain("ТЭГК95", Loco, bcs, pcs);

            //Выводим информацию об объектах поезда на консоль
            foreach (string obj in PT.Notation())
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("___________________________________________________");

            Console.WriteLine("Суммарны вес поезда = " + PT.Weight());
            Console.WriteLine("Количество багажа = " + PT.FreightWeight);
            Console.WriteLine("Количество пасажиров = " + PT.OccupiedSeatsNumber);

            //Проводим сортировку и снова выводим информацию об объектах поезда на консоль
            IEnumerable<IPassengerItem> OP = PT.Sort();
            foreach (IPassengerItem obj in OP)
            {
                Console.WriteLine(obj.ToString());
            }

            //Выполняем поиск вагонов по заданным максималным и минимальным значениям
            IEnumerable<IPassengerItem> cars = PT.SearchForPassengerNumber(27);
            Console.WriteLine("Вагоны подходящие под заданное значение = ");
            foreach (IPassengerItem obj in cars)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("Вагоны подходящие под заданный диапазон = ");
            IEnumerable<IPassengerItem> cars2 = PT.SearchForPassengerNumber(20, 28);
            foreach (IPassengerItem obj in cars2)
            {
                Console.WriteLine(obj.ToString());
            }
            
            Console.ReadLine();
        }
    }
}
