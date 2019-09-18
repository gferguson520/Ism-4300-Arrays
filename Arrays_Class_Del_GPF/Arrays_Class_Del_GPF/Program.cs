/*
Author: Garrett Ferguson
Date: 09/18/2019
Description: Arrays for Class Deliverable
Class: ISM 4300
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Class_Del_GPF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting an Array with 25 elements within it. 
            int[] Array = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25};
            for (int i = 1; i < 26; i++)
            {
                //Having a writeLine for information to display an iteration for each element in the Array to be seen by the user.
                Console.WriteLine("Element Value = " + i);
                Console.WriteLine("Processing Iteration within the array");
                //Making an ending writeline statement to allow the user to know the array has finished.
                if (Array[i]== 25)
                {
                    Console.WriteLine("Your Array Has Ended");
                }         
            }
            Console.ReadKey(true); //Need a ready key to be able to debug the system and allow the user to see the input of the console.
        }
        }
    }
