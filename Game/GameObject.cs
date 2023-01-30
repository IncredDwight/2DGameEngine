using System;
namespace Game
{
	public class GameObject
	{
		private Vector2F _position;
		public Vector2F Position
		{
			get { return _position; }
			set
			{
				//if (_gameField != null)
				{
					if (_gameField.IsFieldAvailable((int)value.X, (int)value.Y))
					{
						
						//Console.WriteLine("Succes " + _gameField.GetObject((int)value.X, (int)value.Y).View);
						_position.X = value.X;
						_position.Y = value.Y;
					}
				}
			}
		}
		public char View { get; protected set; }
		public bool IsSolid { get; protected set; }

		protected GameField _gameField;

		public GameObject(GameField gameField)
		{
			_position = new Vector2F(0, 0);
			View = ' ';
			_gameField = gameField;
		}

		public GameObject(int x, int y, char view, GameField gameField, bool isSolid = true)
		{
			_position = new Vector2F(x, y);
			View = view;
			IsSolid = isSolid;
			_gameField = gameField;
		}

		public GameObject(int x, int y, GameField gameField)
		{
			_position = new Vector2F(x, y);
			_gameField = gameField;
		}

        public virtual void Update()
		{

		}

		public virtual void OnCollision(GameObject collidedObject)
		{

		}
	}
}

