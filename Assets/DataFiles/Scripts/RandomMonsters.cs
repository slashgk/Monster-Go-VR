using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMonsters : MonoBehaviour
{
	public GameObject[] differentmons;
 	// Use this for initialization
	void Start ()
	{
		for (int i = 0; i < Random.Range(400,500); i++)
		{
			monstercount();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void monstercount()
	{
		int monsterindex = Random.Range(0,differentmons.Length);
		GameObject rmons = Instantiate(differentmons[monsterindex]);
		rmons.transform.parent = transform;
		rmons.transform.localPosition = new Vector3(Random.Range(-45,45),0.0f,Random.Range(-45,45));
	}
}
