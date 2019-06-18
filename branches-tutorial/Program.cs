﻿using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIf()
        {
        int a = 5;
        int b = 3;
        if (a + b > 10)
        {
            Console.WriteLine("The answer is greater than 10");
        }
        else
        {
            Console.WriteLine("The answer is not greater than 10");
        }
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }

        }

        static void Loops ()
        {
            //ExploreIf();
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            for(int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }
        }
    static void EndExercise()
        {
            int sum = 0;
            for  (int counter = 1; counter < 21; counter++)
            {
                if (counter % 3 == 0)
                {
                    sum = sum + counter;
                }
            }
            Console.WriteLine($"The sum of integers dividable by 3 is { sum }");
        }

    static void Main(string[] args)
    {
        EndExercise();
    }
    }
}
