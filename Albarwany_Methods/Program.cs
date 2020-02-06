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

                // if else statment to check user input
                // check to see if users input data is a string without numbers or symbols 
                if ((System.Text.RegularExpressions.Regex.IsMatch(input, "[a-zA-Z]$" + " " + "[a-zA-Z]$")) || ((System.Text.RegularExpressions.Regex.IsMatch(input, "[a-zA-Z]$"))))
                {
                    HelloUser(ref input);
                }
                else
                {
                    // else , if input is not a sting display error message 
                    Console.WriteLine("Please enter a name consisting of all string values. No symbols or numeric digits ");

                }// end of else
            } // end of try 
            catch
            {
                Console.WriteLine("Please enter a string value");

            }// end of catch
        }
            // Method to prints " hello user name!
            private static void HelloUser(ref string input)
            {
                // Display message 
                Console.WriteLine("Hello " + input + "!");
            
            }
        }
    }

