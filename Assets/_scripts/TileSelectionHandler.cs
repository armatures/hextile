using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileSelectionHandler : MonoBehaviour {
	public static List<GameObject> selectedObjects = new List<GameObject>();
	private Color defaultColor;

	void OnMouseUp() {
		if(selectedObjects.Contains (gameObject)){
			selectedObjects.Remove(gameObject);
		}else{
			selectedObjects.Add (gameObject);
		}
	}
	
	void Start () {
		defaultColor = new Color(1.0f, 1.0f, 1.0f, 0.5f);
	}
	
	void Update () {
		if (selectedObjects.Contains (gameObject)) {
			Debug.Log (gameObject.renderer.material.GetColor("_Color"));
			gameObject.renderer.material.SetColor ("_Color", Color.green);
		} else {
			gameObject.renderer.material.SetColor ("_Color", defaultColor);
		}
	}
}
