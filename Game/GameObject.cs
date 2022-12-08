using System;
namespace Game
{
	public class GameObject
	{
		public Vector2 Position;
		public char View;
		public bool IsSolid { get; protected set; }

		public GameObject()
		{
			Position = new Vector2(0, 0);
			View = ' ';
			IsSolid = true;
		}

		public GameObject(int x, int y, char view, bool isSolid = true)
		{
			Position = new Vector2(x, y);
			View = view;
			IsSolid = true;
		}
		

		public virtual void Update(GameField gameField)
		{

		}
	}
}

