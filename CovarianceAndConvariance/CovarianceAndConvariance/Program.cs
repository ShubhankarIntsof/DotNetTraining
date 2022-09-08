using System;

namespace CovarianceAndConvariance
{
    class Program
    {
        static void SetObject(Object val)
        {

        }
        static void SetObject(String val)
        {

        }
        static string GetString() { return "Inside GetString()"; }
        static void Main(string[] args)
        {
            Console.WriteLine("Covariance and Contravariance");
            Console.WriteLine("Array data type supports Convariance");

            object[] objArray = new string[10];

            objArray[0] = "10";
            Console.WriteLine(objArray[0]);

            Console.WriteLine("Delegates covariance");

            Func<object> delegateobj = GetString;
            //String strobj = delegateobj;

            Console.WriteLine("Contravariance Delegate reverses the Covariance functionaloty");
            Action<string> del2 = SetObject;

        }  
    }
}
