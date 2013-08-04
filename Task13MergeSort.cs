//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).


using System;

class Program
{
    static void Main()
    {
        

        int[] a = { 3, 8, 17, -5, 2, 1, 9, 6, 4 };
        int n = a.Length;
        int[] temp = new int[n];
        int step = 1;

        while (step < n)
        {
            int i = 0;
            while (i < n - step)
            {
                int left = i;
                int mid = i + step;
                int right;
                if (i + 2 * step - 1 < n - 1)
                {
                    right = i + 2 * step - 1;
                }
                else
                {
                    right = n - 1;
                }

                int leftEnd = i + step - 1;
                int tmpPos = i;
                int numElements = right - left + 1;
                while ((left <= leftEnd) && (mid <= right))
                {
                    if (a[left] <= a[mid])      
                    {
                        temp[tmpPos] = a[left];
                        tmpPos++;
                        left++;
                    }
                    else
                    {
                        temp[tmpPos] = a[mid];
                        tmpPos++;
                        mid++;
                    }
                }
                while (left <= leftEnd)
                {
                    temp[tmpPos] = a[left];
                    tmpPos++;
                    left++;
                }
                while (mid <= right)
                {
                    temp[tmpPos] = a[mid];
                    tmpPos++;
                    mid++;
                }
                for (int j = 0; j < numElements; j++)
                {
                    a[right] = temp[right];
                    right = right - 1;
                }

                i = i + 2 * step;
            }
            step = step * 2;
        }

        foreach (var item in a)
        {
            Console.Write(item + " ");
        }
    }
}

