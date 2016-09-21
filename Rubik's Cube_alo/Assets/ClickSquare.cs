using UnityEngine;
using System.Collections;

public class ClickSquare : MonoBehaviour {
	public static Color selectedColor;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {
		selectedColor = GetComponent<SpriteRenderer> ().color;
		Destroy (gameObject);

	}
}
