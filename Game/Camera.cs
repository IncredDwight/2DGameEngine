using System;
namespace Game
{
	public class Camera : GameObject
	{
        public int Size { get; private set; }

        private GameObject _target;

		public Camera(int x, int y, char view, GameField gameField, GameObject target) : base(x, y, view, gameField)
		{
            _target = target;

            IsSolid = false;
            Size = 6;
		}

        public override void Update()
        {
            base.Update();
            Position = _target.Position;
            //Console.WriteLine(Position.X);
            //Console.ReadLine();
        }
    }
}

