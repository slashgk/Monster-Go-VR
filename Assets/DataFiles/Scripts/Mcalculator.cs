using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mcalculator : MonoBehaviour
{
	public int counter;

	public TextMesh totalm;
	// Use this for initialization
	void Start ()
	{
		counter = 0;
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void totalcount()
	{
		counter++;
		totalm.text = counter.ToString();
		//Debug.Log("Monster Collected: " + counter);
	} 
}
