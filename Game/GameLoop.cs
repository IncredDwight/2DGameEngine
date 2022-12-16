using System;
namespace Game
{
	public class GameLoop
	{
		public void Start(GameField gameField, GameDisplay gameDisplay, Player player, Camera camera)
		{
			gameDisplay.Display(gameField, camera);


            while (true)
			{
				gameField.Update();
				//await Task.Delay(8);
				System.Threading.Thread.Sleep(8);
                Console.Clear();
                gameDisplay.DisplayHealth(player);
                gameDisplay.Display(gameField, camera);
				
			}
		}

	}
}

