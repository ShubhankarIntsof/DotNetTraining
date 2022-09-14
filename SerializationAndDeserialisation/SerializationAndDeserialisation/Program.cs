using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationAndDeserialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            Tutorial obj = new Tutorial();

            obj.ID = 1;

            obj.Name = "ASP.NET MVC";



            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream("C:\\Users\\dell\\source\\repos\\.NET for _ Intersoft_30_Aug\\Day 9\\Demo_Serialization_Desrialization\\Demo_Serialization_Desrialization\\demo3.txt", FileMode.OpenOrCreate, FileAccess.Write);





            //Serializing the object  

            formatter.Serialize(stream, obj);



            Console.WriteLine(" Objects has been serialized...!!!");



            Stream stream1 = new FileStream("C:\\Users\\dell\\source\\repos\\.NET for _ Intersoft_30_Aug\\Day 9\\Demo_Serialization_Desrialization\\Demo_Serialization_Desrialization\\demo3.txt", FileMode.Open, FileAccess.Read);



            Tutorial ObjNew = (Tutorial)formatter.Deserialize(stream1);

            Console.WriteLine("Data After deserialization is like ");

            Console.WriteLine(ObjNew.ID);

            Console.WriteLine(ObjNew.Name);

            stream.Close();

        }
    }
}
