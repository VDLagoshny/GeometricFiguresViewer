using GeometricFiguresViewer.GeometricFigures;

namespace GeometricFiguresViewer.Settings
{
    /// <summary>
    /// Класс пользовательского интерфейса
    /// </summary>
    internal class UserInterfaceService
    {
        private readonly string _titleMessage = 
                $"Please, select figure:" +
                $"\n- {nameof(Square)} (press \"{(int)Figures.Square}\")" +
                $"\n- {nameof(Rectangle)} (press \"{(int)Figures.Rectangle}\")" +
                $"\n- {nameof(Circle)} (press \"{(int)Figures.Circle}\")" +
                $"\n====================================================";

        private readonly string _repeatMessage = "Wrong key. Please, try again.. Attempts: ";
        private readonly string _errorMessage = "\nToo many attempts.";
        private int Attempts { get; set; } = 3;
        private int FigureKey { get; set; }

        /// <summary>
        /// Метод получения ключа геометрической фигуры
        /// </summary>
        public int GetFigureKey()
        {
            Console.WriteLine(_titleMessage);

            while (Attempts > 0)
            {
                var figureKey = Console.ReadLine()?.ToLower().Trim();
                if (IsCorrectFigureKey(figureKey))
                    break;

                Console.WriteLine($"{_repeatMessage}{--Attempts}");
            }

            if (Attempts == 0)
                throw new ArgumentException(_errorMessage);

            return FigureKey;
        }

        /// <summary>
        /// Метод проверки ключа геометрической фигуры
        /// </summary>
        /// <param name="figureKey">Ключ геометрической 
        /// фигуры, тип string?</param>
        /// <returns>
        /// true - ключ корректный (присутствует в списке фигур)
        /// false - ключ некорректный (не присутствует в списке фигур)
        /// </returns>
        private bool IsCorrectFigureKey(string? figureKey)
        {
            if (string.IsNullOrEmpty(figureKey)
                || string.IsNullOrWhiteSpace(figureKey))
                return false;

            if (!int.TryParse(figureKey, out int key))
                return false;

            if (!(key == (int)Figures.Square)
                & !(key == (int)Figures.Rectangle)
                & !(key == (int)Figures.Circle))
                return false;

            FigureKey = key;
            return true;
        }
    }
}
