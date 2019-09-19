/*
    Author: Garrett Ferguson
    Date: 09/18/2019
    Description: Demonstrates the use of methods after getting input from a user. 
    Class: ISM 4300
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Class_Del_GPF
{
    class Program
    {
        static void Main(string[] args)
        {
            GPF(); //Setting up/creating and naming the GPF method 
            Console.ReadKey(true);
        }
        private static void GPF()  //allow the method to be called after being created
        {
            Console.WriteLine("Please type in your name: "); //allowing the user to input their name
            string input = Console.ReadLine();
            Console.WriteLine("Hi " + input + "!"); //grabs the users name to put into a hello user statement

            Console.WriteLine("Press any key to end the application"); //Extra code to allow user to know to end the application 
            Console.ReadKey(); //Readkey to be able to see the results inputed
        }
    }
}
