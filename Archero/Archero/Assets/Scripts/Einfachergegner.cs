using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using System.Security.Cryptography;
using UnityEngine;

public class Einfachergegner : Enemy
{
    private Pfeil pfeilscript;
    private Bogenschütze bsscript;
    private Transform target;
    private int timerzahl;
    private bool laufen;
    private float zahl1;
    private float zahl2;

    // Start is called before the first frame update
    void Start()
    {
        bsscript = GameObject.Find("Me").GetComponent<Bogenschütze>();
        zahl1 = zzGenerieren1(0f, 2f);
        StartCoroutine(warten());
        laufen = false;
        pfeilscript = GameObject.FindGameObjectWithTag("Arrow").GetComponent<Pfeil>();
        target = GameObject.Find("Me").GetComponent<Transform>();
        harmlos = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        verwundbar();
        bewegen();
        if (leben < 1)
        {
            Destroy(gameObject);
        }
    }
    public void bewegen()
    {
        if (laufen == true)
        {
            if (Vector2.Distance(transform.position, target.position) > stoppingDistance)//enemystatsscript.leben > 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
        }
        
    }
    IEnumerator warten()
    {
        for (int i = 0; i < zahl1; i++)
        {
            yield return new WaitForSeconds(1);
            timerzahl = timerzahl + 1;
        }
        laufen = true;
        zahl2 = zzGenerieren2(1f, 3f);
        StartCoroutine(starteLaufen());
    }
    IEnumerator starteLaufen()
    {
        for (int i = 0; i < zahl2; i++)
        {
            yield return new WaitForSeconds(1);
            timerzahl = timerzahl + 1;
        }
        laufen = false;
        zahl1 = zzGenerieren1(0f, 2f);
        StartCoroutine(warten());
    }
    void verwundbar()
    {
        if (timerzahl == 3)
        {
            harmlos = false;
            timerzahl = 0;
        }
    }
    IEnumerator waitsec()
    {
       for(int i = 0; i < 4; i++)
       {
            yield return new WaitForSeconds(1);
            timerzahl = timerzahl + 1;
       }
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Arrow" && pfeilscript.critschaden == false)
        {
            leben = leben - bsscript.damage;
        }
        else if (col.gameObject.tag == "Arrow" && pfeilscript.critschaden == true)
        {
            leben = leben - bsscript.damage * 2;
        }
    }
    public float getLeben() {
        return leben;
    }
   
}
