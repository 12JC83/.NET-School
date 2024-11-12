public static class DiagonalMatrixExtensions
{
    public static DiagonalMatrix<T> Add<T>(this DiagonalMatrix<T> matrix1, DiagonalMatrix<T> matrix2, Func<T, T, T> addFunc)
    {
        if (matrix1.Size != matrix2.Size)
            throw new ArgumentException("Matrices must be of the same size.");

        var result = new DiagonalMatrix<T>(matrix1.Size);
        for (int i = 0; i < matrix1.Size; i++)
        {
            result[i, i] = addFunc(matrix1[i, i], matrix2[i, i]);
        }
        return result;
    }
}