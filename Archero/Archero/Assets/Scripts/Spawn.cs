using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Spawn : Zufall
{
    public GameObject Enemyprefab;
    public Vector3 center;
    public float zahl1;
    public float zahl2;
   

    public float gegnerAnzahl;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < gegnerAnzahl; i++)
        {
            spawn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            spawn();
        }
        
    }
    public void spawn()
    {
        zzGenerieren1();
        zzGenerieren2();
        zahl1 = zahlX;
        zahl2 = zahlY;
       
        Vector3 pos = center + new Vector3(zahl1,zahl1, 0);
        Instantiate(Enemyprefab, pos, Quaternion.identity);
    }
   
}
