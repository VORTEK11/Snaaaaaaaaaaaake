using Xunit;

namespace ConsoleSnake.Tests.Snake.Tests
{
    public class Snake_Move
    {
        [Fact]
        public void ShouldMoveToNextPointDown()
        {

            Components.Snake snake = Components.Snake.Instance;
            Helpers.InputHandler inputHandler = new Helpers.InputHandler();
            snake.Head.X = Helpers.Constants.SnakeStartPointX;
            snake.Head.Y = Helpers.Constants.SnakeStartPointY;
            snake.NextMove = snake.MoveDown;


            inputHandler.KeyPressed(System.ConsoleKey.DownArrow);
            snake.NextMove.Invoke();

            Assert.Equal(snake.MoveDown, snake.NextMove);
            Assert.Equal(7, snake.Head.Y);
            Assert.Equal(4, snake.Head.X);
        }

        [Fact]
        public void ShouldMoveToNextPointLeft()
        {
            
            Components.Snake snake = Components.Snake.Instance;
            Helpers.InputHandler inputHandler = new Helpers.InputHandler();
            snake.Head.X = Helpers.Constants.SnakeStartPointX;
            snake.Head.Y = Helpers.Constants.SnakeStartPointY;
            snake.NextMove = snake.MoveRight;

           
            inputHandler.KeyPressed(System.ConsoleKey.LeftArrow);
            snake.NextMove.Invoke();

            Assert.Equal(snake.MoveLeft, snake.NextMove);
            Assert.Equal(6, snake.Head.Y);
            Assert.Equal(3, snake.Head.X);
        }

        [Fact]
        public void ShouldMoveToNextPointUp()
        {
 
            Components.Snake snake = Components.Snake.Instance;
            Helpers.InputHandler inputHandler = new Helpers.InputHandler();
            snake.Head.X = Helpers.Constants.SnakeStartPointX;
            snake.Head.Y = Helpers.Constants.SnakeStartPointY;
            snake.NextMove = snake.MoveUp;

            inputHandler.KeyPressed(System.ConsoleKey.UpArrow);
            snake.NextMove.Invoke();


            Assert.Equal(snake.MoveUp, snake.NextMove);
            Assert.Equal(5, snake.Head.Y);
            Assert.Equal(4, snake.Head.X);
        }

        [Fact]
        public void ShouldMoveToNextPointRight()
        {
 
            Components.Snake snake = Components.Snake.Instance;
            Helpers.InputHandler inputHandler = new Helpers.InputHandler();
            snake.Head.X = Helpers.Constants.SnakeStartPointX;
            snake.Head.Y = Helpers.Constants.SnakeStartPointY;
            snake.NextMove = snake.MoveRight;


            inputHandler.KeyPressed(System.ConsoleKey.RightArrow);
            snake.NextMove.Invoke();

            
            Assert.True(snake.IsHitTail());
            Assert.Equal(snake.MoveRight, snake.NextMove);
            Assert.Equal(6, snake.Head.Y);
            Assert.Equal(5, snake.Head.X);
        }

        [Fact]
        public void ShouldMakeAHit()
        {
             
            Components.Snake snake = Components.Snake.Instance;
            Helpers.InputHandler inputHandler = new Helpers.InputHandler();
            snake.Head.X = Helpers.Constants.SnakeStartPointX;
            snake.Head.Y = Helpers.Constants.SnakeStartPointY;
            snake.NextMove = snake.MoveRight;

            
            inputHandler.KeyPressed(System.ConsoleKey.DownArrow);
            snake.NextMove.Invoke();
            inputHandler.KeyPressed(System.ConsoleKey.LeftArrow);
            snake.NextMove.Invoke();
            inputHandler.KeyPressed(System.ConsoleKey.UpArrow);
            snake.NextMove.Invoke();
            inputHandler.KeyPressed(System.ConsoleKey.RightArrow);
            snake.NextMove.Invoke();

            
            Assert.True(snake.IsHitTail());

        }
    }
}
