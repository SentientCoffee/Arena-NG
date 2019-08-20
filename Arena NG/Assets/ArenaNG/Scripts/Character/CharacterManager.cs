using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArenaNG {
	public class CharacterManager : Character {
		public Transform cameraTransform;
		public CharacterController characterController;
		public Rigidbody rb;
		public CharacterAnimator charAnim;

		[Header("Character Controller")]
		public float moveSpeed = 5.0f;
		public float jumpHeight = 2.0f;

		[SerializeField] private Vector3 physVelocity;

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

		private void Update() {
			characterController.Move(physVelocity * Time.deltaTime);

			if (characterController.isGrounded) {
				physVelocity = Physics.gravity * 2.0f * Time.deltaTime;
			}
			else {
				physVelocity += Physics.gravity * Time.deltaTime;
			}
		}

		public void Move() {

		}

		public void Jump() {
			if (characterController.isGrounded) {
				physVelocity.y += jumpHeight;
				charAnim.animator.SetTrigger("Jump");
			}
			else
				return;
		}

		public void Sprint() {

		}

		public void Crouch() {

		}
	}
}
