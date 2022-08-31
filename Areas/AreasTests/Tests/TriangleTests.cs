using Areas;
using Areas.Exceptions;
using NUnit.Framework;

namespace AreasTests.Tests
{
    [TestFixture]
    internal class TriangleTests
    {
        [SetUp]
        public void SetUp()
        {
            // pass
        }

        [TearDown]
        public void TearDown()
        {
            // pass
        }

        [TestCase(3, 4, 5, 6)]
        [TestCase(4, 5, 3, 6)]
        [TestCase(5, 3, 4, 6)]
        [TestCase(2, 3, 4, 2.90473751)]
        [TestCase(3, 4, 2, 2.90473751)]
        [TestCase(4, 2, 3, 2.90473751)]
        public void Area_ValidLines_TrueArea(double a, double b, double c, double expectedArea)
        {
            var actual = Area(a, b, c);
            Assert.That(actual, Is.EqualTo(expectedArea).Within(Consts.Epsilon));
        }

        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 1)]
        [TestCase(3, 1, 2)]
        [TestCase(1, 3, 1)]
        [TestCase(3, 1, 1)]
        [TestCase(1, 1, 3)]
        public void Area_NotTriangle_ArgumentException(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => Area(a, b, c));
        }

        [TestCase(-3, 4, 5)]
        [TestCase(3, -4, 5)]
        [TestCase(3, 4, -5)]
        [TestCase(-3, -4, 5)]
        [TestCase(-3, 4, -5)]
        [TestCase(3, -4, -5)]
        [TestCase(-3, -4, -5)]
        [TestCase(0, 4, 5)]
        [TestCase(3, 0, 5)]
        [TestCase(3, 4, 0)]
        [TestCase(0, 0, 5)]
        [TestCase(0, 4, 0)]
        [TestCase(3, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Area_InvalidLine_UnpositiveArgumentException(double a, double b, double c)
        {
            Assert.Throws<UnpositiveArgumentException>(() => Area(a, b, c));
        }

        private static double Area(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            return triangle.Area();
        }
    }
}
