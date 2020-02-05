using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
	public Transform amm;
	public int speedAmm = 1500;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Transform g = (Transform)Instantiate(amm, transform.position, transform.rotation);
			g.GetComponent<Rigidbody>().AddForce(transform.forward * speedAmm);
		}
	}
}
