using UnityEngine;
using UnityEngine.Events;

namespace SapphSky.CoreFramework {
	/// <summary>
	/// Modular component used to trigger events when a player interacts with it.
	/// </summary>
	public class TriggerVolume : MonoBehaviour {
		public bool playOnce = true, active = true;
		public UnityEvent onEnter, onStay, onExit;

		public void OnTriggerEnter(Collider other) {
			if (active) {
				if (other.CompareTag("Player")) {
					onEnter.Invoke();
				}
			}
		}

		public void OnTriggerStay(Collider other) {
			if (active) {
				if (other.CompareTag("Player")) {
					onStay.Invoke();
				}
			}
		}

		public void OnTriggerExit(Collider other) {
			if (active) {
				if (other.CompareTag("Player")) {
					onExit.Invoke();
					if (playOnce) {
						active = false;
					}
				}
			}
		}
	}
}
