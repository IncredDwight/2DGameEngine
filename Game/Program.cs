using System;

namespace Game
{
    class Program
    {
        public static void Main(string[] arg)
        {
            GameField gameField = new GameField(new Vector2(15, 15));
            MapBuilder mapBuilder = new MapBuilder();
            GameDisplay gameDisplay = new GameDisplay();
            GameLoop gameLoop = new GameLoop();

            mapBuilder.Build(gameField);

            Player player = new Player(0, 1, '@', gameField);
            gameField.AddObject(new GameObject(4, 5, 'y', gameField));
            gameField.AddObject(new GameObject(1, 1, 'm', gameField));
            gameField.AddObject(new Enemy(2, 3, '*', gameField, 1));
            gameField.AddObject(player);

            gameLoop.Start(gameField, gameDisplay, player);
        }
    }
}