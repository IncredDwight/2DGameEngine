using System;
namespace Game
{
	public class GameField
	{
		private GameObject[,] _gameField;
		private List<GameObject> _gameObjects;

		public GameField(Vector2 size)
		{
			_gameObjects = new List<GameObject>();
			_gameField = new GameObject[size.Y, size.X];
			for (int y = 0; y < _gameField.GetLength(0); y++)
			{
				for (int x = 0; x < _gameField.GetLength(1); x++)
				{
					_gameField[x, y] = new GameObject();
				}
			}
		}

		public void Update()
		{
			for (int i = 0; i < _gameObjects.Count; i++)
				_gameObjects[i].Update();

            for (int y = 0; y < _gameField.GetLength(0); y++)
            {
                for (int x = 0; x < _gameField.GetLength(1); x++)
                {
					for (int i = 0; i < _gameObjects.Count; i++)
						if (_gameObjects[i].Position.X == x && _gameObjects[i].Position.Y == y)
							_gameField[x, y] = _gameObjects[i];
						else
							_gameField[x, y] = new GameObject();
                }
            }
        }

		public void AddObject(GameObject gameobject)
		{
			_gameObjects.Add(gameobject);
		}
	}
}

