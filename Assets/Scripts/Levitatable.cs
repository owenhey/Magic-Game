using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Levitatable : MonoBehaviour {

	public Vector3 levitateCenterDistance = new Vector3(0,0,0);

	void Awake(){
		if(!this.gameObject.GetComponent<Rigidbody>()){
			this.gameObject.AddComponent<Rigidbody>();
		}
	}

	void OnDrawGizmosSelected(){
		Gizmos.color = Color.red;
		Gizmos.DrawSphere(gameObject.transform.position + levitateCenterDistance, .5f);
	}
}
