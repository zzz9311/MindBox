using System;
using Xunit;
using Test.Figure.Figures;

namespace Test.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCircleWithMinusRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-10).GetSquare());
        }

        [Fact]
        public void TestCircle()
        {
            double Square = 314.1592653589793;
            Assert.Equal(Square, new Circle(10).GetSquare());
        }

        [Fact]
        public void TestCircleWith0Radius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0).GetSquare());
        }
    }
}
