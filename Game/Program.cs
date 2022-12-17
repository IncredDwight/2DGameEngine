using System;

namespace Game
{
    class Program
    {
        public static void Main(string[] arg)
        {
            GameField gameField = new GameField(new Vector2(60, 60));
            MapBuilder mapBuilder = new MapBuilder();
            GameDisplay gameDisplay = new GameDisplay();
            GameLoop gameLoop = new GameLoop();

            mapBuilder.Build(gameField);

            Player player = new Player(1, 1, '@', gameField);
            Camera camera = new Camera(0, 0, ' ', gameField, player);

            gameField.AddObject(new Enemy(3, 3, '*', gameField, 1));
            gameField.AddObject(new Enemy(7, 7, '*', gameField, 1));
            gameField.AddObject(new Enemy(11, 15, '*', gameField, 1));
            gameField.AddObject(new Heal(11, 5, gameField, 1));
            gameField.AddObject(new Heal(3, 14, gameField, 1));


            gameField.AddObject(camera);
            gameField.AddObject(player);
            

            gameLoop.Start(gameField, gameDisplay, player, camera);
        }
    }
}