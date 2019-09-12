using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
          
            try
            {
          

                for( int i = 0; i<10; i++)
                
               Console.WriteLine("Its " + i + " O'clock");

                Console.ReadLine();

            }
            catch
            {
                Console.WriteLine("Error");
            }
            
        }
    }
}
