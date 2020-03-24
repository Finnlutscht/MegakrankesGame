using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Playerifo : MonoBehaviour
{
    public static  void Sleep(int millisecondsTimeout)
    {
        Sleep(millisecondsTimeout);
    }
    public float damage = 100;
    public float leben = 1000;
    public int timerzahl;

    public bool direktdaneben = false;
    private Transform target;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
    }
    //transform.position = Vector2.MoveTowards(from,to,speed);----------------------------------
    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) < 0.5 && direktdaneben == false)
        {
            leben = leben -100;
            direktdaneben = true;

            while (timerzahl != 3)
            {
                timerzahl = timerzahl + 1;
                
            }
        }

        if (Vector2.Distance(transform.position, target.position) > 1.5 || timerzahl == 3)
        {
            direktdaneben = false;
            timerzahl = 0;
        }
        
       
    }
}
