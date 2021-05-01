using System;
using System.Collections.Generic;
using System.Text;
using Test.Figure.Figures;
using Xunit;

namespace Test.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void TestTriangle()
        {
            double Square = 10.825317547305483;
            Assert.Equal(Square, new Triangle(5, 5, 5).GetSquare());
        }

        [Fact]
        public void IsrightTriangle()
        {
            Assert.False(new Triangle(5, 5, 5).IsRight);
        }


        [Fact]
        public void TestTriangleWithNegativNumbers()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-5, 5, -5).GetSquare());
        }
    }
}
