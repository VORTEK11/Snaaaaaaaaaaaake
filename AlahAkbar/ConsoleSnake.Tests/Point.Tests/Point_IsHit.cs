using Xunit;
using ConsoleSnake.Components;

namespace ConsoleSnake.Tests.Point.Tests
{
    public class Point_IsHit
    {
        [Fact]
        public void ShouldReturnTrueWithDifferentSymbol()
        {
            Components.Point point = new Components.Point(2, 3, 'a');
            Components.Point isHitPoint = new Components.Point(2, 3, 'b');

            bool result = point.IsHit(isHitPoint);


            Assert.True(result);

        }

        [Fact]
        public void ShouldReturnTrueWithSameSymbol()
        {

            Components.Point point = new Components.Point(2, 3, 'a');
            Components.Point isHitPoint = new Components.Point(2, 3, 'a');

            bool result = point.IsHit(isHitPoint);


            Assert.True(result);

        }

        [Fact]
        public void ShouldReturnFalse()
        {
            
            Components.Point point = new Components.Point(2, 2, 'a');
            Components.Point isHitPoint = new Components.Point(2, 3, 'b');


            bool result = point.IsHit(isHitPoint);

            Assert.False(result);

        }

    }
}
