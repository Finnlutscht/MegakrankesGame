using System.Collections;
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
    public void zzGenerieren1()
    {
       zahlX = Random.Range(-22.5f, 27.5f);
    }
    public void zzGenerieren2()
    {
      zahlY =  Random.Range(-9.4f, 10.6f);
    }
}
