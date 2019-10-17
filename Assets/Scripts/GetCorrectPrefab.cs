using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GetCorrectPrefab : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Item i = gameObject.GetComponent<Item>();
		i.droppedItemPrefab = Resources.Load<GameObject>("ItemPrefabs/" + i.itemName) as GameObject;
	}
}
