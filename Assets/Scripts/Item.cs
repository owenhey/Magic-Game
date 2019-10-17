using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IPointerClickHandler{
	public Sprite icon;
	public string itemName;
	public string itemDescription;
	public GameObject droppedItemPrefab;
	[HideInInspector] public static Text nameBox;
	[HideInInspector] public static Text descBox;
	[SerializeField] private GameObject inventoryRightClick;
	private static GameObject currentIventoryRightClick;

	public void OnPointerClick(PointerEventData pointerEventData){
		if(itemName != "" && itemName != null){
			if(pointerEventData.button == PointerEventData.InputButton.Right){
				if(currentIventoryRightClick){
					Destroy(currentIventoryRightClick);
				}
				GameObject uiRightClick = Instantiate(inventoryRightClick);
				currentIventoryRightClick = uiRightClick;
				uiRightClick.GetComponent<RectTransform>().GetChild(1).gameObject.GetComponent<dropAndUseItem>().SetUp(this.gameObject);
				uiRightClick.GetComponent<RectTransform>().SetParent(gameObject.GetComponent<RectTransform>().parent.parent, false);
				uiRightClick.GetComponent<RectTransform>().anchoredPosition = pointerEventData.position / gameObject.GetComponent<RectTransform>().parent.parent.gameObject.GetComponent<Canvas>().scaleFactor;
				
			}
			if(pointerEventData.button == PointerEventData.InputButton.Left){
				nameBox.text = itemName;
				descBox.text = itemDescription;
			}
		}
	}
	
}
