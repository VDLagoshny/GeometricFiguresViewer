using GeometricFiguresViewer.Settings;

namespace GeometricFiguresViewer.GeometricFigures
{
    /// <summary>
    /// Класс фигуры "Прямоугольник"
    /// </summary>
    internal sealed class Rectangle: IFigure
    {
        public string Name { get; } = nameof(Rectangle);

        public double SideA { get; }
        public double SideB { get; }

        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        /// <summary>
        /// Метод получения графической формы фигуры "Прямоугольник"
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
                    if ((x * x) < (SideA * SideA)
                        && (y * y) < (SideB * SideB))
                        pixel = '*';

                    screen[i + j * consoleSettings.ScreenWidth] = pixel;
                }
            }

            return screen;
        }
    }
}
