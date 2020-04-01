﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGetroffen : MonoBehaviour
{
    private Playerstats2 playerstatsscript;
    private EnemyStats enemystatsscript;
    private PlayerController playercontrollerscript;

    private Transform target;
    public int timerzahl = 0;
    public bool unverwundbar;
    private Transform wand;

    void Start()
    {

        playercontrollerscript = GameObject.Find("Me").GetComponent<PlayerController>();
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        playerstatsscript = GameObject.Find("Me").GetComponent<Playerstats2>();
        enemystatsscript = GameObject.Find("Enemy").GetComponent<EnemyStats>();
       wand = GameObject.FindGameObjectWithTag("Wand").GetComponent<Transform>();
        
       
      
    }


    void FixedUpdate()
    {
        getroffen();


    }
    public void getroffen()
    {
        if (Vector2.Distance(transform.position, target.position) < 0.5 && unverwundbar == false)
        {
            playerstatsscript.leben = playerstatsscript.leben - 100;
            unverwundbar = true;
            StartCoroutine(waitsec());

        }
        if (Vector2.Distance(transform.position, target.position) > 1.5 | timerzahl == 3)
        {
            unverwundbar = false;
            timerzahl = 0;


        }
    }
    

    /* public void berührung()
     {
         if (Vector2.Distance(transform.position, wand.position) < 0.5 )
         {
             playercontrollerscript.speed = playercontrollerscript.speed * -1;

         }

     }*/

    IEnumerator waitsec()
    {
       while (timerzahl < 4)
       {
            yield return new WaitForSeconds(1);
            timerzahl = timerzahl + 1;
       }

      
    }
    
}
