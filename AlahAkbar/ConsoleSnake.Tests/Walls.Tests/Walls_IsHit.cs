using Xunit;

namespace ConsoleSnake.Tests.WallsTests
{
    public class Walls_IsHit
    {
        [Fact]
        public void ShouldReturnTrue()
        {

            Components.Walls walls = Components.Walls.Instance;
            Components.Point point = new Components.Point(78, 23, 'd');


            bool result = walls.IsHit(point);


            Assert.True(result);
            
        }

        [Fact]
        public void ShouldReturnFalse()
        {

            Components.Walls walls = Components.Walls.Instance;
            Components.Point point = new Components.Point(77, 22, 'd');

            
            bool result = walls.IsHit(point);


            Assert.False(result);

        }
    }
}
