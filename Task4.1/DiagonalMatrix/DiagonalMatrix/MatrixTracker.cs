public class MatrixTracker<T>
{
    private DiagonalMatrix<T> _matrix { get; };
    private (int Row, int Column, T OldValue, T NewValue)? _lastChange;

    public MatrixTracker(DiagonalMatrix<T> matrix)
    {
        _matrix = matrix;
        _matrix.ElementChanged += OnElementChanged;
    }

    private void OnElementChanged(object sender, ElementChangedEventArgs<T> e)
    {
        _lastChange = (e.Row, e.Column, e.OldValue, e.NewValue);
    }

    public void Undo()
    {
        if (_lastChange.HasValue)
        {
            var change = _lastChange.Value;
            _matrix[change.Row, change.Column] = change.OldValue;
            _lastChange = null; 
        }
    }
}