namespace Areas
{
    /// <inheritdoc/>
    public class Figure : IFigure
    {
        /// <summary>
        /// Текущий экземпляр
        /// </summary>
        public IFigure Instanсe { get; }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="figure">Экземпляр фигуры</param>
        public Figure(IFigure figure)
        {
            Instanсe = figure;
        }

        /// <inheritdoc/>
        public double Area()
        {
            return Instanсe.Area();
        }
    }
}
