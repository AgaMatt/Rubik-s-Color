using UnityEngine;
using System.Collections;

public class RotateCubeMenu : MonoBehaviour {


	Vector3 rotateCube;
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		rotateCube = new Vector3 (Random.Range (-80, -360), Random.Range (10, 50), Random.Range (80, 360));
		GetComponent<Rigidbody> ().AddTorque (rotateCube);
	}
}
