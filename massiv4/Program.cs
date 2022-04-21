using System;

namespace mass;

static class Program
{
    static void Main(string[] args)

    {
        int min = int.MaxValue;

        int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 1 };

        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] < min ) min = myArray[i];

        }
        Console.WriteLine(min);
        Console.ReadLine();
        Console.WriteLine(" ");
    }
}