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


		}
	}
}

