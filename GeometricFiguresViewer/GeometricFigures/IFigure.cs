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

        char[] GetGraphicForm(ConsoleSettings consoleSettings);
    }
}
