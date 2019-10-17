using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TitleScreenMouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {

	[SerializeField] private MainMenuDirective runner;

	public void OnPointerEnter(PointerEventData eventData){
		gameObject.GetComponent<RectTransform>().localScale = new Vector3(1.1f, 1.1f, 1.1f);
	}

	public void OnPointerExit(PointerEventData eventData){
		gameObject.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
	}

	public void OnPointerClick(PointerEventData eventData){
		runner.run(gameObject.name);
	}
}
