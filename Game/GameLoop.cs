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
                Console.Clear();
                gameDisplay.DisplayHealth(player);
                gameDisplay.Display(gameField, camera);
				
			}
		}

	}
}

