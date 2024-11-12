
using System.Linq.Expressions;

public class DiagonalMatrix<T>
{
    private T[] _diagonalElements { get;}
    public int Size { get; }
    public event EventHandler<ElementChangedEventArgs<T>> ElementChanged;

    public DiagonalMatrix(int size)
    {
        if (size < 0)
            throw new ArgumentException("Size must be non-negative.");

        Size = size;
        _diagonalElements = new T[size];
    }

    

    public T this[int i, int j]
    {
        get
        {
            if (i < 0 || i >= Size || j < 0 || j >= Size)
                throw new IndexOutOfRangeException("Index is out of range.");

            return i == j ? _diagonalElements[i] : default;
        }
        set
        {
            if (i < 0 || i >= Size || j < 0 || j >= Size)
                throw new IndexOutOfRangeException("Index is out of range.");

            if (i == j)
            {
                if (!EqualityComparer<T>.Default.Equals(_diagonalElements[i], value))
                {
                    var oldValue = _diagonalElements[i];
                    _diagonalElements[i] = value;
                    OnElementChanged(i, j, oldValue, value);
                }
            }
        }
    }
    protected virtual void OnElementChanged(int row, int column, T oldValue, T newValue)
    {
        ElementChanged?.Invoke(this, new ElementChangedEventArgs<T>(row,column, oldValue, newValue));
    }
}
