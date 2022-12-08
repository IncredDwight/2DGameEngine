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
            //gameField.AddObject(new GameObject(3, 3, '%'));
            gameField.AddObject(new GameObject(4, 5, 'y'));
            gameField.AddObject(new GameObject(1, 1, 'm'));
            gameField.AddObject(new Player(0, 0, '@'));
            gameField.AddObject(new Enemy(2, 3, '*', 1));

            gameLoop.Start(gameField, gameDisplay);


            
        }
    }
}