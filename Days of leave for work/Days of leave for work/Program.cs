using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_of_leave_for_work
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many days of leave would you like to request?");
            int leave = int.Parse(Console.ReadLine());

            if (leave >0 && leave <8 )
            {
                Console.WriteLine("you are not accepted");
            }
            else 
            {
                Console.WriteLine("You are accepted");
            }
        }
    }
}
