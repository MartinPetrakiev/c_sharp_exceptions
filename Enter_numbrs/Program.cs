using System;

public class Program
{
    public static int ReadNumber(int start, int end)
    {
        int number = 0;
        try
        {
            number = int.Parse(Console.ReadLine());

            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Exception: {e.Message}");
            Environment.Exit(1);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine($"Exception: {e.Message}");
            Environment.Exit(1);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
            Environment.Exit(1);
        }

        return number;
    }

    public static void Main()
    {
        int[] arrayNumbers = new int[12];
        arrayNumbers[0] = 1;
        arrayNumbers[11] = 100;
        int start = arrayNumbers[0];
        int end = arrayNumbers[11];

        for (int i = 1; i < 11; i++)
        {
            int number = ReadNumber(start, end);
            arrayNumbers[i] = number;
            start = arrayNumbers[i];
        }

        Console.WriteLine(string.Join(" < ", arrayNumbers));
    }
}

/*
Description
Write a method ReadNumber(int start, int end) that enters an integer number in a given range ( start, end ).
If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers: a1, a2, ..., a10, such that 1 < a1 < ... < a10 < 100

Input
You will receive 10 lines of input, each consisted of an integer number
a1
a2
...
a10

Output
Print 1 < a1 < ... < a10 < 100
Or Exception if the above inequality is not true

Constraints
Time limit: 0.1s
Memory limit: 16MB
*/