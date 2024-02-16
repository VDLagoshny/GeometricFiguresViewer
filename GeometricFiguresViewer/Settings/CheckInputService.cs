using GeometricFiguresViewer.GeometricFigures;

namespace GeometricFiguresViewer.Settings
{
    // ПЕРЕИМЕНОВАТЬ
    internal class CheckInputService
    {
        // вынос литералов куда-нибудь?
        private readonly string _titleMessage = 
                $"Please, choose figure:" +
                $"\n- {nameof(Square)} (press \"{(int)Figures.Square}\")" +
                $"\n- {nameof(Rectangle)} (press \"{(int)Figures.Rectangle}\")" +
                $"\n- {nameof(Triangle)} (press \"{(int)Figures.Triangle}\")" +
                $"\n- {nameof(Circle)} (press \"{(int)Figures.Circle}\")";

        private readonly string _repeatMessage = "Wrong key. Please, try again.. Attempts: ";
        private readonly string _errorMessage = "Too many attempts.";
        private int Attempts = 3;
        private bool IsContinue = false;
        public int FigureKey { get; private set; }


        public bool CheckFigureKey()
        {
            GetFigureKey();

            return IsContinue;
        }

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
                Console.WriteLine(_errorMessage); // поменять на исключение? или под каждый вид сделать свой
        }

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
