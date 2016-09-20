using UnityEngine;
using System.Collections;

public class PaintQuads : MonoBehaviour {

	bool _red, _blue, _green, _white, _orange, _yellow;
	Color orangeColor = new Color (255, 121, 0, 255);

	void OnMouseDown(GameObject quad){
		print ("Click");
		var paint = quad.GetComponent<Color> ();
		if (paint == Color.red) {
			_red = true;
		} else if (paint == Color.blue) {
			print ("AZUL CARAI");
			_blue = true;
		} else if (paint == Color.green) {
			_green = true;
		} else if (paint == Color.white) {
			_white = true;
		} else if (paint == orangeColor) {
			_orange = true;
		} else if (paint == Color.yellow) {
			_yellow = true;
		}
	}
}
