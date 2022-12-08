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
			IsSolid = false;
		}

		public GameObject(int x, int y, char view, bool isSolid = true)
		{
			Position = new Vector2(x, y);
			View = view;
			IsSolid = isSolid;
		}
		

		public virtual void Update(GameField gameField)
		{

		}

		public virtual void OnCollision(GameObject collidedObject)
		{

		}
	}
}

