using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15AllPrimeNumbers
{
    class Task15PrimeNumbers
    {
        static void Main(string[] args)
        {

            int n = 100;

            bool[] array = new bool[n];


            // задаваме всички елементи от bool масива да са true
            for (int i = 0; i < n; i++)
            {
                array[i] = true;

            }

            // логиката е следната - ако едно число е просто, то няма как да се получи като резултат от умножението на 
            // firstMultiplier и secondMultiplier (т.е. множители едно и две). Затова елементите от масива с индекс произведението 
            // на двата множитела става false. 
            for (int firstMultiplier = 2; firstMultiplier < n; firstMultiplier++)
            {
                if (array[firstMultiplier])//is true
                {
                    for (int secondMultiplier = 2; (secondMultiplier * firstMultiplier) < n; secondMultiplier++)
                    {
                        array[secondMultiplier * firstMultiplier] = false;
                    }
                }
            }
            // и тук печатим само индексите на тези елементи, които са останали true.
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == true)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }

