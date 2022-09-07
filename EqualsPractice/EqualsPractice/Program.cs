using System;

namespace EqualsPractice
{   public struct MyStruct
    {
        public int Id { get; set; }
        public string name { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equality in C#");
            Members MemberObj = new Members { Id = 1, Name = "Ronaldo", Address = "Portugal" };
            Members MemberObj1 = new Members { Id = 2, Name = "Ronaldino", Address = "Brazil" };
            Members MemberObj2 = new Members { Id = 1, Name = "Ronaldo", Address = "Portugal" };

            Console.WriteLine("Checking");

            Console.WriteLine(MemberObj2 == MemberObj);
            Console.WriteLine(MemberObj2.Equals( MemberObj));
            Console.WriteLine(System.Object.ReferenceEquals(MemberObj2,MemberObj));

            Console.WriteLine("Implementing value type using Structure >>>>");

            MyStruct myStruct1 = new MyStruct() { Id = 2, name = "Shubham" };
            MyStruct myStruct2 = new MyStruct() { Id = 2, name = "Shubham" };
            MyStruct myStruct = new MyStruct() { Id = 1, name = "Rohan" };

            //Console.WriteLine(myStruct1 == myStruct2);
            Console.WriteLine(myStruct1.Equals(myStruct2));
            Console.WriteLine(System.Object.ReferenceEquals(myStruct2, myStruct1));//always returns false

            Console.WriteLine("Using Compareto >>>>>>>>>>>>>>>");

            Console.WriteLine();





        }
    }
}
