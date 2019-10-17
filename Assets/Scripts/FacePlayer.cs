using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour {
	
	Transform player;

	void Start(){
		player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
	}
	// Update is called once per frame
	void Update () {
		transform.LookAt(player);
	}
}
