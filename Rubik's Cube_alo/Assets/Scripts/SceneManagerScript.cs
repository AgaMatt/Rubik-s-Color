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
		SceneManager.LoadScene ("MainMenu");
	}

	public void Restart ()
	{
		SceneManager.LoadScene ("Game Restart");
	}
}
