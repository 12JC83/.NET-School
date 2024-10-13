using System;
public class Program1
{
    public static void Main(string[] args)
    {
        Console.Write("Enter 9 numbers of ISBN: ");
        string isbn9 = Console.ReadLine();
        int sum = 0;
        for (int i = 0; i<9; i++)
        {
            int digit = int.Parse(isbn9[i].ToString());
            sum += digit * (10 - i);
        }
        int CheckDigit = (11 - (sum % 11)) % 11;
        if (CheckDigit == 10)
        {

            Console.WriteLine("ISBN: " + isbn9 + "X");
        }   
        
    }
}