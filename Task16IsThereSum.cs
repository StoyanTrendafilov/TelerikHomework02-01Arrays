//* We are given an array of integers and a number S. 
//Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
//	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)


using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of your array : ");
            long elementsCount = long.Parse(Console.ReadLine());
            long[] array = new long[elementsCount];

            Console.Write("Enter the wanted sum : ");
            long theSum = long.Parse(Console.ReadLine());

            int counter = 0;
            string subset = "";

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter element number \"{0}\" of your array: ", i + 1);
                array[i] = long.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            int maxSubsets = (int)Math.Pow(2, elementsCount) - 1;
            for (int i = 1; i <= maxSubsets; i++)
            {
                subset = "";
                long checkingSum = 0;
                for (int j = 0; j <= elementsCount; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;
                    if (bit == 1)
                    {
                        checkingSum = checkingSum + array[j];
                        subset = subset + " " + array[j];
                    }
                }
                if (checkingSum == theSum)
                {
                    counter++;
                    Console.WriteLine("{2}. This subset has a sum of {0} : {1} ", theSum, subset, counter);
                }
            }
            Console.WriteLine();
            Console.WriteLine("The number of available combinations is : " + counter);

        }
    }

