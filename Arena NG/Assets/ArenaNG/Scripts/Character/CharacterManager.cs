using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArenaNG {
	public class CharacterManager : Character {
		// Components
		public Transform cameraTransform;
		public CharacterController characterController;
		public Rigidbody rb;

		public CharacterAnimator charAnim;
		public Health health;

		[Header("Character Controller")]
		public float moveSpeed;

		private void Awake() {
			if (!cameraTransform) {
				// Refer to this transform to move the camera.
				cameraTransform = Camera.main.transform;
			}

			characterController = GetComponent<CharacterController>();
			rb = GetComponent<Rigidbody>();

			/* Note: While CharacterControllers do not actually use physics,
			Rigidbodies are required to run methods for collisions and triggers. */
		}

		private void Start() {
			
		}

		private void Update() {
			
		}

		private void FixedUpdate() {
			
		}
	}
}
