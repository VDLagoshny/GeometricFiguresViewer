using GeometricFiguresViewer.Settings;

namespace GeometricFiguresViewer.GeometricFigures
{
    internal sealed class Square: IFigure
    {
        public string Name { get; } = nameof(Square);

        public long Side { get; }

        public Square(long side)
        {
            Side = side;
        }


        public char[] GetGraphicForm(ConsoleSettings consoleSettings)
        {
            throw new NotImplementedException();
        }
    }
}
