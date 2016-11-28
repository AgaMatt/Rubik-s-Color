using UnityEngine;
using System.Collections;

public class FollowTheCube : MonoBehaviour {
	public float _distance;
	public GameObject _cube;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = new Vector3 (_cube.transform.position.x, _cube.transform.position.y, _cube.transform.position.z - _distance);
	}
}
