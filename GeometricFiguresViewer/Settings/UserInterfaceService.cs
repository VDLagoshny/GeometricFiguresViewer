using GeometricFiguresViewer.GeometricFigures;

namespace GeometricFiguresViewer.Settings
{
    /// <summary>
    /// Класс пользовательского интерфейса
    /// </summary>
    internal class UserInterfaceService
    {
        private readonly string _titleMessage = 
                $"Please, choose figure:" +
                $"\n- {nameof(Square)} (press \"{(int)Figures.Square}\")" +
                $"\n- {nameof(Rectangle)} (press \"{(int)Figures.Rectangle}\")" +
                $"\n- {nameof(Triangle)} (press \"{(int)Figures.Triangle}\")" +
                $"\n- {nameof(Circle)} (press \"{(int)Figures.Circle}\")" +
                $"\n====================================================";

        private readonly string _repeatMessage = "Wrong key. Please, try again.. Attempts: ";
        private readonly string _errorMessage = "\nToo many attempts.";
        private int Attempts = 3;
        private bool IsContinue = false;
        public int FigureKey { get; private set; }

        /// <summary>
        /// Метод ввода ключа геометрической фигуры
        /// </summary>
        /// <returns>
        /// true - 
        /// false - 
        /// </returns>
        public bool InputFigureKey()
        {
            GetFigureKey();

            return IsContinue;
        }

        /// <summary>
        /// Метод получения ключа геометрической фигуры
        /// </summary>
        private void GetFigureKey()
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
                & !(key == (int)Figures.Triangle)
                & !(key == (int)Figures.Circle))
                return false;

            FigureKey = key;
            return IsContinue = true;
        }
    }
}
