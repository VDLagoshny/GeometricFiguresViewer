namespace GeometricFiguresViewer.Figures
{
    internal sealed class Rectangle: IFigure
    {
        public string Name { get; } = nameof(Rectangle);

        public long SideA { get; }
        public long SideB { get; }

        public Rectangle(long sideA, long sideB)
        {
            SideA = sideA;
            SideB = sideB;
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
