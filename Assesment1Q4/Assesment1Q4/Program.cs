using System;

//Write a program in C# Sharp to check the username and password.  



namespace Assesment1Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            int attempts = 0;



            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username != "abcd" || password != "1234")
                    attempts++;
                else
                    attempts = 1;

            }
            while ((username != "abcd" || password != "1234") && (attempts != 3));

            if (attempts == 3)
                Console.Write("\nLogin attemp three or more times. Try later!\n\n");
            else
                Console.Write("\nThe password entered successfully!\n\n");



        }
    }
}
