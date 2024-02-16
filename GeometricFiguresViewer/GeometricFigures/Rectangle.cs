using GeometricFiguresViewer.Settings;

namespace GeometricFiguresViewer.GeometricFigures
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


        public char[] GetGraphicForm(ConsoleSettings consoleSettings)
        {
            throw new NotImplementedException();
        }
    }
}
