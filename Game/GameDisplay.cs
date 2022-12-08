using System;
namespace Game
{
	public class GameDisplay
	{
		public void Display(GameField gameField)
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
		public void DisplayHealth(Player player)
		{
			Console.WriteLine($"Health: {player.Health.GetHealth()}");
		}
	}
}

