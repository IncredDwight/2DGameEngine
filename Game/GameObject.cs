using System;
namespace Game
{
	public class GameObject
	{
		public Vector2 Position;
		public char View { get; protected set; }
		public bool IsSolid { get; protected set; }

		protected GameField _gameField;

		public GameObject(GameField gameField)
		{
			Position = new Vector2(0, 0);
			View = ' ';
			IsSolid = false;
			_gameField = gameField;
		}

		public GameObject(int x, int y, char view, GameField gameField, bool isSolid = true)
		{
			Position = new Vector2(x, y);
			View = view;
			IsSolid = isSolid;
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

