using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS2 : MonoBehaviour
{
    [SerializeField] private GameObject gg,nps, nps1, gun;
    private bool dead = false;
    private void Start()
    {
        gg = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if (nps1.GetComponent<NPS1>().dead == true && dead == false)
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
