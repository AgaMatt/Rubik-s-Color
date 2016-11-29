using UnityEngine;
using System.Collections;

public class BackGroundAudio : MonoBehaviour {

	public bool muted;
	//public Sprite audioOn, audioOff;
	//Sprite audioImage;
	AudioSource backGround_Music;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		backGround_Music = FindObjectOfType<AudioSource> ();
		if (muted == true) {
			
			backGround_Music.mute = true;
		} else
			backGround_Music.mute = false;
	
	}

	public void Mute()
	{
		if(backGround_Music.mute == false){
			
			muted = true;
		}else if(backGround_Music.mute == true){
			muted = false;
		}
	}
}
