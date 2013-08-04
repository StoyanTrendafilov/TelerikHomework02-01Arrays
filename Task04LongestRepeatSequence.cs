//Write a program that finds the maximal sequence of equal elements in an array.
//                          Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter your array's length: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        int repeatNumber = int.MinValue;
        int repeatCount = int.MinValue;
        int num = 0;
        int repeats = 1;

        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Please enter element number {0} of your array :", index + 1);
            array[index] = int.Parse(Console.ReadLine());
        }

        for (int checkIndex = 1; checkIndex < array.Length; checkIndex++)
        {

            if (array[checkIndex - 1] == array[checkIndex])
            {
                num = array[checkIndex - 1];
                repeats++;
            }
            else
            {
                repeats = 1;
            }
            if (repeats >= repeatCount)
            {
                repeatCount = repeats;
                repeatNumber = num;
            }
        }

        Console.Write("The longest secuence is : ");
        for (int i = 0; i < repeatCount; i++)
        {
            Console.Write(" " + repeatNumber + ", ");
        }
    }
}