using ConsoleSnake.Helpers;
using System;

namespace ConsoleSnake.Engine
{
    public static class ConsoleWriter
    {
        public static void ConfigureConsole()
        {
            try
            {
                Console.SetWindowSize(Constants.ConsoleWidth, Constants.ConsoleHeight);
            }
            catch(IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("Границы окна консоли находятся вне зоны действия");
            }
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(Constants.GameOverCursorPositionX, Constants.GameOverCursorPositionY);
            Console.WriteLine("Нажмите любую клавишу, чтобы начать игру!");
            Console.CursorVisible = false;
            Console.ReadKey();
            Console.Clear();
            Console.Beep();
        }

        public static void WriteGameOver()
        {
            Console.Clear();
            Console.SetCursorPosition(Constants.GameOverCursorPositionX, Constants.GameOverCursorPositionY);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ты проиграл. Нажмите любую клавишу, чтобы выйти из игры.");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public static void WritePoint(int x, int y, char symbol)
        {
            try
            {
                Console.SetCursorPosition(x, y);
            }
            catch
            {
                throw new IndexOutOfRangeException("Пытаюсь установить курсор на несуществующие координаты.");
            }
          
            Console.Write(symbol);
        }

        public static void WriteScore(int score)
        {
            Console.SetCursorPosition(2, Constants.ConsoleHeight - 2);
            Console.WriteLine($"Рекорд: {score}");
        }

    }
}
