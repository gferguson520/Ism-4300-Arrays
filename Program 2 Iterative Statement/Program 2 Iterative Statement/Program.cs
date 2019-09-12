/*
    Author: Garrett Ferguson
    Date: 9/10/2019
    Comments: This C# Console application code demonstrates the use of
              iterative statements after getting input from users with their integers. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2_Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
// Asking the user to enter a value between the numbers of 1 and 100
            Console.WriteLine("Enter a integer value between 1 through 100.");
            try
            {
                //create a string 
                string inp = Console.ReadLine();
                int new_inp = int.Parse(inp);
                
                if((new_inp >=1)&& (new_inp <=100))
                for(int i = 1; i < new_inp +1; i++)
                //Having the system write a line for including the variable and showing the value. 
                    Console.WriteLine("You have entered " + i + " This is the current integer value in the loop: "+i);

                Console.WriteLine("Please press Enter to end this program, thank you for your time!");
                Console.ReadLine();
             }
            catch
            {
                Console.WriteLine("An Error has occured, check your integer that you have entered.");
            }
           
        }
        
    }
}
