using System;
namespace Game
{
	public class MapBuilder
	{
		public void Build(GameField gameField)
		{
			GameObject horizontalWall = new GameObject(gameField);
			GameObject[,] field = gameField.GetGameField();

			for(int x = 0; x < field.GetLength(1); x++)
			{
				gameField.AddObject(new GameObject(x, 0, '-', gameField));
				gameField.AddObject(new GameObject(x, field.GetLength(0) - 1, '-', gameField));
			}

			for (int y = 0; y < field.GetLength(0); y++)
			{
				gameField.AddObject(new GameObject(0, y, '|', gameField));
				gameField.AddObject(new GameObject(field.GetLength(1) - 1, y, '|', gameField));
			}

			gameField.AddObject(new GameObject(5, 1, '|', gameField));
            gameField.AddObject(new GameObject(5, 2, '|', gameField));
            gameField.AddObject(new GameObject(5, 4, '|', gameField));
            gameField.AddObject(new GameObject(5, 5, '|', gameField));
            gameField.AddObject(new GameObject(6, 5, '-', gameField));
            gameField.AddObject(new GameObject(7, 5, '-', gameField));
            gameField.AddObject(new GameObject(8, 5, '-', gameField));
            gameField.AddObject(new GameObject(1, 12, '-', gameField));
            gameField.AddObject(new GameObject(2, 12, '-', gameField));
            gameField.AddObject(new GameObject(3, 12, '-', gameField));
            gameField.AddObject(new GameObject(4, 12, '-', gameField));
            gameField.AddObject(new GameObject(5, 12, '-', gameField));
            gameField.AddObject(new GameObject(6, 12, '-', gameField));
            gameField.AddObject(new GameObject(6, 13, '|', gameField));
            gameField.AddObject(new GameObject(6, 14, '|', gameField));
            gameField.AddObject(new GameObject(6, 15, '|', gameField));
            gameField.AddObject(new GameObject(6, 16, '|', gameField));

            gameField.AddObject(new GameObject(13, 13, 'B', gameField));
            gameField.AddObject(new GameObject(14, 14, 'A', gameField));
            gameField.AddObject(new GameObject(15, 15, 'L', gameField));
            gameField.AddObject(new GameObject(16, 16, 'L', gameField));
            gameField.AddObject(new GameObject(17, 17, 'S', gameField));
        }
	}
}

