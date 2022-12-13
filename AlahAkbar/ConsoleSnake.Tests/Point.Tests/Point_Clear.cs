using Xunit;
using ConsoleSnake.Components;

namespace ConsoleSnake.Tests.Point.Tests
{
    public class Point_Clear
    {
        [Fact]
        public void ShouldClearSymbol()
        {
            Components.Point point = new Components.Point(2, 3, 'a');

            point.Clear();

            Assert.Equal(' ', point.Symbol);
        }
    }
}
