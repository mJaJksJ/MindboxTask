namespace Areas
{
    /// <inheritdoc/>
    public class Figure : IFigure
    {
        /// <summary>
        /// Текущий экземпляр
        /// </summary>
        public IFigure Instanse { get; }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="figure">Экземпляр фигуры</param>
        public Figure(IFigure figure)
        {
            Instanse = figure;
        }

        /// <inheritdoc/>
        public double Area()
        {
            return Instanse.Area();
        }
    }
}
