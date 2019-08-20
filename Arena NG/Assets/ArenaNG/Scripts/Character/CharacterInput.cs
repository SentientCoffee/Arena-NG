using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ArenaNG {
	public class CharacterInput : MonoBehaviour {
		[SerializeField] private CharacterManager character;
		[SerializeField] private bool lockCursor;

		[SerializeField] private Vector2 moveInput;
		[SerializeField] private Vector3 moveVector;

		private void Awake() {
			if (!character) {
				character = GetComponent<CharacterManager>();
			}
		}

		private void Update() {
			moveVector = transform.TransformDirection(new Vector3(moveInput.x, 0, moveInput.y));
			moveVector = Vector3.ClampMagnitude(moveVector, 1.0f) * character.moveSpeed;

			character.characterController.Move(moveVector * Time.deltaTime);
		}

		#region Input Functions
		public void OnLook(InputValue value) {
			var v = value.Get<Vector2>();
			float lookX = v.x * Time.deltaTime;
			float lookY = v.y * Time.deltaTime;

			character.cameraTransform.Rotate(Vector3.left * lookY);
			character.transform.Rotate(Vector3.up * lookX);
		}

		private void ClampXAxisRotationToValue(float value) {
			Vector3 eulerRotation = character.cameraTransform.eulerAngles;
			eulerRotation.x = value;
			character.cameraTransform.eulerAngles = eulerRotation;
		}

		public void OnMove(InputValue value) {
			moveInput = value.Get<Vector2>();
		}

		public void OnJump() {
			character.Jump();
		}

		public void OnSprint() {

		}

		public void OnCrouch() {

		}

		public void OnPrimaryFire() {

		}

		public void OnSecondaryFire() {

		}

		public void OnReload() {

		}

		public void OnContextUse() {

		}
		#endregion

		private void ToggleCursor() {
			ToggleCursor(!lockCursor);
		}

		private void ToggleCursor(bool value) {
			if (value == true) {
				lockCursor = true;
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
			}
			else {
				lockCursor = false;
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			}
		}

		#region System Functions
		public void OnMenu() {
			ToggleCursor();
		}
		#endregion
	}
}
