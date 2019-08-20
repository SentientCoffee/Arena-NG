using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArenaNG {
	public class Explosion : MonoBehaviour {
		public float radius = 5.0f;
		public float force = 10.0f;
		public float damage = 10.0f;
		public LayerMask layerMask;
		[SerializeField] private Collider[] hits;

		public void Start() {
			hits = Physics.OverlapSphere(transform.position, radius);

			foreach (var hit in hits) {
				if (hit.GetComponent<Rigidbody>()) {
					hit.GetComponent<Rigidbody>().AddExplosionForce(force, transform.position, radius);
				}

				if (hit.GetComponent<Character>()) {
					hit.GetComponent<Character>().Health.Damage(Mathf.RoundToInt(damage));
				}
			}
		}

		private void OnDrawGizmos() {
			Gizmos.color = Color.red;
			Gizmos.DrawWireSphere(transform.position, radius);
		}
	}
}
