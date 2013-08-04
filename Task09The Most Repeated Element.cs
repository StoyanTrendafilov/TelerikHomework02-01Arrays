//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)


using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("PLease, enter the length of your array : ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        int bestNumber = int.MinValue;
        int counter = 1;
        int bestCount = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Member number {0} value : ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            counter = 1;
            for (int j = 0; j < n; j++)
            {
                if ((arr[i] == arr[j]) && (i != j))
                {
                    counter++;
                }
            }
            if (counter > bestCount)
            {
                bestCount = counter;
                bestNumber = arr[i];
            }
        }
        Console.WriteLine("The number {0} is repeated most times. It is repeated {1} times.", bestNumber, bestCount);
    }
}

