using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshCollider))]


public class TestMoveTheCube : MonoBehaviour 
{
	Vector3 screenPoint, scanPos, offset;

	void OnMouseDown ()
	{
		screenPoint = Camera.main.WorldToScreenPoint (scanPos);


		offset = scanPos - Camera.main.ScreenToWorldPoint (
			new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

	}
}