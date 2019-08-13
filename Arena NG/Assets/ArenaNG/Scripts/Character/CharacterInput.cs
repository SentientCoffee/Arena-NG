using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ArenaNG {
	public class CharacterInput : MonoBehaviour {

		public void PrimaryFire(InputAction.CallbackContext context) {
			Debug.Log("Fire!");
		}

		public void SecondaryFire(InputAction.CallbackContext context) {

		}

		public void Reload(InputAction.CallbackContext context) {

		}

		public void ChangeSlot(InputAction.CallbackContext context) {

		}
	}
}
