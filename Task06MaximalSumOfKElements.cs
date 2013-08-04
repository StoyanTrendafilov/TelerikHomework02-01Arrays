//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter the numbers ot the memebers of your array : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the number of the elements, you want to sum : ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Please, enter element number \" {0} \" to your array :", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxSum = 0;

        for (int index = 0; index <= (array.Length - k ); index++)
        {
            int sum = 0;

            for (int sumInd = index; sumInd < k + index; sumInd++)
            {
                sum = sum + array[sumInd];
            }

            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }
        Console.WriteLine(maxSum);
    }
}

