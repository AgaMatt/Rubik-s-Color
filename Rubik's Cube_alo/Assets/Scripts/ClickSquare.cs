using UnityEngine;
using System.Collections;

public class ClickSquare : MonoBehaviour {
	public static Color selectedColor;
	public static int respawn;
	// Use this for initialization
	void Start () {
		CheckClickOnQuad.canPaint = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {
		if (CheckClickOnQuad.canPaint) {
			print ("N TA INDO square");
			selectedColor = GetComponent<SpriteRenderer> ().color;
			Destroy (gameObject);

		}
		CheckClickOnQuad.canPaint = true;




	}
}
