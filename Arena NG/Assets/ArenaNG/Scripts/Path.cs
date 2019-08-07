using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArenaNG {
	public class Path : MonoBehaviour {
		[SerializeField] private int targetID;
		public List<Transform> points = new List<Transform>();
		float speed = 1.0f;

		private void Update() {
			if (transform.position == points[targetID].position) {
				points.Reverse();
			}
			
			float step = speed * Time.deltaTime; // calculate distance to move
			transform.position = Vector3.MoveTowards(transform.position, points[targetID].position, step);
		}
	}
}
