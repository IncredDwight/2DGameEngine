using System;
namespace Game
{
	public class GameLoop
	{
		public void Start(GameField gameField, GameDisplay gameDisplay)
		{
            gameDisplay.Display(gameField);

            while (true)
			{
				gameField.Update();
                Console.Clear();
                gameDisplay.Display(gameField);
				
			}
		}
	}
}

