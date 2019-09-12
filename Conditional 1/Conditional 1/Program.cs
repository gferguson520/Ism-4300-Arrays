//Author: Garrett Ferguson, Date: 9/11/19, Class: ISM 4300
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade would you expect to get in this amazing class called ISM 4300");
            //Make a try statement to try for each grade given/possible.
            try
            {
                //string is needed to correlate the variables created.
                string input = Console.ReadLine();
                int NEW_INP = int.Parse(input);
                //starting from A to F 
                if (NEW_INP >= 90)
                {
                    Console.WriteLine("You have reecieved a A!! Good Job!");
                }
                else if (NEW_INP >= 80)
                {
                    Console.WriteLine("You have recieved a B! Decent Job!");
                }
                else if (NEW_INP >= 70)
                {
                    Console.WriteLine("You have recieved a C! Try a little harder.");
                }
                else if (NEW_INP >= 60)
                {
                    Console.WriteLine("You have recieved a D...try again.");
                }
                else
                {
                    Console.WriteLine("You have a recieved a F! You will have to retry the course!")
                }
                Console.ReadLine();
//preparing a catch to find an error if needed.
            }
            catch
            {
                Console.WriteLine("You have an error");
            }
        }
    }
}