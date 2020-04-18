using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Spawn : Zufall
{
    public GameObject Enemyprefab;
    public GameObject HealthBallPrefab;
    public GameObject HealthButtonPrefab;
 
    private Bogenschütze bogenSchützenScript;
    public Vector3 center;
    public float zahl1;
    public float zahl2;
   

    public float GegnerAnzahl;
    public float HealthAnzahl;
    // Start is called before the first frame update
    void Start()
    {

        
       
        bogenSchützenScript = GameObject.Find("Me").GetComponent<Bogenschütze>();
        for (int i = 0; i < GegnerAnzahl; i++)
        {
            spawnGegner();
        }
        for (int i = 0; i < HealthAnzahl; i++)
        {
            spawnHealth();
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(KeyCode.Q))
        {
            spawnGegner();
            spawnHealth();
        }
        
    }
    public void spawnGegner()
    {
        zahl1 = zzGenerieren1(-20f, 20f);
        zahl2 = zzGenerieren2(-8f, 8f);

        Vector3 pos = center + new Vector3(zahl1,zahl2, 0);
        Instantiate(Enemyprefab, pos, Quaternion.identity);
    }
    public void spawnHealth()
    {
        
        
        zahl1 = zzGenerieren1(-20f,20f);
        zahl2 = zzGenerieren2(-8f,8f);

        Vector3 pos = center + new Vector3(zahl1, zahl2, 0);
        Instantiate(HealthBallPrefab, pos, Quaternion.identity);
    }
    public void belohnugAussuchen()
    {
        

        Vector3 pos2 = center + new Vector3(0, 0, 0);
        Instantiate(HealthButtonPrefab, pos2, Quaternion.identity);

       
    }
   
}
