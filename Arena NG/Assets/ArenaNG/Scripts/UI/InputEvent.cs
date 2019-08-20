using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputEvent : MonoBehaviour {
	public string message;
	public string inputName;

	private void Update() {
		if (Input.GetButtonDown(inputName)) {
			SendMessage(message);
		}
	}
}
