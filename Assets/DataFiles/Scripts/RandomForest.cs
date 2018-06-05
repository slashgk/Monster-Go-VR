using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomForest : MonoBehaviour {

	public GameObject[] differentrocktree;
	public GameObject[] differentgrass;
	// Use this for initialization
	void Start ()
	{
		for (int i = 0; i < Random.Range(300, 400); i++)
		{
			rocktreecount();
		}
		for (int i = 0; i < Random.Range(500, 600); i++)
		{
			grasscount();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void rocktreecount()
	{
		int rocktreeindex = Random.Range(0,differentrocktree.Length);
		GameObject rtreerock = Instantiate(differentrocktree[rocktreeindex]);
		rtreerock.transform.parent = transform;
		rtreerock.transform.localPosition = new Vector3(Random.Range(-45,45),0.0f,Random.Range(-45,45));
	}
	void grasscount()
	{
		int grassindex = Random.Range(0,differentgrass.Length);
		GameObject rgrass = Instantiate(differentgrass[grassindex]);
		rgrass.transform.parent = transform;
		rgrass.transform.localPosition = new Vector3(Random.Range(-45,45),0.0f,Random.Range(-45,45));
	}
}
