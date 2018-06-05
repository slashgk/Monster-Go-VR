using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkandShoot : MonoBehaviour
{
	public GameObject pokeball;
	public float speed;
	public float shootingspeed = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
		
		if (Input.GetButton("Fire1"))
		{
			GameObject pokego = Instantiate(pokeball);
			pokego.transform.position = transform.position;
			Rigidbody rb = pokego.GetComponent<Rigidbody>();
			Camera cam = GetComponentInChildren<Camera>();
			rb.velocity = cam.transform.rotation * Vector3.forward *shootingspeed;
			//System.Threading.Thread.Sleep(150);
		}
	}
}
