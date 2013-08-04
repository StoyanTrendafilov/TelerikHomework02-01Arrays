//Write a program that finds the index of given element in a sorted array of integers 
//by using the binary search algorithm (find it in Wikipedia).


using System;
    
class Program
{
    static void Main(string[] args)
    {
        int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        
        Console.Write("Please enter wanted number (it must be smaller than 21) : ");
        int theNumber = int.Parse(Console.ReadLine());

        int firstIndex = 0;
        int lastIndex = array.Length;
        int theMiddle = 0;

        while (firstIndex <= lastIndex)
        {
            theMiddle = (firstIndex + lastIndex) / 2;

            if (array[theMiddle] == theNumber)
            {
                Console.WriteLine("Wanted number has index \"{0}\" !", theMiddle);
                break;
            }

            if (theNumber > theMiddle)
            {
                firstIndex = theMiddle;
            }

            if (theNumber < theMiddle )
            {
                lastIndex = theMiddle;
            }

        }

    }
}

