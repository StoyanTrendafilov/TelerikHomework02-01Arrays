﻿//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
//Print the obtained array on the console.



using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[20];

        for (int i = 0; i < 20; i++)
		{
            array[i] = i * 5;
            Console.WriteLine(array[i]);
		}
    }
}
