using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evens = new List<int>();

            var odds = new List<int>();

            foreach(var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            foreach(var item in evens)
            {
                Console.WriteLine($"{item} is an even number");
            }

            foreach(var item in odds)
            {
                Console.WriteLine($"{item} is an odd number");
            }
           
             /* Using either a foreach or for loop,
             * iterate through the array you populated with 10 numbers.
             * Inside the scope of the loop,
             * check to see if each number in the array is even or odd.
             * If the number is even, add it to the evens list.
             * If the number is odd, add it to the odds list.
             */



            /* Using a foreach loop,
             * display the numbers in your "evens" list
             */
            

            /* Using a for loop,
             * display the numbers in your "odds" list
             */
        }
    }
}
