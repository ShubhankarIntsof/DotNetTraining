﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace abstract_class

{
    interface IDomesticAnimal
    {
        public string Colortype();

        void color();
        void NoOflegs();
        void Age();
        void Food_Type();
        public int No_of_Kids { get; set; }

    }

    abstract class Animal
    {
        public abstract void speak();
        public void Animallanguage()
        {
            Console.WriteLine("ZZZZZ...ZZZZ....ZZZZ.ZZ");

        }
        public void Animallanguage1()
        {
            Console.WriteLine("ZZZZZ...ZZZZ....ZZZZ.ZZ");

        }
    }

    class Dog : Animal, IDomesticAnimal
    {
        int IDomesticAnimal.No_of_Kids { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void speak()
        {
            Console.WriteLine("The Dog Says : Woof WOof....");
            //throw new NotImplementedException();
        }

        void IDomesticAnimal.Age()
        {
            throw new NotImplementedException();
        }

        void IDomesticAnimal.color()
        {
            throw new NotImplementedException();
        }

        string IDomesticAnimal.Colortype()
        {
            throw new NotImplementedException();
        }

        void IDomesticAnimal.Food_Type()
        {
            throw new NotImplementedException();
        }

        void IDomesticAnimal.NoOflegs()
        {
            throw new NotImplementedException();
        }
    }

    class Cat : Animal
    {
        public override void speak()
        {
            Console.WriteLine("The Cat Says : Meow Meow....");
            //throw new NotImplementedException();
        }
    }
}
