using System;
namespace Game
{
	public class GameLoop
	{
		public void Start(GameField gameField, GameDisplay gameDisplay, Player player)
		{
            gameDisplay.Display(gameField);

            while (true)
			{
				gameField.Update();
                Console.Clear();
                gameDisplay.DisplayHealth(player);
                gameDisplay.Display(gameField);
				
			}
		}
	}
}

