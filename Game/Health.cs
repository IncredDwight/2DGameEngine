using System;
namespace Game
{
	public class Health
	{
		private int _maxHealth;
		private int _health;

		public Health(int maxHealth)
		{
			_maxHealth = maxHealth;
			_health = _maxHealth;
		}

		public void TakeDamage(int damage)
		{
			_health -= damage;
			if (_health < 0)
			{
				_health = 0;
				Die();
			}
		}

		public void Heal(int heal)
		{
			_health += heal;
			if (_health > _maxHealth)
				_health = _maxHealth;
		}

		public int GetHealth()
		{
			return _health;
		}

		private void Die()
		{
			Console.WriteLine("Death");
		}
	}
}

