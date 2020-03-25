﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schießen2 : MonoBehaviour
{
    
    public float damage = 100;
    private Transform target;
    public float arrowspeed ;
    public bool schießen = false;
    public GameObject player;
    private float timerzahl ;
    //feuergeschwindigkeit = schüsse/sekunde
    public float feuergeschwindigkeit;
    

  
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        player = GameObject.Find("Me");
        timerzahl = 1;
    }
    //transform.position = Vector2.MoveTowards(from,to,speed);----------------------------------
    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        
        if (Input.GetButton("Fire1") == true && schießen == false && timerzahl == 1)
        {
            schießen = true;
            timerzahl = 0;
           
        }

        if (schießen == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, arrowspeed * Time.deltaTime);
        }

        if (Vector2.Distance(transform.position, target.position) == 0)
        {
            transform.position = player.transform.position;
            StartCoroutine(waiter());
            schießen = false;
        }
    }
    IEnumerator waiter()
    {
        while (timerzahl != 1)
        {
            yield return new WaitForSeconds(1/feuergeschwindigkeit);
            timerzahl += 1;
        }
    }
}



