using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS3 : MonoBehaviour
{
    [SerializeField] private GameObject gg,nps, gun;
    private bool dead = false;
    private void Start()
    {
        gg = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if (gg.GetComponent<MoveLvl1>().nowPoint == 2 && dead == false)
        {
            nps.GetComponent<Animator>().SetTrigger("NPS");
            transform.LookAt(gg.transform.position);
            gg.transform.LookAt(gg.transform.position);
        }
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dead")
        {
            gun.GetComponent<Gun1>().enabled = false;
            dead = true;
            nps.GetComponent<Animator>().SetTrigger("Dead");
        }
    }
}
