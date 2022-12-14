using System;
namespace Game
{
	public class GameDisplay
	{
		public void Display(GameField gameField, Camera camera)
		{
			GameObject[,] field = gameField.GetGameField();
			Vector2 yAxis = new Vector2(camera.Position.Y - camera.Size, camera.Position.Y + camera.Size);
			Vector2 xAxis = new Vector2(camera.Position.X - camera.Size, camera.Position.X + camera.Size);
			yAxis.X = Math.Clamp(yAxis.X, 0, field.GetLength(0) - 1);
            yAxis.Y = Math.Clamp(yAxis.Y, 0, field.GetLength(0) - 1);
            xAxis.X = Math.Clamp(xAxis.X, 0, field.GetLength(1) - 1);
            xAxis.Y = Math.Clamp(xAxis.Y, 0, field.GetLength(1) - 1);

            for (int y = yAxis.X; y <= yAxis.Y; y++)
			{
				for (int x = xAxis.X; x <= xAxis.Y; x++)
				{
					if (field[x, y].GetType() != typeof(Camera))
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

