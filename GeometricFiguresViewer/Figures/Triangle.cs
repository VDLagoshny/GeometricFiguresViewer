namespace GeometricFiguresViewer.Figures
{
    internal sealed class Triangle: IFigure
    {
        public string Name { get; } = nameof(Triangle);

        public TriangleTypes Type { get; }
        public long BaseSide { get; }
        public long Height { get; }
        public long? SideA { get; }
        public double? AngleA { get; }

        public Triangle(TriangleTypes type, long baseSide, long height, long? sideA = null, double? angleA = null) 
        { 
            Type = type;
            BaseSide = baseSide;
            Height = height;
            SideA = sideA;
            AngleA = angleA;
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
