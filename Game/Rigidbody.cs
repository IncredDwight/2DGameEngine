using System;
namespace Game
{
	public class Rigidbody
	{
		public Vector2 Velocity;
		private Vector2 _position;

		private Vector2 _acceleration;
		private int _mass = 1;

		public Rigidbody(Vector2 position)
		{
			Velocity = new Vector2();
			_position = position;

			_acceleration = new Vector2();
			Start();
		}

		private async void Start()
		{
			await Task.Run(() =>
			{
				while (true)
				{
					Vector2 gravity = new Vector2(0, -1);
					_acceleration = new Vector2(gravity.X / _mass, gravity.Y / _mass);

					Velocity.X += _acceleration.X;
					Velocity.Y += _acceleration.Y;
					_position.X += Velocity.X;
					_position.Y -= Velocity.Y;
					Task.Delay(100).Wait();
				}
			});
		}
	}
}

