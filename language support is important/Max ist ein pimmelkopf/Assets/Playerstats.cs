using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Playerstats2 : MonoBehaviour
{
   
    
    public float damage = 100;
    public float leben = 1000;
    public int timerzahl = 0;
    

    public bool direktdaneben = false;
    private Transform target;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
    }
    //transform.position = Vector2.MoveTowards(from,to,speed);----------------------------------
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, target.position) < 0.5 && direktdaneben == false)
        {
            leben = leben -100;
            direktdaneben = true;
            StartCoroutine(waiter());
        }

        if (Vector2.Distance(transform.position, target.position) > 1.5 | timerzahl == 3)
        {
            direktdaneben = false;
            timerzahl = 0;
        }
        
       
    }
    
    IEnumerator waiter()
    {
        while (timerzahl != 3)
        { 
            yield return new WaitForSeconds(1);
            timerzahl += 1;
        }
          
    }


}
