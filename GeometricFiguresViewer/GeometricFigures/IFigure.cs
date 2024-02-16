using GeometricFiguresViewer.Settings;

namespace GeometricFiguresViewer.GeometricFigures
{
    /// <summary>
    /// Интерфейс геометрической фигуры
    /// </summary>
    /// <remarks>
    /// NB: дополнить методами расчета периметра, площади
    /// </remarks>
    internal interface IFigure
    {
        string Name { get; }

        /// <summary>
        /// Метод получения графической формы фигуры
        /// </summary>
        /// <param name="consoleSettings">
        /// Настройки консоли, тип ConsoleSettings</param>
        /// <returns>
        /// Массив символов, отображающих 
        /// фигуру на консоли, тип char[]
        /// </returns>
        char[] GetGraphicForm(ConsoleSettings consoleSettings);
    }
}
