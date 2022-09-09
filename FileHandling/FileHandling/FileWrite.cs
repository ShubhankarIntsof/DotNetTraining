using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class FileWrite
    {
        public void WriteData()
        {
            //Step 1: Creating Object of FileStream for Writing
            //Step 2: Creating the object of stream Writer and passing filestream object as parameter
            //Step 3: Asking user for the text message
            //Step 4: Closing Stream Writer and File Stream
            //string path = "C:\\Users\\Shubhankar Shubham\\source\repos\\FileHandling\\FileHandling\\myDetails.txt";
            FileStream fs = new FileStream("C:\\Users\\Shubhankar Shubham\\source\\repos\\" +
                "FileHandling\\FileHandling\\myDetails.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            Console.WriteLine("Enter the Text");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();


        }
        public void ReadData()
        {
            FileStream fs = new FileStream("C:\\Users\\Shubhankar Shubham\\source\\" +
                "repos\\FileHandling\\FileHandling\\myDetails" +
                ".txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadLine();
            Console.WriteLine(str);
            
            sr.Close();
            fs.Close();
            

        }
    }
}
