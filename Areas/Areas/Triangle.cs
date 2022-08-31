using Areas.Exceptions;

namespace Areas
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IFigure
    {
        /// <summary>
        /// Линия 'a'
        /// </summary>
        public double LineA { get; }

        /// <summary>
        /// Линия 'b'
        /// </summary>
        public double LineB { get; }

        /// <summary>
        /// Линия 'c'
        /// </summary>
        public double LineC { get; }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRight => CheckRight(LineA, LineB, LineC) || CheckRight(LineB, LineC, LineA) || CheckRight(LineC, LineA, LineB);

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <param name="cathetus1">Первый катет</param>
        /// <param name="cathetus2">Второй катет</param>
        /// <param name="hypotenuse">Гипотенуза</param>
        public bool CheckRight(out double cathetus1, out double cathetus2, out double hypotenuse)
        {
            if (CheckRight(LineA, LineB, LineC))
            {
                cathetus1 = LineA;
                cathetus2 = LineB;
                hypotenuse = LineC;
                return true;
            }

            if (CheckRight(LineB, LineC, LineA))
            {
                cathetus1 = LineB;
                cathetus2 = LineC;
                hypotenuse = LineA;
                return true;
            }

            if (CheckRight(LineC, LineA, LineB))
            {
                cathetus1 = LineC;
                cathetus2 = LineA;
                hypotenuse = LineB;
                return true;
            }

            cathetus1 = default;
            cathetus2 = default;
            hypotenuse = default;
            return false;
        }

        /// <summary>
        /// .ctor <br/>
        /// a, b, c - стороны треугольника
        /// </summary>
        /// <exception cref="UnpositiveArgumentException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new UnpositiveArgumentException();
            }

            if (!CheckIsTriangle(a, b, c) || !CheckIsTriangle(b, c, a) || !CheckIsTriangle(c, a, b))
            {
                throw new ArgumentException("Line have not triangle lengths");
            }

            LineA = a;
            LineB = b;
            LineC = c;
        }

        /// <inheritdoc/>
        public double Area()
        {
            if (CheckRight(out var cathetus1, out var cathetus2, out var hypotenuse))
            {
                return 0.5 * cathetus1 * cathetus2;
            }

            // Heron's formula
            var s = 0.5 * (LineA + LineB + LineC);
            return Math.Sqrt(s * (s - LineA) * (s - LineB) * (s - LineC));
        }

        private static bool CheckRight(double line1, double line2, double line3) => Math.Abs((line1 * line1) + (line2 * line2) - (line3 * line3)) < Consts.Epsilon;

        private static bool CheckIsTriangle(double line1, double line2, double line3)
        {
            var eps = line1 + line2 - line3;
            return eps > Consts.Epsilon;
        }
    }
}
