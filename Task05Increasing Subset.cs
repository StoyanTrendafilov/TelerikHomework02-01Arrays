//Write a program that finds the maximal increasing sequence in an array. 
//Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter your array's length: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];
            int theCount = 0;
            int theNumber = 0;
            int counter = 1;

            for (int index = 0; index < array.Length; index++)
            {
                Console.Write("Please enter element number {0} of your array :", index + 1);
                array[index] = int.Parse(Console.ReadLine());
            }
            for (int index = 1 ; index < array.Length; index++)
            {
                if (array[index - 1] == array[index] - 1)
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > theCount)
                {
                    theCount = counter;
                    theNumber = array[index];
                }
            }

            Console.WriteLine("And the wining sequence is : ");
            for (int i = theCount - 1; i >= 0; i--)
            {
                Console.WriteLine(theNumber - i);
            }
        }
    }
}
