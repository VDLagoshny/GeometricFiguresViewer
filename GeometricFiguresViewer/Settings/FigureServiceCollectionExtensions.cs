using GeometricFiguresViewer.GeometricFigures;
using Microsoft.Extensions.DependencyInjection;

namespace GeometricFiguresViewer.Settings
{
    internal static class FigureServiceCollectionExtensions
    {
        internal static IServiceCollection RegisterFigure(this IServiceCollection services, int key) 
        { 
            switch (key)
            {
                case 1:
                    services.AddTransient<IFigure>(_ => new Square(6));
                    break;
                case 2:
                    services.AddTransient<IFigure>(_ => new Rectangle(7, 7));
                    break;
                case 3:
                    services.AddTransient<IFigure>(_ => new Triangle(10, 5));
                    break;
                case 4:
                    // вынос параметров в конфиг
                    services.AddTransient<IFigure>(_ => new Circle(1));
                    break;
            }

            return services;
        }
    }
}
