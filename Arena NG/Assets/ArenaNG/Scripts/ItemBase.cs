using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArenaNG {
	public abstract class ItemBase : MonoBehaviour {
		public WeaponData weaponData;
		public Transform muzzleTransform;
		
		protected virtual void OnFire() {
			
		}

		public void ShootHitscan() {
			RaycastHit hit;

			if (Physics.Raycast(muzzleTransform.position, muzzleTransform.TransformDirection(muzzleTransform.forward), out hit)) {
				
			}
		}
	}
}
