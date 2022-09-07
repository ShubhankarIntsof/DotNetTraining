using abstract_class;
using System;

namespace AbstractSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog mydog = new Dog();
            mydog.speak();

            IDomesticAnimal mydogAnimal = mydog;
            mydogAnimal.No_of_Kids = 1;


            

        }

    }
}
