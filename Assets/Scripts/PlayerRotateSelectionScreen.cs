using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotateSelectionScreen : MonoBehaviour {

	[SerializeField] private float rotateSpeed = 10;

	[SerializeField] private GameObject hat;
	[SerializeField] private GameObject body;
	[SerializeField] private GameObject rightArm;
	[SerializeField] private GameObject leftArm;
	[SerializeField] private GameObject leftLeg;
	[SerializeField] private GameObject rightLeg;
	[SerializeField] private GameObject leftForeArm;
	[SerializeField] private GameObject rightForeArm;
	[SerializeField] private GameObject leftShin;
	[SerializeField] private GameObject rightShin;
	[SerializeField] private GameObject rightKnee;
	[SerializeField] private GameObject leftKnee;
	[SerializeField] private GameObject hair;

	[SerializeField] private Color hairStart;
	[SerializeField] private Color bodyStart;
	[SerializeField] private Color hatStart;
	
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		PlayerOptions.characterColors[0] = hatStart;
		PlayerOptions.characterColors[1] = bodyStart;
		PlayerOptions.characterColors[2] = bodyStart;
		PlayerOptions.characterColors[3] = bodyStart;
		PlayerOptions.characterColors[4] = hairStart;

		rb = GetComponent<Rigidbody>();
		rb.AddTorque(0, rotateSpeed, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.localEulerAngles.y > 30 && transform.localEulerAngles.y < 60){
			rb.AddTorque(0, -1f * rotateSpeed * Time.deltaTime, 0);
		}
		else if(transform.localEulerAngles.y < 330 && transform.localEulerAngles.y > 300){
			rb.AddTorque(0, rotateSpeed * Time.deltaTime, 0);
		}
	}

	public void ChangeHat(Color c){
		hat.GetComponent<Renderer>().material.color = c;
	}

	public void ChangeBody(Color c){
		body.GetComponent<Renderer>().material.color = c;
	}

	public void ChangeLegs(Color c){
		leftLeg.GetComponent<Renderer>().material.color = c;
		rightLeg.GetComponent<Renderer>().material.color = c;
		leftShin.GetComponent<Renderer>().material.color = c;
		rightShin.GetComponent<Renderer>().material.color = c;
		leftKnee.GetComponent<Renderer>().material.color = c;
		rightKnee.GetComponent<Renderer>().material.color = c;
	}

	public void ChangeArms(Color c){
		rightArm.GetComponent<Renderer>().material.color = c;
		leftArm.GetComponent<Renderer>().material.color = c;
		leftForeArm.GetComponent<Renderer>().material.color = c;
		rightForeArm.GetComponent<Renderer>().material.color = c;
	}

	public void ChangeHair(Color c){
		hair.GetComponent<Renderer>().material.color = c;
	}
}
