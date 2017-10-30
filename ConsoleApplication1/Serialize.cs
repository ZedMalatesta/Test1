using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Project1.Classes;
using Project1.Interfaces;
using Project1;

namespace ConsoleApplication
{
    static class JsonSerialize
    {
        static public void SerializationEmployee(IEnumerable<INameItem> obj, string name)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };
            string serialized = JsonConvert.SerializeObject(obj, settings);

            StreamWriter streamWriter = new StreamWriter("Sourse"+name+".txt");
            using (streamWriter)
            {
                streamWriter.WriteLine(serialized);
            }
        }
        static public void SerializationEmployeeOne(INameItem obj, string name)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };
            string serialized = JsonConvert.SerializeObject(obj, settings);

            StreamWriter streamWriter = new StreamWriter("Sourse" + name + ".txt");
            using (streamWriter)
            {
                streamWriter.WriteLine(serialized);
            }
        }

        static public IEnumerable<BaggageCar> DeserializationBaggageCar()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };

            string fileContents;
            StreamReader streamReader = new StreamReader("SourseBaggage.txt");
            using (streamReader)
            {
                fileContents = streamReader.ReadToEnd();
            }

            IEnumerable<BaggageCar> trainelements = JsonConvert.DeserializeObject<IEnumerable<BaggageCar>>(fileContents, settings);
            return trainelements;
        }
        static public IEnumerable<PassengerCar> DeserializationPassengerCar()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };

            string fileContents;
            StreamReader streamReader = new StreamReader("SoursePassenger.txt");
            using (streamReader)
            {
                fileContents = streamReader.ReadToEnd();
            }

            IEnumerable<PassengerCar> trainelements = JsonConvert.DeserializeObject<IEnumerable<PassengerCar>>(fileContents, settings);
            return trainelements;
        }
        static public Locomotive DeserializationLocomotive()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };

            string fileContents;
            StreamReader streamReader = new StreamReader("SourseLocomotive.txt");
            using (streamReader)
            {
                fileContents = streamReader.ReadToEnd();
            }
            Locomotive element = JsonConvert.DeserializeObject<Locomotive>(fileContents, settings);
            return element;
        }

    }
}
