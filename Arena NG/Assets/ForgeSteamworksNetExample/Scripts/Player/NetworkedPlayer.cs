using System;
using BeardedManStudios.Forge.Logging;
using BeardedManStudios.Forge.Networking;
using BeardedManStudios.Forge.Networking.Generated;
using BeardedManStudios.Forge.Networking.Unity;
using Steamworks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace ForgeSteamworksNETExample.Player {
	public class NetworkedPlayer : PlayerBehavior {
		[Serializable]
		public class ToggleEvent : UnityEvent<bool> {
		}

		/// <summary>
		/// Event triggered when a SetupPlayer RPC is called on this object.
		/// This is the place where other scripts can hook into the RPC call handling
		/// </summary>
		public event System.Action<RpcArgs> SetupPlayerEvent;

		/// <summary>
		/// Custom event for other scripts to hook into that need to run code when the
		/// NetworkStart event on the Owner object is called
		/// </summary>
		public event System.Action NetworkStartEvent;

		/// <summary>
		/// Scripts that should be enabled for the local client
		/// </summary>
		[SerializeField] private ToggleEvent localScripts;

		[SerializeField] private Rigidbody body;
		[SerializeField] private GameObject playerModel;
		[SerializeField] private ArenaNG.CharacterAnimator animator;

		private CSteamID steamId;

		private void Awake() {
			body = GetComponent<Rigidbody>();
			animator = playerModel.GetComponent<ArenaNG.CharacterAnimator>();
		}

		private void Start() {
			if (networkObject.IsOwner) {
				SkinnedMeshRenderer[] meshes = playerModel.GetComponentsInChildren<SkinnedMeshRenderer>();

				foreach (var mesh in meshes) {
					mesh.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
				}
			}
		}

		private void FixedUpdate() {
			if (networkObject.IsOwner) {
				// Send Transform
				networkObject.position = body.position;
				networkObject.rotation = body.rotation;
			}

			else {
				// Update Transform
				body.position = networkObject.position;
				body.rotation = networkObject.rotation;
				return;
			}
		}

		protected override void NetworkStart() {
			base.NetworkStart();

			// Enable all the scripts that are needed by the local client
			localScripts.Invoke(networkObject.IsOwner);

			if (networkObject.IsOwner) {
				if (NetworkStartEvent != null)
					NetworkStartEvent();
			}

			networkObject.rotation = Quaternion.identity;
			networkObject.rotationInterpolation.target = Quaternion.identity;
			networkObject.SnapInterpolations();

			if (NetworkManager.Instance.Networker is IServer) {
				// You can do server specific initialization here
			}
			else {
				NetworkManager.Instance.Networker.disconnected += OnDisconnect;
			}
		}

		private void OnDisconnect(NetWorker sender) {


			MainThreadManager.Run(() => {
				foreach (var netObject in sender.NetworkObjectList) {
					if (netObject.Owner.IsHost) {
						BMSLog.Log("Server disconnected");
						// Go back to the multiplayer menu
						SceneManager.LoadScene(0);
					}
				}
			});

			if (NetworkManager.Instance == null)
				return;

			NetworkManager.Instance.Networker.disconnected -= OnDisconnect;
			NetworkManager.Instance.Disconnect();
		}

		/// <summary>
		/// Set the <see cref="CSteamID"/> of this player
		/// </summary>
		/// <param name="steamId"></param>
		public void SetSteamId(ulong steamId) {
			this.steamId = (CSteamID)steamId;
		}

		/// <summary>
		/// Handle the SetupPlayer RPC call
		/// </summary>
		/// <param name="args"></param>
		public override void SetupPlayer(RpcArgs args) {
			if (SetupPlayerEvent != null)
				SetupPlayerEvent(args);
		}
	}
}
