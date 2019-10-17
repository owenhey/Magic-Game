using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HelpColorChangeCharSelect : MonoBehaviour {

	[SerializeField] private PlayerRotateSelectionScreen player;

	public void ChangeHat(Image img){
		player.ChangeHat(img.color);
		PlayerOptions.characterColors[0] = img.color;
	}

	public void ChangeBody(Image img){
		player.ChangeBody(img.color);
		PlayerOptions.characterColors[1] = img.color;
	}

	public void ChangeLegs(Image img){
		player.ChangeLegs(img.color);
		PlayerOptions.characterColors[2] = img.color;
	}

	public void ChangeArms(Image img){
		player.ChangeArms(img.color);
		PlayerOptions.characterColors[3] = img.color;
	}

	public void ChangeHair(Image img){
		player.ChangeHair(img.color);
		PlayerOptions.characterColors[4] = img.color;
	}

	public void StartGame(){
		SceneManager.LoadScene("Main Game");
	}
}
