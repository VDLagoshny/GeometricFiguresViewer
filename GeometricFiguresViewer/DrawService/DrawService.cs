namespace GeometricFiguresViewer.DrawService
{
    /// <summary>
    ///  Класс сервиса отрисовки фигуры
    /// </summary>
    internal sealed class DrawService: IDrawService
    {
        /// <summary>
        /// Метод отрисовки фигуры
        /// </summary>
        /// <param name="chars">Массив символов, отображающих 
        /// фигуру на консоли, тип char[]</param>
        public void Draw(char[] chars)
        {
            if (chars.Length == 0)
                throw new ArgumentException("Output array is empty");

            foreach (var pixel in chars)
            {
                Console.Write(pixel);
            }

            Console.WriteLine("\n\n\n");
        }
    }
}
