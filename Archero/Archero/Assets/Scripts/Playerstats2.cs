using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerstats2 : MonoBehaviour
{


    public float damage = 100;
    public float leben = 1000;
    public int timerzahl = 0;
    public bool unverwundbar = false;
    private Transform target;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
    }
    //transform.position = Vector2.MoveTowards(from,to,speed);----------------------------------
    // Update is called once per frame
    void FixedUpdate()
    {
      if (leben < 1)
        { 
            Destroy(gameObject);
        }

        

    }


}
