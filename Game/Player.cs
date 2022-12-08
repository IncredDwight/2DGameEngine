using System;
namespace Game
{
	public class Player : GameObject
	{
        public Health Health;
        private GameField _gameField;



		public Player(int x, int y, char view) : base(x, y, view)
		{
            Health = new Health(5);
            IsSolid = false;
		}

        public override void Update(GameField gameField)
        {
            base.Update(gameField);
            _gameField = gameField;
            GetInput();
        }

        public override void OnCollision(GameObject collidedObject)
        {
            base.OnCollision(collidedObject);
            if(collidedObject.GetType() == typeof(Enemy))
            {
                Health.TakeDamage(1);
            }
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

