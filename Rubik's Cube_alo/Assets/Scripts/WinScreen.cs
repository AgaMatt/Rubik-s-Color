using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour {

	//bool pause;
	public GameObject winManager;

	void Start ()
	{
		
		Time.timeScale = 1;
		winManager.gameObject.SetActive (false);
		//pause = false;
	}

	public void WinTheGame ()
	{

		Time.timeScale = 0;
		winManager.gameObject.SetActive (true);
		//pause = true;
	}

	public void RestartButton()
	{
		Time.timeScale = 1;
		winManager.gameObject.SetActive (false);
	//	pause = false;
		SceneManager.LoadScene ("Game Restart");
	}

	public void CloseButton()
	{
		Time.timeScale = 1;
		winManager.gameObject.SetActive (false);
	//	pause = false;
		Application.Quit (); 
	}
}
