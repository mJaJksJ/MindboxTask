using Areas;
using NUnit.Framework;

namespace AreasTests.Tests
{
    [TestFixture]
    public class FigureTests
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

        [Test]
        public void TestTriangle()
        {
            var figure = new Figure(new Triangle(3, 4, 5));

            Assert.DoesNotThrow(() => figure.Area());
        }

        [Test]
        public void TestCircle()
        {
            var figure = new Figure(new Circle(1));

            Assert.DoesNotThrow(() => figure.Area());
        }
    }
}
