using Areas.Exceptions;

namespace Areas
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <exception cref="UnpositiveArgumentException"></exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new UnpositiveArgumentException();
            }

            Radius = radius;
        }

        /// <inheritdoc/>
        public double Area() => Math.PI * Radius * Radius;
    }
}
