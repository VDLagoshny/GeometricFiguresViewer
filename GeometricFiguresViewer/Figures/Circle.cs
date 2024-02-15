namespace GeometricFiguresViewer.Figures
{
    internal sealed class Circle
    {
        public string Name { get; } = nameof(Circle);

        public long Radius { get; }

        public Circle(long radius)
        {
            Radius = radius;
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
