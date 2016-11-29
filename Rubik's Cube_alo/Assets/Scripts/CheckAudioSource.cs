using UnityEngine;
using System.Collections;

public class CheckAudioSource : MonoBehaviour {
	public GameObject AudioManager;

	// Use this for initialization
	void Start () {
		if (FindObjectOfType<AudioSource> () == null )
		{
			Instantiate (AudioManager,gameObject.transform.position, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
