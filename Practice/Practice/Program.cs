using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name? ");

            Console.ReadLine();

            Console.WriteLine("What is your Age? ");

            Console.ReadLine();

            Console.WriteLine("What grades do you expect to get in ISM 4300?");

           

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
                    Console.WriteLine("You have a recieved a F! You will have to retry the course!");
                    
                }
                Console.ReadKey();
                //preparing a catch to find an error if needed.
            }
            catch
            {
                Console.WriteLine("You have an error");
            }
            Console.WriteLine("What grades do you expect to get in ISM 4311?");

            

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
                    Console.WriteLine("You have a F! ");
                    
                }
                Console.ReadKey();
                //preparing a catch to find an error if needed.
            }
            catch
            {
                Console.WriteLine("You have an error");
            }

            Console.WriteLine("What are you planning on getting in LDR4300");
            //GG 
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
                    Console.WriteLine("You have a recieved a F! You will have to retry the course!");

                }
                
                //preparing a catch to find an error if needed.
            }
            catch
            {
                Console.WriteLine("You have an error");
            }

            Console.WriteLine("What are you planning on getting in GG4300");

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
                    Console.WriteLine("You have a recieved a F! You will have to retry the course!");

                }
                
                //preparing a catch to find an error if needed.
            }
            catch
            {
                Console.WriteLine("You have an error");
            }

            Console.ReadKey();
        }
    }
}

