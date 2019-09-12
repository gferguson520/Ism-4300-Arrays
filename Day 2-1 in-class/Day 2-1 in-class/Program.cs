using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_1_in_class
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age: ");
                int ageI= int.Parse(Console.ReadLine());
               
                // This is made to make sure that my code finds the age of its consumer.
                    if(ageI >= 21)
                {
                    Console.WriteLine("You are old enough to drink, thankfully.");
                }
                    else
                {
                    Console.WriteLine("You are not old enough to drink, sonny.");
                }
            }
            catch
            {
                Console.WriteLine("You have an error!");
            }
        }
    }
}
