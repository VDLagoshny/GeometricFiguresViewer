namespace GeometricFiguresViewer.Figures
{
    internal sealed class Square: IFigure
    {
        public string Name { get; } = nameof(Square);

        public long Side { get; }

        public Square(long side)
        {
            Side = side;
        }



        public long GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public long GetSquare()
        {
            throw new NotImplementedException();
        }

        public char[] GetGraphicForm()
        {
            throw new NotImplementedException();
        }
    }
}
