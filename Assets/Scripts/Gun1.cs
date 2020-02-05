using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun1 : MonoBehaviour
{
	public Transform amm;
	[SerializeField] private GameObject gg;
	private float pause = 0;
	private int speedAmm = 1500;

	// Update is called once per frame
	void Update()
	{
		switch (this.tag)
		{
			case "NPS1":
				if (gg.GetComponent<MoveLvl1>().nowPoint == 1)
				{
					pause += Time.deltaTime;
					if (pause >= 0.9f)
					{
						pause = 0;
						Transform g = (Transform)Instantiate(amm, transform.position, transform.rotation);
						g.GetComponent<Rigidbody>().AddForce(transform.forward * speedAmm);
					}
				}
				break;
			case "NPS2":
				if (gg.GetComponent<MoveLvl1>().nowPoint == 1)
				{
					pause += Time.deltaTime;
					if (pause >= 1.2f)
					{
						pause = 0;
						Transform g = (Transform)Instantiate(amm, transform.position, transform.rotation);
						g.GetComponent<Rigidbody>().AddForce(transform.forward * speedAmm);
					}
				}
				break;
			case "NPS3":
				if (gg.GetComponent<MoveLvl1>().nowPoint == 2)
				{
					pause += Time.deltaTime;
					if (pause >= 1f)
					{
						pause = 0;
						Transform g = (Transform)Instantiate(amm, transform.position, transform.rotation);
						g.GetComponent<Rigidbody>().AddForce(transform.forward * speedAmm);
					}
				}
				break;
			case "NPS4":
				if (gg.GetComponent<MoveLvl1>().nowPoint == 3)
				{
					pause += Time.deltaTime;
					if (pause >= 0.9f)
					{
						pause = 0;
						Transform g = (Transform)Instantiate(amm, transform.position, transform.rotation);
						g.GetComponent<Rigidbody>().AddForce(transform.forward * speedAmm);
					}
				}
				break;
		}
		
	}
}
