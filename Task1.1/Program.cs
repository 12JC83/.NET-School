public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter a number b: ");
        int b = int.Parse(Console.ReadLine());

        for (int i = a; i <= b; i++)
        {
            int ValueOfNumber = i;
            int ValueOfCountA = 0;
            while (ValueOfNumber > 0)
            {

                if (ValueOfNumber % 12 == 10)
                {
                    ValueOfCountA++;
                }
                ValueOfNumber /= 12;
            }
            if (ValueOfCountA == 2)
            {
                Console.WriteLine(i);
            }
        }


    }
}


