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
				_gameObjects[i].Update();

            for (int y = 0; y < _field.GetLength(0); y++)
            {
                for (int x = 0; x < _field.GetLength(1); x++)
                {
					for (int i = 0; i < _gameObjects.Count; i++)
						if (_gameObjects[i].Position.X == x && _gameObjects[i].Position.Y == y)
							_field[x, y] = _gameObjects[i];
						else
							_field[x, y] = new GameObject();
                }
            }
        }

		public void AddObject(GameObject gameobject)
		{
			_gameObjects.Add(gameobject);
		}

		public GameObject[,] GetGameField()
		{
			return _field;
		}
	}
}

