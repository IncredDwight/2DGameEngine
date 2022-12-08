using System;
namespace Game
{
	public class Enemy : GameObject
	{
		private int _range;

		private Vector2 _startPosition;
		private int _direction = 1;

		private GameField _gameField;

		public Enemy(int x, int y, char view, int range) : base(x, y, view)
		{
			_range = range;
			_startPosition = new Vector2(x, y);
			IsSolid = true;
		}

		public override void Update(GameField gameField)
		{
			base.Update(gameField);
			Move();
		}
		
		private void Move()
		{
			
			Position.X+=_direction;
			if (Position.X >= _startPosition.X + _range || Position.X <= _startPosition.X - _range)
				_direction *= -1;
		}
    }
}

