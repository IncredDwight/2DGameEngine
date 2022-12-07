using System;
namespace Game
{
	public class GameObject
	{
		public Vector2 Position;
		public char View;

		public GameObject()
		{
			Position = new Vector2(0, 0);
			View = ' '; 
		}

		public GameObject(int x, int y, char view)
		{
			Position = new Vector2(x, y);
			View = view;
		}

		public virtual void Update()
		{

		}
	}
}

