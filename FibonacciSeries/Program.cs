// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class FibonacciSeries
    {
        public static void Main()
        {
            int num1 = 0, num2 = 1, nextNumber, numberOfElements;
            Console.Write("Enter the number of elements to Print : ");
            numberOfElements = int.Parse(Console.ReadLine());
            if (numberOfElements < 2)
            {
                Console.Write("Please Enter a number greater than two");
            }
            else
            {
                //First print first and second number
                Console.Write(num1 + " " + num2 + " ");

                //Starts the loop from 2 because 0 and 1 are already printed
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = num1 + num2;
                    Console.WriteLine(nextNumber+ " ");
                    num1 = num2;
                    num2 = nextNumber;
                }
            }

            Console.ReadKey();
        }
    }


