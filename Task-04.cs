using System;

class ArrayDemo
{
    static void Main()
    {
        // Create a single-dimensional integer array
        int[] favoriteNumbers = { 7, 3, 9, 1, 5 };

        // Sort the array in ascending order
        Array.Sort(favoriteNumbers);

        // Reverse the array
        Array.Reverse(favoriteNumbers);

        //  print each manually
        Console.WriteLine("Array elements after sort and reverse:");
        Console.WriteLine(favoriteNumbers[0]);
        Console.WriteLine(favoriteNumbers[1]);
        Console.WriteLine(favoriteNumbers[2]);
        Console.WriteLine(favoriteNumbers[3]);
        Console.WriteLine(favoriteNumbers[4]);

        // position of a specific number
        int searchNumber = 9;
        int position = Array.IndexOf(favoriteNumbers, searchNumber);
        Console.WriteLine($"Position of {searchNumber} in array: {position}");
    }
}
