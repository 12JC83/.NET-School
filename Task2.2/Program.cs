using System;
using System.ComponentModel.Design;

public class DiagonalMatrix
{
    private int[] diagonal;
    public int Size { get; }

    public DiagonalMatrix(params int[] elements)
    {
        if (elements == null)
        {
            Size = 0;
            diagonal = new int[0];

        }
        else
        {
            Size = elements.Length;
            diagonal = new int[Size];

            for (int i = 0; i < Size; i++)
            {
                diagonal[i] = elements[i];
            }
        }
    }
    public int this[int i, int j]
    {
        get
        {
            if (i < 0 || j < 0 || i >= Size || j >= Size) return 0;
            else
            {
                if (i == j) { return diagonal[i]; }
                else { return 0; }
            }


        }
        set
        {
            if (i != j || i < 0 || j < 0 || i >= Size || j >= Size) return;
            diagonal[i] = value;
        }
    }

    public int Track()
    {
        int sum = 0;
        for (int i = 0; i < Size; i++) {
            sum += diagonal[i];
        }
        return sum;
    }

    public override string ToString()
    {
        string text = "Matrix: [";
        for (int i = 0; i < Size; i++)
        {
            text += diagonal[i];
            if (i < Size - 1) text += ",";
        }
        text += "]";
        return text;
    }

    public override bool Equals(object? obj)
    {
        DiagonalMatrix other = (DiagonalMatrix)obj;
        if (this.Size != other.Size) return false;
        for (int i = 0; i < this.Size; i++)
        {
            if (this.diagonal[i] != other.diagonal[i]) return false;
        }
        return true;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}

public static class DiagonalMatrixAdd { 
    public static DiagonalMatrix Extension(this DiagonalMatrix a, DiagonalMatrix b)
    {
        int maxSize = Math.Max(a.Size, b.Size);
        int[] MatrixC = new int[maxSize];

        for(int i = 0; i < maxSize; i++)
        {
            int aValue;
            int bValue;
            if (i < a.Size) aValue = a[i, i]; else aValue = 0;

            if (i < b.Size) bValue = b[i, i]; else bValue = 0;
            MatrixC[i] = aValue + bValue;
        }
        return new DiagonalMatrix(MatrixC);
    }


}

class Program
{
    public static void Main(string[] args)
    {
        DiagonalMatrix matrix1 = new DiagonalMatrix(1, 4, 5, 6, 8);
        DiagonalMatrix matrix2 = new DiagonalMatrix(4, 5, 6, 9);

        DiagonalMatrix matrix3 = new DiagonalMatrix(1, 1, 1);
        DiagonalMatrix matrix4 = new DiagonalMatrix(1, 1, 1);


        Console.WriteLine(matrix1);
        Console.WriteLine(matrix2);
        Console.WriteLine($"The Matrix is equal? {matrix1.Equals(matrix2)}");
        Console.WriteLine($"Sum of Matrix 1 diagonal: {matrix1.Track()}");
        Console.WriteLine($"Result of extension : {matrix1.Extension(matrix2)}");
        Console.WriteLine("-----------------------------------------------------");


        Console.WriteLine(matrix3);
        Console.WriteLine(matrix4);
        Console.WriteLine($"The Matrix is equal? {matrix3.Equals(matrix4)}");
        Console.WriteLine($"Sum of Matrix 3 diagonal: {matrix1.Track()}");
        Console.WriteLine($"Result of extension : {matrix3.Extension(matrix4)}");


    }
}