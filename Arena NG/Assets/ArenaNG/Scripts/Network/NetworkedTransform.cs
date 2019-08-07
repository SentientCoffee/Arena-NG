using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using BeardedManStudios.Forge.Networking.Generated;

public class NetworkedTransform : TransformBehavior {
	[SerializeField] private UnityEvent clientEvents;

	protected override void NetworkStart() {
		base.NetworkStart();

		if (!networkObject.IsServer) {
			clientEvents.Invoke();
		}
	}

	private void FixedUpdate() {
		if (networkObject.IsOwner) {
			networkObject.position = transform.position;
			networkObject.rotation = transform.rotation;
			networkObject.scale = transform.localScale;
		}
	}
}
