using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Spawn : Zufall
{
    public GameObject EinfacheGegnerPrefab;
    public GameObject SchießendeGegnerPrefab;
    public GameObject HealthBallPrefab;
    public GameObject HealthButtonPrefab;
 
    public Vector3 center;
    public float zahl1;
    public float zahl2;
   

    public float EinfacherGegnerAnzahl;
    public float SchießendeGegnerAnzahl;
    public float HealthAnzahl;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < SchießendeGegnerAnzahl; i++)
        {
            spawnSchießendeGegner();
        }
        for (int i = 0; i < EinfacherGegnerAnzahl; i++)
        {
            spawnEinfacheGegner();
        }
        for (int i = 0; i < HealthAnzahl; i++)
        {
            spawnHealth();
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void spawnEinfacheGegner()
    {
        zahl1 = zzGenerieren1(-20f, 20f);
        zahl2 = zzGenerieren2(-8f, 8f);

        Vector3 pos = center + new Vector3(zahl1,zahl2, 0);
        Instantiate(EinfacheGegnerPrefab, pos, Quaternion.identity);
    }
    public void spawnSchießendeGegner()
    {
        zahl1 = zzGenerieren1(-20f, 20f);
        zahl2 = zzGenerieren2(-8f, 8f);

        Vector3 pos = center + new Vector3(zahl1, zahl2, 0);
        Instantiate(SchießendeGegnerPrefab, pos, Quaternion.identity);
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
