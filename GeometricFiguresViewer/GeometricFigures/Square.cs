using GeometricFiguresViewer.Settings;

namespace GeometricFiguresViewer.GeometricFigures
{
    /// <summary>
    /// Класс фигуры "Квадрат"
    /// </summary>
    internal sealed class Square: IFigure
    {
        public string Name { get; } = nameof(Square);

        public double Side { get; }

        public Square(double side)
        {
            Side = side;
        }

        /// <summary>
        /// Метод получения графической формы фигуры "Квадрат"
        /// </summary>
        /// <param name="consoleSettings">
        /// Настройки консоли, тип ConsoleSettings</param>
        /// <returns>
        /// Массив символов, отображающих 
        /// фигуру на консоли, тип char[]
        /// </returns>
        public char[] GetGraphicForm(ConsoleSettings consoleSettings)
        {
            var screen = new char[consoleSettings.ScreenWidth * consoleSettings.ScreenHeight + 1];

            for (var i = 0; i < consoleSettings.ScreenWidth; i++)
            {
                for (var j = 0; j < consoleSettings.ScreenHeight; j++)
                {
                    double x = ((double)i / consoleSettings.ScreenWidth * 2d - 1d) * consoleSettings.GraphicCoefficient;
                    double y = (double)j / consoleSettings.ScreenHeight * 2d - 1d;
                    var pixel = ' ';

                    if (x * x < Side * Side
                        && y * y < Side * Side)
                        pixel = '#';

                    screen[i + j * consoleSettings.ScreenWidth] = pixel;
                }
            }

            return screen;
        }
    }
}
