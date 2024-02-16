using GeometricFiguresViewer.Settings;

namespace GeometricFiguresViewer.GeometricFigures
{
    internal sealed class Circle : IFigure
    {
        public string Name { get; } = nameof(Circle);

        public long Radius { get; }

        public Circle(long radius)
        {
            Radius = radius;
        }



        public char[] GetGraphicForm(ConsoleSettings consoleSettings)
        {
            var screen = new char[consoleSettings.ScreenWidth * consoleSettings.ScreenHeight + 1];

            for (var i = 0; i < consoleSettings.ScreenWidth; i++)
            {
                for (var j = 0; j < consoleSettings.ScreenHeight; j++)
                {
                    // Перенос центра координат из верхнего угла консоли
                    double x = ((double)i / consoleSettings.ScreenWidth * 2d - 1d)* consoleSettings.GraphicCoefficient;
                    double y = (double)j / consoleSettings.ScreenHeight * 2d - 1d;
                    var pixel = ' ';

                    if (x * x + y * y < Radius * Radius)
                        pixel = '@';

                    screen[i + j * consoleSettings.ScreenWidth] = pixel;
                }
            }

            return screen;
        }
    }
}
