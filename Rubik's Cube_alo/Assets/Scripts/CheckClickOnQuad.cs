using UnityEngine;
using System.Collections;

public class CheckClickOnQuad : MonoBehaviour {
	public MoveTheCube moveCube;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		//Debug.Log (gameObject.name)
		GetComponent<MeshRenderer> ().material.color = ClickSquare.selectedColor;

	}

	void OnMouseDrag()
	{
		moveCube.OnMouseDrag ();
	}
}
