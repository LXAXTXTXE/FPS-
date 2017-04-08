using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_script : MonoBehaviour {
	public enum Pickup
	{
	Health,
	Ammo,
	Key,
	Armor,
	}

	public class PickupComponent : MonoBehaviour
	{
		[SerializeField]
		private void OnTriggerEnter(Collider othercollider)

		{
			if (othercollider.tag.Equals("Player"))
			{
				
				Debug.Log (string.Format ("El Player se chocó con un item de {0}"));

			}
	}

	}
}