using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffOrDebuffSpellRenderer : MonoBehaviour {

	private float rotateSpeed;
	private int rotateDirection;
	private float duration;
	private bool doneOpaquing = false;

	void Start(){
		foreach (Transform child in transform){
			Color c = child.gameObject.GetComponent<Renderer>().material.color;
			c.a = 0;
			child.gameObject.GetComponent<Renderer>().material.color = c;
		} 
		Destroy(gameObject, duration);

	}

	void Update(){
		if(!doneOpaquing){
			foreach (Transform child in transform){
				Color c = child.gameObject.GetComponent<Renderer>().material.color;
				c.a += Time.fixedDeltaTime * .5f;
				child.gameObject.GetComponent<Renderer>().material.color = c;
				if(child.gameObject.GetComponent<Renderer>().material.color.a > .5f) doneOpaquing = true;
			} 
		}
		duration -= Time.deltaTime;
		if(duration < .5f){
			foreach (Transform child in transform){
				Color c = child.gameObject.GetComponent<Renderer>().material.color;
				c.a -= Time.fixedDeltaTime * .5f;
				child.gameObject.GetComponent<Renderer>().material.color = c;
			}
		}
		transform.Rotate(0, rotateDirection * rotateSpeed * Time.deltaTime, 0);
	}

	public void SetUp(float RS, int RD, float D){
		rotateSpeed = RS;
		rotateDirection = RD;
		duration = D;
	}
}
