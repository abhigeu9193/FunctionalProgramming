// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
public class ReverseNumber
{
    public static void Main(string[] args)
    {
        int n, reverse = 0, rem;
        Console.WriteLine("Enter a number: ");
        n = int.Parse(Console.ReadLine());
        while (n != 0)
        {
            rem = n % 10;
            reverse = reverse * 10 + rem;
            n /= 10;
        }
        Console.WriteLine("Reversed Number: " + reverse);
    }
}
