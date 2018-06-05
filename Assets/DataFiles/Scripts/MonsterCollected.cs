using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCollected : MonoBehaviour
{
	private Mcalculator mcal;
	void Start ()
	{
		mcal = FindObjectOfType<Mcalculator>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("redmonster"))
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
			mcal.totalcount();
		}
		if (other.gameObject.CompareTag("yellowmonster"))
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
			mcal.totalcount();
		}
		if (other.gameObject.CompareTag("greenmonster"))
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
			mcal.totalcount();
		}
		if (other.gameObject.CompareTag("violetmonster"))
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
			mcal.totalcount();
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("ground"))
		{
			Destroy(gameObject);
		}
	}
}
