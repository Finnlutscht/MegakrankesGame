using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schießen2 : MonoBehaviour
{

    public float damage;
    private Transform target;
    public float arrowspeed;
    public bool schießen = false;
    public GameObject player;
    public float timerzahl;
    public float feuerrateprosekunde;
    public bool geschossen;



    void Start()
    { 
        timerzahl = 1;
        
        damage = 100;
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        player = GameObject.Find("Me");
    }
    //transform.position = Vector2.MoveTowards(from,to,speed);----------------------------------
    // Update is called once per frame
    void Update()
    {
      
    }
    void FixedUpdate()
    {
        // target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        if (Input.GetButton("Fire1") == true && schießen == false && timerzahl == 1)
        {
            schießen = true;
            timerzahl = 0;
            StartCoroutine(waitsec());
            geschossen = true;
            
        }

        if (schießen == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, arrowspeed * Time.deltaTime);
            //Vector2 lookVector = target.position - transform.position;
            //transform.position = Quaternion.LookRotation(lookVector);
        }

        if (Vector2.Distance(transform.position, target.position) == 0)
        {
            schießen = false;
            transform.position = player.transform.position;
            target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
            geschossen = false;
        
        }

    }
    IEnumerator waitsec()
    {
        while (timerzahl != 1)
        {
            yield return new WaitForSeconds(1/ feuerrateprosekunde);
            timerzahl += 1;
        }
    }

}



