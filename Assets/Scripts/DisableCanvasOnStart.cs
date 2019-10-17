using UnityEngine;
using UnityEngine.UI;

public class DisableCanvasOnStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Canvas>().enabled = false;
	}
}
