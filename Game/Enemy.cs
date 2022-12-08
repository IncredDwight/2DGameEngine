using System;
namespace Game
{
	public class Enemy : GameObject
	{
		private int _range;

		private Vector2 _startPosition;
		private int _direction = 1;

		public Enemy(int x, int y, char view, GameField gameField, int range) : base(x, y, view, gameField)
		{
			_range = range;
			_startPosition = new Vector2(x, y);
			IsSolid = false;
		}

		public override void Update()
		{
			base.Update();
			Move();
		}
		
		private void Move()
		{
			Vector2 nextPosition = new Vector2(Position.X, Position.Y);
			nextPosition.X += _direction;

			if (_gameField.IsFieldAvailable(nextPosition.X, nextPosition.Y))
				Position = nextPosition;

			if (Position.X >= _startPosition.X + _range || Position.X <= _startPosition.X - _range)
				_direction *= -1;
		}
    }
}

