using System;
namespace Game
{
	public class GameDisplay
	{
		public GameDisplay(GameField gameField)
		{
			GameObject[,] field = gameField.GetGameField();
			for (int y = 0; y < field.GetLength(0); y++)
			{
				for (int x = 0; x < field.GetLength(1); x++)
				{
					Console.Write(field[x, y].View);
				}
				Console.WriteLine();
			}
		}
	}
}

