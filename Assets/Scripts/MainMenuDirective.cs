using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuDirective : MonoBehaviour {

	public void run(string name){
		if(name == "Quit"){
			Application.Quit();
		}
		else if(name == "Load Game"){
			SceneManager.LoadScene("Bumbleberry");	
		}
	}
}
