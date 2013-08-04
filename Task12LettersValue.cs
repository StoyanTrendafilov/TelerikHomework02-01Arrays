//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.


using System;
class Program
{
    static void Main(string[] args)
    {
        char[] alphabet = new char[53] {'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E' , 'f', 'F' , 'g', 'G' , 'h', 'H' , 
            'i', 'I', 'j', 'J','k', 'K', 'l', 'L', 'm', 'M', 'n', 'N', 'o', 'O' , 'p', 'P', 'q', 'Q', 'r', 'R', 's', 'S', 't', 
            'T', 'u', 'U', 'v', 'V', 'w', 'W', 'x', 'X', 'y', 'Y', 'z', 'Z', ' '};

        Console.Write("Please, enter your word here --> ");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.Write(j+1 + " ");
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("And the following is for luxury (демек за разкош). ");
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.WriteLine("Letter {0} has value {1}.", word[i], j + 1);
                }
            }
        }
   }
}
