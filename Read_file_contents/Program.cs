using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("File path (e.g., C:\\WINDOWS\\win.ini):");
        string filePath = Console.ReadLine();

        try
        {
            string fileContents = File.ReadAllText(filePath);

            Console.WriteLine("File Contents:");
            Console.WriteLine(fileContents);
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access to the file is not authorized.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}

/*
Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(...). Be sure to catch all possible exceptions and print user-friendly error messages.
*/