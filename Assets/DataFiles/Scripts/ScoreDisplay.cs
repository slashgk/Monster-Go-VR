using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
	private Mcalculator mcalc;

	private int monstercount = 0;

	public Text monstertext;
	// Use this for initialization
	void Start ()
	{
		mcalc = FindObjectOfType<Mcalculator>();
		monstercount = mcalc.counter;
		monstertext.text = monstercount.ToString();
		Destroy(mcalc.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
