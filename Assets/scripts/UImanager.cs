using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour 
{
	public void Play()
	{
		SceneManager.LoadScene ("scene1");
	}
	
	public void Pause()
	{
		if (Time.timeScale == 1)
			Time.timeScale = 0;
		else
			Time.timeScale = 1;
	}
}
