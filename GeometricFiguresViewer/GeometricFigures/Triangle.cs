using GeometricFiguresViewer.Settings;

namespace GeometricFiguresViewer.GeometricFigures
{
    internal sealed class Triangle: IFigure
    {
        public string Name { get; } = nameof(Triangle);

        public long BaseSide { get; }
        public long Height { get; }

        public Triangle(long baseSide, long height) 
        { 
            BaseSide = baseSide;
            Height = height;
        }



        public char[] GetGraphicForm(ConsoleSettings consoleSettings)
        {
            throw new NotImplementedException();
        }
    }
}
