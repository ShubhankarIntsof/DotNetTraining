using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerAndDser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            //Tutorial obj = new Tutorial();
            //obj.ID = 2;
            //obj.Name = "ASP.NET MVC";

            //IFormatter formatter = new BinaryFormatter();

            //Stream stream = new FileStream("C:\\Users\\Shubhankar Shubham\\source\\repos\\SerAndDser\\SerAndDser\\TextFile1.txt", FileMode.Open, FileAccess.Write);
            ////Serializing the object  

            //formatter.Serialize(stream, obj);

            //Console.WriteLine(" Objects has been serialized...!!!");
            //stream.Close();


            //IFormatter eformatter = new BinaryFormatter();

            //Stream stream1 = new FileStream("C:\\Users\\Shubhankar Shubham\\source\\repos\\SerAndDser\\SerAndDser\\TextFile1.txt", FileMode.Open, FileAccess.Read);

            //Tutorial ObjNew = (Tutorial)eformatter.Deserialize(stream1);

            //Console.WriteLine("Data After deserialization is like ");
            //Console.WriteLine(ObjNew.ID);
            //Console.WriteLine(ObjNew.Name);

            //stream1.Close();

        }
    }
}
