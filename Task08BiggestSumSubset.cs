//Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//	Can you do it with only one loop (with single scan through the elements of the array)?
// yes i can, thanks to google :D

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        
        int currentSum = array[0];
        int maxSum = array[0];
        int sequenceLenth = 1;
        int endingPlace = 0;
        int finalLength = 1;
        int firstPlace = 0;

        for (int index = 1; index < array.Length; index++)
        {
            if (array[index] + currentSum > array[index])
            {
                currentSum = array[index] + currentSum;
                sequenceLenth++;
            }
            else
            {
                currentSum = array[index];
                sequenceLenth = 1;
                firstPlace = index;
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                endingPlace = index;
                finalLength = sequenceLenth;
            }
        }
        Console.WriteLine("==================" );

        for (int i = firstPlace; i <= endingPlace; i++) // this shows the sequnece, as entered
			{
			 Console.WriteLine(array[i]);
			}

        Console.WriteLine("++++++++++++++++++++");
        for (int i = endingPlace; i > endingPlace - finalLength ; i--) // this shows the sequence reversed
        {

            Console.WriteLine(array[i]);
        }
    }
}

