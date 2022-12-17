using System;
namespace Game
{
	public class Player : GameObject
	{
        public Health Health;

        private Rigidbody _rigidbody;

		public Player(int x, int y, char view, GameField gameField) : base(x, y, view, gameField)
		{
            Health = new Health(5);
            _rigidbody = new Rigidbody(Position);
            IsSolid = false;
		}

        public override void Update()
        {
            base.Update();
            //Position.X += _rigidbody.Velocity.X;
            //Position.Y -= _rigidbody.Velocity.Y;
            //Console.WriteLine(Position.Y);
            //Console.ReadLine();
            GetInput();
        }

        public override void OnCollision(GameObject collidedObject)
        {
            base.OnCollision(collidedObject);
            if(collidedObject.GetType() == typeof(Enemy))
            {
                Health.TakeDamage(1);
                _gameField.RemoveObject(collidedObject);
            }
        }

        private async void GetInput()
        {
            string input = await Task.Run(() => Console.ReadLine());// Console.ReadLine();
            Vector2 nextPosition = new Vector2(Position.X, Position.Y);
            

            switch (input)
            {
                case "w":
                    _rigidbody.Velocity.Y = 5;
                    //nextPosition.Y--;
                    break;
                case "s":
                    _rigidbody.Velocity.Y = -1;
                    //nextPosition.Y++;
                    break;
                case "d":
                    _rigidbody.Velocity.X = 1;
                    //nextPosition.X++;
                    break;
                case "a":
                    _rigidbody.Velocity.X = -1;
                    //nextPosition.X--;
                    break;
            }

            if (_gameField.IsFieldAvailable(nextPosition.X, nextPosition.Y))
            {
                Position.X = nextPosition.X;
                Position.Y = nextPosition.Y;
            }

        }
    }
}

