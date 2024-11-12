class Program
{
    static void Main(string[] args)
    {
        var matrix1 = new DiagonalMatrix<int>(3);
        var matrix2 = new DiagonalMatrix<int>(3);

        matrix1[0, 0] = 1;
        matrix1[1, 1] = 2;
        matrix1[2, 2] = 3;

        matrix2[0, 0] = 4;
        matrix2[1, 1] = 5;
        matrix2[2, 2] = 6;

        var resultMatrix = matrix1.Add(matrix2, (x, y) => x + y);

        Console.WriteLine("Resulting Matrix:");
        for (int i = 0; i < resultMatrix.Size; i++)
        {
            Console.WriteLine($"[{i}, {i}] = {resultMatrix[i, i]}");
        }

        var tracker = new MatrixTracker<int>(matrix1);
        matrix1[1, 1] = 10; 
        Console.WriteLine($"Changed [1, 1] to {matrix1[1, 1]}");

        tracker.Undo(); 
        Console.WriteLine($"After Undo, [1, 1] = {matrix1[1, 1]}");
    }
}