using Areas;
using Areas.Exceptions;
using NUnit.Framework;

namespace AreasTests.Tests
{
    [TestFixture()]
    internal class CircleTests
    {
        [SetUp]
        public void SetUp()
        {
            // pass
        }

        [TearDown]
        public void TearDown()
        {
            // nothing
        }

        [TestCase(1, Math.PI)]
        [TestCase(0.564189583, 1)]
        public void Area_ValidRadius_TrueArea(double radius, double expectedArea)
        {
            var actual = Area(radius);
            Assert.That(actual, Is.EqualTo(expectedArea).Within(Consts.Epsilon));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void Area_InvalidRadius_UnpositiveArgumentException(double radius)
        {
            Assert.Throws<UnpositiveArgumentException>(() => Area(radius));
        }

        private static double Area(double radius)
        {
            var circle = new Circle(radius);

            return circle.Area();
        }
    }
}
