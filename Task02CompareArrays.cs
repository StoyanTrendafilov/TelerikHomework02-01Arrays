//Write a program that reads two arrays from the console and compares them element by element.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter the first array's length : ");
        int firstArrayLength = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the second array's lenght : ");
        int secondArrayLength = int.Parse(Console.ReadLine());

        int[] firstArray = new int[firstArrayLength];

        int[] secondArray = new int[secondArrayLength];




        for (int i = 0; i < firstArrayLength; i++)
        {
            Console.Write("Please, enter element number {0} to your first array: ", i + 1);
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("============================================================");


        for (int i = 0; i < secondArrayLength; i++)
        {
            Console.Write("Please, enter element number {0} to your second array: ", i + 1);
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("============================================================");

        if (firstArrayLength > secondArrayLength)
        {
            for (int i = 0; i < secondArrayLength; i++)
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("Element number {0} is bigger in your first array", i + 1);
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("Element number {0} is bigger in your second array", i + 1);
                }
                else
                {
                    Console.WriteLine("Element number {0} is equal in your arrays :) ", i + 1);
                }
            }
        }
        else if (firstArrayLength < secondArrayLength)
        {
             for (int i = 0; i < firstArrayLength; i++)
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("Element number {0} is bigger in your first array", i + 1);
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("Element number {0} is bigger in your second array", i + 1);
                }
                else
                {
                    Console.WriteLine("Element number {0} is equal in your arrays :) ", i + 1);
                }
            }
        }
        else
        {
            for (int i = 0; i < firstArrayLength; i++)
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("Element number {0} is bigger in your first array", i + 1);
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("Element number {0} is bigger in your second array", i + 1);
                }
                else
                {
                    Console.WriteLine("Element number {0} is equal in your arrays :) ", i + 1);
                }
            }
        }
    }
}

