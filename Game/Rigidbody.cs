using System;
namespace Game
{
	public class Rigidbody
	{
		public Vector2F Velocity;
		private Vector2F _position;

		private Vector2F _acceleration;
		private float _mass = 1;

		public Rigidbody(Vector2F position)
		{
			Velocity = new Vector2F();
			_position = position;

			_acceleration = new Vector2F();
			Start();
		}

		private async void Start()
		{
			await Task.Run(() =>
			{
				while (true)
				{
					float time = 0.1f;
					Vector2F gravity = new Vector2F(0, -9.8f);
					_acceleration = new Vector2F(gravity.X / _mass, gravity.Y / _mass);

					Velocity.X += _acceleration.X * time;
					Velocity.Y += _acceleration.Y * time;
					_position.X += Velocity.X * time;
					_position.Y -= Velocity.Y * time;
					//Console.WriteLine(_position.X);
					Task.Delay(100).Wait();
				}
			});
		}
	}
}

