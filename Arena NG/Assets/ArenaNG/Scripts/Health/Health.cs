using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArenaNG {
	public class Health : IHealth<int> {
		public int health;
		public int maxHealth;

		public virtual void Damage(int amount) {
			health -= amount;
		}

		public virtual void Heal(int amount) {
			health += amount;
		}

		public virtual void Kill() {
			health = 0;
		}

		public virtual void SetHealth(int amount) {
			health = amount;
		}

		public virtual void SetMaxHealth(int amount) {
			maxHealth = amount;
		}
	}
}