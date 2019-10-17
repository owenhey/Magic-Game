using UnityEngine;
using UnityEngine.UI;

public class NameBoxAndDescBoxSetup : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		if(gameObject.name == "Item Name"){
			Item.nameBox = this.gameObject.GetComponent<Text>();
		}
		else if(gameObject.name == "Item Description"){
			Item.descBox = this.gameObject.GetComponent<Text>();
		}
	}
}
