using System;

namespace CovarianceContravariance2
{

    internal class Program
    {
        static void Setobject(object val1) {
            Console.WriteLine($"Inside SetObject + {val1}");
        }
        static void SetString(string val2) { }

        static void Main(string[] args)
        {
            Console.WriteLine("Contravariance delegates reverses the covariance functionality");
            Action<string> del1 = Setobject;
            del1("Hello");
           //Console.WriteLine();

        }
    }
}
