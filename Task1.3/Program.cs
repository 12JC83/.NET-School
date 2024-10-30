using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
            array[i] = int.Parse(Console.ReadLine());

        Console.Write("Original array:");
        foreach (int num in array)
            Console.Write(num + " ");

        Console.WriteLine();

        Console.Write("Unique array:");
        for (int i = 0; i < n; i++)
        {
            bool isUnique = true;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique)
                Console.Write(array[i] + " ");
        }
    }
}