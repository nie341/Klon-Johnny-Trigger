using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLvl1 : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private GameObject gun,replay,nextLvl;
    public int point, nowPoint;
    private float pauz;
    private bool poin3 = false;

    // Start is called before the first frame update
    void Start()
    {
        pauz = 0;
        point = 1;
        GetComponent<Animator>().SetBool("Start",true);
    }

    // Update is called once per frame
    void Update()
    {
        Movet();
    }
    private void Movet()
    {
        transform.position -= Vector3.left * moveSpeed * Time.deltaTime;
        if(poin3 == true)
        {
            //Debug.Log(pauz);
            pauz += Time.deltaTime;
            if (pauz >= 0.5f)
            {
                moveSpeed = -1;
            }
            if (pauz >= 2f)
            {
                moveSpeed = 5;
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PointStart")
        {
            if (point == 1)
            {
                nowPoint = 1;
                gun.SetActive( true);
                Time.timeScale = 0.3f;
                GetComponent<Rigidbody>().useGravity = false;
                GetComponent<Animator>().SetTrigger("Point1Start");
            }
            if (point == 2)
            {
                nowPoint = 2;
                gun.SetActive(true);
                Time.timeScale = 0.5f;
                GetComponent<Rigidbody>().useGravity = false;
                GetComponent<Animator>().SetTrigger("Point2Start");
            }
            if (point == 3&&poin3==false)
            {
                nowPoint = 3;
                gun.SetActive(true);
                poin3 = true;
                Time.timeScale = 0.5f;
                moveSpeed = 0;
                GetComponent<Rigidbody>().useGravity = false;
                GetComponent<Animator>().SetTrigger("Point3Start");
            }
        }
        if (other.tag == "PointExit")
        {
            if (point == 3)
            {
                GetComponent<Animator>().SetTrigger("Point3Exit");
                gun.SetActive(false);
                Time.timeScale = 1;
                GetComponent<Rigidbody>().useGravity = true;
            }
            if (point == 2)
            {
                gun.SetActive(false);
                Time.timeScale = 1;
                GetComponent<Rigidbody>().useGravity = true;
                GetComponent<Animator>().SetTrigger("Point2Exit");
                point = 3;
            }
            if (point == 1)
            {
                gun.SetActive(false);
                Time.timeScale = 1;
                GetComponent<Rigidbody>().useGravity = true;
                GetComponent<Animator>().SetTrigger("Point1Exit");
                point = 2;
            }
        }
        if (other.tag == "Finish")
        {
            nextLvl.SetActive(true);
            poin3 = false;
            moveSpeed = 0;
            GetComponent<Animator>().SetBool("Start", false);
            GetComponent<Animator>().SetTrigger("End");
        }
        if (other.tag == "DeadNps")
        {
            replay.SetActive(true);
            Debug.Log("Dead");
            Time.timeScale = 0;
        }
    }
}
