using System;
namespace Game
{
	public class GameField
	{
		private GameObject[,] _field;
		private List<GameObject> _gameObjects;

		public GameField(Vector2 size)
		{
			_gameObjects = new List<GameObject>();
			_field = new GameObject[size.Y, size.X];
			for (int y = 0; y < _field.GetLength(0); y++)
			{
				for (int x = 0; x < _field.GetLength(1); x++)
				{
					_field[x, y] = new GameObject(this);
				}
			}
		}

		public void Update()
		{
			GameObject[] gameObjects = _gameObjects.ToArray();
			for (int i = 0; i < gameObjects.Length; i++)
			{
				gameObjects[i].Update();
				for (int j = i + 1; j < gameObjects.Length; j++)
				{
 					if (gameObjects[i].Position.X == gameObjects[j].Position.X && gameObjects[i].Position.Y == gameObjects[j].Position.Y)
					{
						gameObjects[i].OnCollision(gameObjects[j]);
						gameObjects[j].OnCollision(gameObjects[i]);
					}
                }
				
				
			}

            for (int y = 0; y < _field.GetLength(0); y++)
            {
                for (int x = 0; x < _field.GetLength(1); x++)
                {
					_field[x, y] = new GameObject(this);
					for (int i = 0; i < _gameObjects.Count; i++)
						if ((int)_gameObjects[i].Position.X == x && (int)_gameObjects[i].Position.Y == y)
							_field[x, y] = _gameObjects[i];
                }
            }
        }

		public void AddObject(GameObject gameobject)
		{
			_gameObjects.Add(gameobject);
		}

		public void RemoveObject(GameObject gameObject)
		{
			_gameObjects.Remove(gameObject);
		}

		public bool IsFieldAvailable(int x, int y)
		{
			if (x > _field.GetLength(1) - 1 || x < 0)
				return false;
			if (y > _field.GetLength(0) - 1 || y < 0)
				return false;

            if (_field[x, y].IsSolid)
                return false;

            return true;
		}

		public GameObject[,] GetGameField()
		{
			return _field;
		}

		public GameObject GetObject(int x, int y)
		{
			return _field[x, y];
		}
	}
}

