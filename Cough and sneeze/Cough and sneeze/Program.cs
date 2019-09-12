using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cough_and_sneeze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Have you Sneezed or Coughed?");
           
            try
            {
                string inp = Console.ReadLine();

                Console.WriteLine("How many times did this action happen?");
                string inp2 = Console.ReadLine();
                int number = int.Parse(inp2);
                for (int i=0; i<number; i++)
                {
                    if (inp == "Sneeze")
                    {
                        Console.WriteLine("Bless You!");
                    }
                    else if (inp2 == "Cough")
                    {
                        Console.WriteLine("Excuse You");

                    }
                    else 
                        Console.WriteLine("Bless You!");
                
                }

                
            }
             catch   
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();
            
        }
    }
}
