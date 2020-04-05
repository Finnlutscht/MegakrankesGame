using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{ 
    public float damage;
    public float leben;
    public float speed;
    public float stoppingDistance;

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }
   
    /*void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Arrow" && schießenscript.geschossen == true && schießenscript.critschaden == false)
        {
            enemystatsscript.leben = enemystatsscript.leben - schießenscript.damage;


        }
        if (col.gameObject.tag == "Arrow" && schießenscript.geschossen == true && schießenscript.critschaden == true)
        {
            enemystatsscript.leben = enemystatsscript.leben - schießenscript.damage * 2;

        }

    }*/

}
