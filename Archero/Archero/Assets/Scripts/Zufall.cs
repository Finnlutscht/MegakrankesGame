﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Zufall : MonoBehaviour
{
    public float zahlY;
    public float zahlX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float zzGenerieren1(float pZahl1, float pZahl2)
    {
       zahlX = Random.Range(pZahl1, pZahl2);
        return zahlX;
    }
    public float zzGenerieren2(float pZahl1, float pZahl2)
    {
      zahlY =  Random.Range(pZahl1, pZahl2);
        return zahlY;
    }
}
