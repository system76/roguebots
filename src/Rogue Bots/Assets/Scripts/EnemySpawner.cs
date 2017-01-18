using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject BotPrefab;
	public float count = 0;


	// Use this for initialization
	void Start () {
		spawnBots ();
	}



	// Update is called once per frame
	void Update () {
	}

	void spawnBots() {
		foreach (Transform child in transform) {
			GameObject enemy = Instantiate (BotPrefab, child.transform.position, Quaternion.identity) as GameObject;
			enemy.transform.parent = child;	
		}
	}
}
