﻿using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void WorkingWithStrings()
        {
            var names = new List<string> { "Michael", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}!");
                }

                Console.WriteLine($"My name is {names[0]}");
                Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

                Console.WriteLine($"The list has {names.Count} people in it");

                var index = names.IndexOf("Felipe");

                if (index == -1)
                {
                    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
                }
                    else
                        {
                            Console.WriteLine($"The name { names[ index ] } is at index { index } ");
                        }

                index = names.IndexOf("Not Found");
                if (index == -1)
                {
                    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
                } else
                {
                    Console.WriteLine($"The name {names[index]} is at index {index}");
                }
                
                names.Sort();
                foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}!");
                }
                }
        static void Main (string[] args)
        {
               FibNumbers();
        }

        static void FibNumbers()
        {
            int count = 0;
            var fibonacciNumbers = new List<int> {1, 1};

            while (count < 18) 
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous + previous2);
                count++;
            }
            foreach(var item in fibonacciNumbers)
            Console.WriteLine(item);

        }

        }
    }
