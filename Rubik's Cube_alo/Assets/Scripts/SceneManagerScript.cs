using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{

	public void Play ()
	{
		SceneManager.LoadScene ("Game");
	}

	public void Credits ()
	{
		SceneManager.LoadScene ("Credits");
	}

	public void Return ()
	{
		var a = FindObjectOfType<AudioSource> ();
		Destroy (a);
		SceneManager.LoadScene ("MainMenu");
	}

	public void Restart ()
	{
		var a = FindObjectOfType<AudioSource> ();
		Destroy (a);
		SceneManager.LoadScene ("Game Restart");
	}

}
