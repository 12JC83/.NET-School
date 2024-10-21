using System;
using System.Runtime.CompilerServices;

public class DiagonalMatrix
{
    private readonly int[] diagonalElements;
    public int Size { get; }

    public DiagonalMatrix(params int[] elements)
    {
        if (elements == null)
        {
            Size = 0;
            diagonalElements = Array.Empty<int>();
        }
        else
        {
            Size = elements.Length;
            diagonalElements = new int[Size];
            Array.Copy(elements, diagonalElements, Size);
        }

    }
    public int this[int i, int j]

    {
        get
        {
            if (i < 0 || j < 0 || i >= Size || j >= Size)
                return 0;
            return i == j ? diagonalElements[i] : 0;

        }
        set
        {
            if (i < 0 || j < 0 || i >= Size || j >= Size)
                return;
            if (i == j)
            {
                diagonalElements[i] = value;
            }
        }
    }
    public int Track()
    {
        int sum = 0;
        for (int i = 0; i < Size; i++)
        {
            sum += diagonalElements[i];
        }
        return sum;
    }

    public override bool Equals(object? obj)
    {
        if (obj is DiagonalMatrix other && Size == other.Size)
        {
            for (int i = 0; i < Size; i++)
            {
                if (diagonalElements[i] != other.diagonalElements[i])
                    return false;
            }
            return true;
        }
        return false;

    }
    public override int GetHashCode() { return 0; }
    public override string ToString()
    {
        string result = "Diagonal Matrix: [";
        for (int i = 0; i < Size; i++)
        {
            result += diagonalElements[i];
            if (i < Size - 1)
            {
                result += ", ";
            }
        }
        result += "]";
        return result;
    }
}

   public static class DiagonalMatrixExtensions
    {
        public static  DiagonalMatrix Add(this DiagonalMatrix a, DiagonalMatrix b)
        {
            
            int maxSize = Math.Max(a.Size, b.Size);
            int[] resultElements = new int[maxSize];

          
            for (int i = 0; i < maxSize; i++)
            {
            
                int aValue = (i < a.Size) ? a[i, i] : 0;
                int bValue = (i < b.Size) ? b[i, i] : 0;
                resultElements[i] = aValue + bValue;
            }
            return new DiagonalMatrix(resultElements);
        }
    }




    class Program
    {
        public static void Main(string[] args)
        {
            DiagonalMatrix matrix1 = new DiagonalMatrix(1, 4, 5, 6 ,8);
            DiagonalMatrix matrix2 = new DiagonalMatrix(4, 5, 6, 9);
            DiagonalMatrix result = matrix1.Add(matrix2);

            Console.WriteLine(matrix1);
            Console.WriteLine(matrix2);
            Console.WriteLine(result);
            Console.WriteLine($"Sum of matrix1 diagonal: {matrix1.Track()}");
        }
    }


