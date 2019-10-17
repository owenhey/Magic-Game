using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCharacter : MonoBehaviour {

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

	// Use this for initialization
	
	void Start(){
		hat.GetComponent<Renderer>().material.color = PlayerOptions.characterColors[0];
		body.GetComponent<Renderer>().material.color = PlayerOptions.characterColors[1];
		rightLeg.GetComponent<Renderer>().material.color = PlayerOptions.characterColors[2];
		leftLeg.GetComponent<Renderer>().material.color = PlayerOptions.characterColors[2];
		leftShin.GetComponent<Renderer>().material.color = PlayerOptions.characterColors[2];
		rightShin.GetComponent<Renderer>().material.color = PlayerOptions.characterColors[2];
		rightKnee.GetComponent<Renderer>().material.color = PlayerOptions.characterColors[2];
		leftKnee.GetComponent<Renderer>().material.color = PlayerOptions.characterColors[2];
		rightArm.GetComponent<Renderer>().material.color = PlayerOptions.characterColors[3];
		leftArm.GetComponent<Renderer>().material.color = PlayerOptions.characterColors[3];
		rightForeArm.GetComponent<Renderer>().material.color = PlayerOptions.characterColors[3];
		leftForeArm.GetComponent<Renderer>().material.color = PlayerOptions.characterColors[3];
		hair.GetComponent<Renderer>().material.color = PlayerOptions.characterColors[4];
	}
		
}
