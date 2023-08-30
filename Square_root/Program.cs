using System;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine()!;

        int number;
        try
        {
            number = int.Parse(input);
            Console.WriteLine(Math.Sqrt(number).ToString("F3"));
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number.");
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }
    }
}

/*
Description
Write a program that reads a number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye. Use try-catch-finally block.

Input
On the only line you will receive a real number

Output
Print the square root of the number or Invalid number on the first line
Use 3 digits of precision
Print Good bye on the second line

Constraints
Time limit: 0.1s
Memory limit: 16MB
*/