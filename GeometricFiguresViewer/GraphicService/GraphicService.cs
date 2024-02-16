using GeometricFiguresViewer.DrawService;
using GeometricFiguresViewer.GeometricFigures;
using GeometricFiguresViewer.Settings;

namespace GeometricFiguresViewer.GraphicService
{
    /// <summary>
    /// Класс графического сервиса
    /// </summary>
    internal sealed class GraphicService: IGraphicService
    {
        private IFigure _figure;
        private IDrawService _drawService;
        private ConsoleSettings _settings;

        public GraphicService(IFigure figure, IDrawService drawService, ConsoleSettings settings) 
        {
            _figure = figure;
            _drawService = drawService;
            _settings = settings;
        }

        /// <summary>
        /// Метод создания графического 
        /// отображения в консоли
        /// </summary>
        public void GenerateGraphic()
        {
            var figure = _figure.GetGraphicForm(_settings);
            _drawService.Draw(figure);
        }
    }
}
