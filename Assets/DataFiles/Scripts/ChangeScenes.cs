using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour {

	public void loaddayscene()
	{
		SceneManager.LoadScene("DayScene");
	}
	
	public void loadnightscene()
	{
		SceneManager.LoadScene("NightScene");
	}
	
	public void exit()
	{
		Application.Quit();
	}
}
