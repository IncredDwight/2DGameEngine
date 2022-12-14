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

            Player player = new Player(1, 1, '@', gameField);
            Camera camera = new Camera(0, 0, ' ', gameField, player);
            //gameField.AddObject(new GameObject(4, 5, 'y', gameField));
            //gameField.AddObject(new GameObject(1, 1, 'm', gameField));
            gameField.AddObject(new Enemy(3, 3, '*', gameField, 1));
            gameField.AddObject(new Heal(5, 5, gameField, 1));
            gameField.AddObject(new Heal(8, 5, gameField, 1));
            gameField.AddObject(new Enemy(2, 3, '*', gameField, 1));
            gameField.AddObject(new Enemy(6, 4, 'o', gameField, 1));
            //gameField.AddObject(new GameObject(8, 8, 'm', gameField));


            gameField.AddObject(camera);
            gameField.AddObject(player);
            

            gameLoop.Start(gameField, gameDisplay, player, camera);
        }
    }
}