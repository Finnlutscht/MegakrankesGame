using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geschoss : MonoBehaviour
{
    public float damage;
    public float arrowspeed;
    public float zz;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void zzGenerieren(int pZahl1, int pZahl2)
    {
        Random rnd = new Random();
        zz = Random.Range(pZahl1, pZahl2);
    }
    

}
