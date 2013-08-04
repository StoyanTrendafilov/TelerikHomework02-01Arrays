//         Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
//          Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}


using System;

class Task20Variations
{
    
        static int elementsCount;
        static int endOfVariation;
        static int[] loops;
        
    static void Main()
            { 
            Console.Write("N = ");
            endOfVariation = int.Parse(Console.ReadLine());

            Console.Write("K = ");
            elementsCount = int.Parse(Console.ReadLine());

            loops = new int[elementsCount];
            NestedLoops(0);
            }

        
    static void NestedLoops(int currentLoop)
        {
            if (currentLoop == elementsCount)
            {
                PrintLoops();
                return;
            }
        for (int counter=1; counter<=endOfVariation; counter++)
            {
                loops[currentLoop] = counter;
                NestedLoops(currentLoop + 1);
            }
        }

    
    static void PrintLoops()
        {
            for (int i = 0; i < elementsCount; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }

}

