using System;
namespace Game
{
	public class Enemy : GameObject
	{
		private int _range;

		private Vector2 _startPosition;
		private int _direction = 1;

		public Enemy(int x, int y, char view, int range) : base(x, y, view)
		{
			_range = range;
			_startPosition = new Vector2(x, y);
			IsSolid = false;
		}

		public override void Update(GameField gameField)
		{
			base.Update(gameField);
			Move(gameField);
		}
		
		private void Move(GameField gameField)
		{
			Vector2 nextPosition = new Vector2(Position.X, Position.Y);
			nextPosition.X += _direction;

			if (gameField.IsFieldAvailable(nextPosition.X, nextPosition.Y))
				Position = nextPosition;

			if (Position.X >= _startPosition.X + _range || Position.X <= _startPosition.X - _range)
				_direction *= -1;
		}
    }
}

