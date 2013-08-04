//Write a program that finds in given array of integers a sequence of given sum S (if present). 
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter your array's length: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.Write("Please, enter wanted sum : ");
        int sum = int.Parse(Console.ReadLine());
        int startingMember = 0;
        int lastMember = 0;
        bool passed = false;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Member {0} value : ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }


        for (int i = 0; i < n; i++)
        {
            int checkSum = 0;
            checkSum = checkSum + arr[i];
            for (int j = i + 1; j < n; j++)
            {
                checkSum = checkSum + arr[j];
                if (checkSum == sum)
                {
                    startingMember = i;
                    lastMember = j;
                    passed = true;
                    break;
                }
            }
        }

        if (passed)
        {
            for (int i = startingMember; i <= lastMember; i++)
            {
                if (i != lastMember)
                {
                    Console.Write(arr[i] + " + ");
                }
                else
                {
                    Console.WriteLine(arr[i] + " = " + sum);
                }
            }
        }
        else
        {
            Console.WriteLine("You can't get wanted sum !");
        }
        
    }
}


