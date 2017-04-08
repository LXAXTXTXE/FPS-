using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour {

	[SerializeField]
	private GameObject bulletGameObjectBase;
	// Use this for initialization
	void Start () 
	{
		StartCoroutine (SpawnBulletCR(2F));	
	}
	private IEnumerator SpawnBulletCR(float time)
	{
		yield return new WaitForSeconds (time); 
		GameObject.Instantiate (bulletGameObjectBase); 
	}
}
