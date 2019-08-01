using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArenaNG {
	[CreateAssetMenu(fileName = "Weapon Data", menuName = "Arena NG/Weapon Data")]
	public class WeaponData : ScriptableObject {
		[System.Serializable]
		public struct Metadata {
			public string itemName;
			[TextArea] public string itemDesc;
			public Sprite itemIcon;
			public Sprite itemKillIcon;

			[Header("Input")]
			public string primaryFunction;
			public string secondaryFunction;
			public string reloadFunction;
		}

		public Metadata metadata;

		[Header("Visuals")]
		public GameObject worldModel;
		public GameObject firstPersonModel;
		public GameObject fireEffect;

		[Header("Stats")]
		public int baseDamage;
		public int pelletCount;
		public float fireDelay;
		public int maxAmmoCapacity;
	}
}
