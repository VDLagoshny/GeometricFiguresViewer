using GeometricFiguresViewer.Settings;

namespace GeometricFiguresViewer.GeometricFigures
{
    /// <summary>
    /// Класс фигуры "Круг"
    /// </summary>
    internal sealed class Circle : IFigure
    {
        public string Name { get; } = nameof(Circle);
        
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }


        /// <summary>
        /// Метод получения графической формы фигуры "Круг"
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
                    double x = ((double)i / consoleSettings.ScreenWidth * 2d - 1d)* consoleSettings.GraphicCoefficient;
                    double y = (double)j / consoleSettings.ScreenHeight * 2d - 1d;
                    var pixel = ' ';

                    if (x * x + y * y < Radius * Radius)
                        pixel = 'o';

                    screen[i + j * consoleSettings.ScreenWidth] = pixel;
                }
            }

            return screen;
        }
    }
}
