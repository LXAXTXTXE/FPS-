using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class Projectile : MonoBehaviour 
{
	private void OnTriggerEnter(Collider othercollider)
	{
		if (othercollider.tag.Equals("Player")) {
			Debug.Log ("El proyectil chocó con el player");
		}
		else if (othercollider.tag.Equals("Enemy")){
			Debug.Log ("El Proyectil choćo con un enemigo");
	}
		Destroy (this);
}
}
