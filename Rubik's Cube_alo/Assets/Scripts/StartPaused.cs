using UnityEngine;
using System.Collections;

public class StartPaused : MonoBehaviour
{

//	bool pause;
	public GameObject pauseManager;
	public bool depoisDoStart;
	void Start ()
	{
		depoisDoStart = false;
		Time.timeScale = 0;
		pauseManager.gameObject.SetActive (true);
		//pause = true;
	}

	public void StartButton ()
	{
		
		Time.timeScale = 1;
		pauseManager.gameObject.SetActive (false);
		//pause = false;
	}
}
