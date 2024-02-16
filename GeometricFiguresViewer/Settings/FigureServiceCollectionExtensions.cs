using GeometricFiguresViewer.GeometricFigures;
using Microsoft.Extensions.DependencyInjection;

namespace GeometricFiguresViewer.Settings
{
    /// <summary>
    /// Метод расширения IServiceCollection для 
    /// ассоциации IFigure с конкретным типом фигуры
    /// </summary>
    internal static class FigureServiceCollectionExtensions
    {
        internal static IServiceCollection RegisterFigure(this IServiceCollection services, int key) 
        { 
            switch (key)
            {
                case 1:
                    services.AddTransient<IFigure>(_ => new Square(0.8));
                    break;
                case 2:
                    services.AddTransient<IFigure>(_ => new Rectangle(1.5, 0.5));
                    break;
                case 3:
                    services.AddTransient<IFigure>(_ => new Circle(0.56));
                    break;
            }

            return services;
        }
    }
}
