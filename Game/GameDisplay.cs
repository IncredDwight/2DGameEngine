using System;
namespace Game
{
	public class GameDisplay
	{
		public void Display(GameField gameField, Camera camera)
		{
			GameObject[,] field = gameField.GetGameField();
			Vector2F yAxis = new Vector2F(camera.Position.Y - camera.Size, camera.Position.Y + camera.Size);
			Vector2F xAxis = new Vector2F(camera.Position.X - camera.Size, camera.Position.X + camera.Size);
			yAxis.X = Math.Clamp(yAxis.X, 0, field.GetLength(0) - 1);
            yAxis.Y = Math.Clamp(yAxis.Y, 0, field.GetLength(0) - 1);
            xAxis.X = Math.Clamp(xAxis.X, 0, field.GetLength(1) - 1);
            xAxis.Y = Math.Clamp(xAxis.Y, 0, field.GetLength(1) - 1);

            for (int y = (int)yAxis.X; y <= (int)yAxis.Y; y++)
			{
				for (int x = (int)xAxis.X; x <= (int)xAxis.Y; x++)
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

