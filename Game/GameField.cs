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
					_field[x, y] = new GameObject();
				}
			}
		}

		public void Update()
		{
			for (int i = 0; i < _gameObjects.Count; i++)
				_gameObjects[i].Update(this);

            for (int y = 0; y < _field.GetLength(0); y++)
            {
                for (int x = 0; x < _field.GetLength(1); x++)
                {
					_field[x, y] = new GameObject();
					for (int i = 0; i < _gameObjects.Count; i++)
						if (_gameObjects[i].Position.X == x && _gameObjects[i].Position.Y == y)
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
	}
}

