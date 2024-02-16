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
                    services.AddTransient<IFigure>(_ => new Square(1));
                    break;
                case 2:
                    services.AddTransient<IFigure>(_ => new Rectangle(0.5, 80));
                    break;
                case 3:
                    services.AddTransient<IFigure>(_ => new Triangle(10, 5));
                    break;
                case 4:
                    services.AddTransient<IFigure>(_ => new Circle(0.56));
                    break;
            }

            return services;
        }
    }
}
