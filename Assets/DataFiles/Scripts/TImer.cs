using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TImer : MonoBehaviour
{
	public float timerem;

	public TextMesh timer;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
	{
		timerem = timerem - Time.deltaTime;
		timer.text = Mathf.Floor(timerem).ToString();

		if (timerem < 1)
		{
			SceneManager.LoadScene("EndScene");
		}
	}
}
