using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Tutorial obj = new Tutorial();
            obj.ID = 2;
            obj.name = "ASP .NET MVC";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("C:\\Users\\Shubhankar Shubham\\source" +
                "\\repos\\SerializationAndDeserialization\\SerializationAndDeserialization" +
                "\\text.txt", FileMode.Open, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();
            Console.WriteLine("Serialisation Done");
            Console.WriteLine("-------------------------------------------------");

            FileStream stream1 = new FileStream("C:\\Users\\Shubhankar Shubham\\source" +
                "\\repos\\SerializationAndDeserialization\\SerializationAndDeserialization" +
                "\\text.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter1 = new BinaryFormatter();

            Tutorial t = (Tutorial)formatter1.Deserialize(stream1);
            Console.WriteLine("Rollno: " + t.ID);
            Console.WriteLine("Name: " + t.name);

            stream1.Close();
            Console.ReadLine();



        }
    }
}
