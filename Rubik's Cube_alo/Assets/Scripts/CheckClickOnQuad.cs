using UnityEngine;
using System.Collections;

public class CheckClickOnQuad : MonoBehaviour {
	public MoveTheCube moveCube;
	public StartPaused depoisStart;
	MeshRenderer corQuad;
	Color quadColor;
	Color blue, orange, yellow, green, white, red;
	public static bool canPaint, alrdyHaveColor;
	// Use this for initialization
	void Start () {

		canPaint = true;
		blue = new Color(0,53,255,255);
		orange = new Color ( 255,133,1,255);
		yellow = new Color(255,255,2,255);
		green = new Color(46,197,2,255);
		white = new Color (255,255,255,255);
		red = new Color(255,28,32,255);
			
	
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		if (depoisStart.depoisDoStart) {
			//Debug.Log (gameObject.name)
			quadColor = GetComponent<MeshRenderer> ().material.color;
			if (quadColor == ClickSquare.selectedColor) {
				
			}
			if (canPaint && quadColor != ClickSquare.selectedColor	) {
				GetComponent<MeshRenderer> ().material.color = ClickSquare.selectedColor;
				canPaint = false;
				alrdyHaveColor = false;
			}

		}
	}

	void OnMouseDrag()
	{
		moveCube.OnMouseDrag ();
	}
		
}
