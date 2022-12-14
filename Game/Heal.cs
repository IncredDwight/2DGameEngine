using System;
namespace Game
{
	public class Heal : GameObject
	{
		private int _healAmount;

		public Heal(int x, int y, GameField gameField, int heal) : base(x, y, gameField)
		{
			_healAmount = heal;
			View = '+';
		}

        public override void OnCollision(GameObject collidedObject)
        {
            base.OnCollision(collidedObject);
			if(collidedObject.GetType() == typeof(Player))
			{
				Player player = (Player)collidedObject;
				player.Health.Heal(_healAmount);
				_gameField.RemoveObject(this);
			}
        }


    }
}

