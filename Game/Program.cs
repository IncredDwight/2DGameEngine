using System;

namespace Game
{
    class Program
    {
        public static void Main(string[] arg)
        {
            GameField gameField = new GameField(new Vector2(10, 10));
            GameDisplay gameDisplay = new GameDisplay();
            GameLoop gameLoop = new GameLoop();

            Player player = new Player(0, 0, '@', gameField);
            gameField.AddObject(new GameObject(4, 5, 'y', gameField));
            gameField.AddObject(new GameObject(1, 1, 'm', gameField));
            gameField.AddObject(new Enemy(2, 3, '*', gameField, 1));
            gameField.AddObject(player);

            gameLoop.Start(gameField, gameDisplay, player);
        }
    }
}