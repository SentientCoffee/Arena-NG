using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using BeardedManStudios.Forge.Networking.Generated;

public class NetworkedTransform : TransformBehavior {
	[SerializeField] private bool syncPosition = true;
	[SerializeField] private bool syncRotation = true;
	[SerializeField] private bool syncScale;

	[SerializeField] private UnityEvent clientEvents;

	protected override void NetworkStart() {
		base.NetworkStart();

		if (!networkObject.IsOwner) {
			clientEvents.Invoke();
		}
	}

	private void FixedUpdate() {
		if (networkObject.IsOwner) {
			if (syncPosition) {
				networkObject.position = transform.position;
			}

			if (syncRotation) {
				networkObject.rotation = transform.rotation;
			}

			if (syncScale) {
				networkObject.scale = transform.localScale;
			}

		}

		else {
			if (syncPosition) {
				transform.position = networkObject.position;
			}

			if (syncRotation) {
				transform.rotation = networkObject.rotation;
			}

			if (syncScale) {
				transform.localScale = networkObject.scale;
			}
		}
	}
}
