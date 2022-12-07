using System;
namespace Game
{
	public class Player : GameObject
	{


		public Player(int x, int y, char view) : base(x, y, view)
		{

		}

        public override void Update()
        {
            base.Update();
            GetInput();
        }

        private void GetInput()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "w":
                    Position.Y--;
                    break;
                case "s":
                    Position.Y++;
                    break;
                case "d":
                    Position.X++;
                    break;
                case "a":
                    Position.X--;
                    break;
            }
        }
    }
}

