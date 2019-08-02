using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArenaNG {
	/// <summary>
	/// A collider that when touched by a player will send them upwards.
	/// </summary>
	public class JumpPad : MonoBehaviour {
		public Vector3 launchDirection;
		public Event onActivate;

		private void OnCollisionEnter(Collision collision) {
			if (collision.collider.CompareTag("Player")) {		// Check to see if it is a player.
				collision.gameObject.GetComponent<Rigidbody>().AddForce(launchDirection, ForceMode.Impulse);
			}
		}

		private void OnDrawGizmos() {
			Gizmos.color = Color.blue;
			Gizmos.DrawLine(transform.position, transform.position + launchDirection * 2.0f);
			Gizmos.DrawIcon(transform.position + Vector3.up, "jumping-dancer.png");
		}
	}
}
