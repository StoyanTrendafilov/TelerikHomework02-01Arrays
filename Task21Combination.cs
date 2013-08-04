//   Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
//                 N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}


using System;

class Program
{
    static void Check(int[] array)
    {
        for (int i = 0; i < array.Length; i++) Console.Write(array[i] + 1 + (i == array.Length - 1 ? "\n" : " "));
    }

    static void Combination(int[] array, int n, int i, int next)
    {
        if (i == array.Length)
        {
            Check(array);
            return;
        }

        for (int j = next; j < n; j++)
        {
            array[i] = j;

            Combination(array, n, i + 1, j + 1);
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[int.Parse(Console.ReadLine())];

        Combination(array, n, 0, 0);
    }
}