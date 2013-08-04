//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class Program
{
    static void Main(string[] args)
    {
        char[] arr1 = { 'a', 'b', 'c', 't', 'e', 'q', 'r', 'p' };
        char[] arr2 = { 'r', 'A', 's', 'f', 'n', 'v', 't', 'r', 'q', 'e', 'd', 's', 'a' };

        if (arr1.Length > arr2.Length)
        {
            for (int index = 0; index < arr2.Length; index++)
            {
                if (arr1[index] > arr2[index])
                {
                    Console.WriteLine("arr1 wins");
                    break;
                }
                else if (arr2[index] > arr1[index])
                {
                    Console.WriteLine("arr2 wins");
                    break;
                }
                else
                {
                    Console.WriteLine("The arrays are equal!");
                }
            }
        }
        else if (arr1.Length < arr2.Length)
        {
            for (int index = 0; index < arr1.Length; index++)
            {
                if (arr1[index] > arr2[index])
                {
                    Console.WriteLine("arr1 wins");
                    break;
                }
                else if (arr2[index] > arr1[index])
                {
                    Console.WriteLine("arr2 wins");
                    break;
                }
                else
                {
                    Console.WriteLine("The arrays are equal!");
                }
            }
        }
        else
        {
            for (int index = 0; index < arr1.Length; index++)
            {
                if (arr1[index] > arr2[index])
                {
                    Console.WriteLine("arr1 wins");
                    break;
                }
                else if (arr2[index] > arr1[index])
                {
                    Console.WriteLine("arr2 wins");
                    break;
                }
                else
                {
                    Console.WriteLine("The arrays are equal!");
                }
            }
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            Console.WriteLine(arr1[i]);
        }


        //if (arr1.Length > arr2.Length) // ot tuk e wariant 1 :D
        //{
        //    Console.WriteLine("Arr 1 wins");
        //}
        //else if (arr2.Length > arr1.Length)
        //{
        //    Console.WriteLine("Arr 2 wins!");
        //}
        //else if (arr1.Length == arr2.Length)
        //{
        //    for (int index = 0; index < arr1.Length; index++)
        //    {
        //        if (arr1[index] > arr2[index])
        //        {
        //            Console.WriteLine("arr1 winds");
        //        }
        //        else if (arr1[index] < arr2[index])
        //        {
        //            Console.WriteLine("arr2 wins");
        //        }
        //        else
        //        {
        //            Console.WriteLine("The arrays are equal!");
        //        }
        //    }
        //} // do tuk e wariant 1 :D




        //for (int i = 0; i < arr1.Length; i++)
        //{
        //    numbers[i] = arr1[i];
        //    Console.WriteLine("{0} : {1}", arr1[i], numbers[i]);
        //}

        //Array.Sort(arr1);

        //for (int i = 0; i < arr1.Length; i++)
        //{
        //    numbers[i] = arr1[i];
        //    Console.WriteLine("{0} : {1}", arr1[i], numbers[i]);
        //}
    }
}


