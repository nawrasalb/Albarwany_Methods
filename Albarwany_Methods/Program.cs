// Author: Nawras Albarwany
//Date : 2/06/2020
// demonstrates a method

using System;

namespace Albarwany_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Please enter your name");

            // try catch to validate user input
            //catch block will handle the error 
            try
            {
                // variable used to gather data from user input. 
                string input = Console.ReadLine();

                // Method to prints " hello user name!
                Console.WriteLine("Hello " + input + "!");

            } // end of try 
            catch
            {
                Console.WriteLine("Please enter a string value");
                Console.ReadKey(true);
            }// end of catch
        }
    }
}
