using System;
namespace Game
{
	public class GameLoop
	{
		public async void Start(GameField gameField, GameDisplay gameDisplay, Player player, Camera camera)
		{
            //gameField.Update();
            gameDisplay.Display(gameField, camera);

			//await Task.Run(() =>
			{
				while (true)
				{
					gameField.Update();
					//await Task.Delay(8);
					//Task.Delay(8).Wait();
					System.Threading.Thread.Sleep(100);
					Console.Clear();
					gameDisplay.DisplayHealth(player);
					gameDisplay.Display(gameField, camera);
					//Task.Delay(100).Wait();

				}
			}
		}

	}
}

