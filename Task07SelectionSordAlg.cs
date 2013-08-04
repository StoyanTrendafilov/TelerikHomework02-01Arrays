//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. 
//Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("PLease, enter the lenght of your array : ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int temp = 0;
        int index = -1;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Now you must input member №{0}: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Your array now looks like : ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("=======================");

        for (int i = 0; i < n; i++)
        {
            index = -1;
            temp = arr[i];
            int minimal = int.MaxValue;

            for (int j = i; j < n; j++)
            {
                if (arr[j] < minimal)
                {
                    minimal = arr[j];
                    index = j;
                }
            }

            temp = arr[i];
            arr[i] = minimal;
            arr[index] = temp;
        }

        Console.WriteLine("After sorting your array now looks like : ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("=======================");

    }
}

