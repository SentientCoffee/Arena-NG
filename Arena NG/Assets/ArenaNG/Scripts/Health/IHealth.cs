using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArenaNG {
	public interface IHealth<T> {

		void SetHealth(T amount);

		void SetMaxHealth(T amount);

		void Damage(T amount);

		void Heal(T amount);

		void Kill();
	}
}