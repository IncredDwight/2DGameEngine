using System;
namespace Game
{
	public class Player : GameObject
	{
        private Health _health;
        private GameField _gameField;



		public Player(int x, int y, char view) : base(x, y, view)
		{
            _health = new Health(5);
		}

        public override void Update(GameField gameField)
        {
            base.Update(gameField);
            _gameField = gameField;
            GetInput();
        }

        private void GetInput()
        {
            string input = Console.ReadLine();
            Vector2 nextPosition = new Vector2(Position.X, Position.Y);
            

            switch (input)
            {
                case "w":
                    nextPosition.Y--;
                    break;
                case "s":
                    nextPosition.Y++;
                    break;
                case "d":
                    nextPosition.X++;
                    break;
                case "a":
                    nextPosition.X--;
                    break;
            }

            if (_gameField.IsFieldAvailable(nextPosition.X, nextPosition.Y))
                Position = nextPosition;

        }
    }
}

