namespace GeometricFiguresViewer.DrawService
{
    /// <summary>
    ///  Интерфейс сервиса отрисовки фигуры
    /// </summary>
    internal interface IDrawService
    {
        /// <summary>
        /// Метод отрисовки фигуры
        /// </summary>
        /// <param name="chars">Массив символов, отображающих 
        /// фигуру на консоли, тип char[]</param>
        void Draw(char[] chars);
    }
}
