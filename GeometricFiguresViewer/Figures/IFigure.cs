namespace GeometricFiguresViewer.Figures
{
    internal interface IFigure
    {
        string Name { get; }


        long GetPerimeter();
        long GetSquare();
        char[] GetGraphicForm();
    }
}
