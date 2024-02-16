namespace GeometricFiguresViewer.Settings
{
    /// <summary>
    /// Настройки консоли
    /// Необходимы для вычисления коэффициентов при
    /// построении фигур
    /// </summary>
    internal sealed class ConsoleSettings
    {
        private readonly int _pixelWidth = 8;
        private readonly int _pixelHeight = 16;
        public int ScreenWidth { get; } = Console.WindowWidth;
        public int ScreenHeight { get; } = Console.WindowHeight;
        public double GraphicCoefficient { get; }

        public ConsoleSettings() 
        {
            GraphicCoefficient = ((double)ScreenWidth / ScreenHeight) * ((double)_pixelWidth / _pixelHeight);
        }
    }
}
