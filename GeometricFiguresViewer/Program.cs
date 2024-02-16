using GeometricFiguresViewer.DrawService;
using GeometricFiguresViewer.GraphicService;
using GeometricFiguresViewer.Settings;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            var uiService = new UserInterfaceService();
            var figureKey = uiService.GetFigureKey();

            var services = new ServiceCollection()
                .AddSingleton(new ConsoleSettings())
                .RegisterFigure(figureKey)
                .AddSingleton<IDrawService, DrawService>()
                .AddSingleton<IGraphicService, GraphicService>();
            var serviceProvider = services.BuildServiceProvider();

            
            var graphicService = serviceProvider.GetRequiredService<IGraphicService>();
            graphicService.GenerateGraphic();


            Console.ReadKey();
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("App stops..");
        }
    }
}