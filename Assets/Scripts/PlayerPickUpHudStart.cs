using UnityEngine;
using UnityEngine.UI;

public class PlayerPickUpHudStart : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		InteractableObject.itemUI = this.gameObject;
		InteractableObject.text = this.gameObject.GetComponent<RectTransform>().Find("PickUpText").gameObject.GetComponent<Text>();
	}
}
