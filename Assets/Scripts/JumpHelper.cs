using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpHelper : MonoBehaviour {

	public bool canMove;
	

	void OnTriggerEnter(){
		canMove = true;
	}

	void OnTriggerExit(){
		canMove = false;
	}

	void OnTriggerStay(){
		canMove = true;
	}
}
