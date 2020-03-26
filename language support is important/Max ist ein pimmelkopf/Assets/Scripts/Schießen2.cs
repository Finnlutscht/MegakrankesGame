using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schießen2 : MonoBehaviour
{
    
    public float damage ;
    private Transform target;
    private Transform target2;
    public float arrowspeed ;
    public bool schießen = false;
    public GameObject player;
    static string tagTot = "tot";



    void Start()
    {
        damage = 100;
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        //target2 = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        player = GameObject.Find("Me");
        //enemies = GameObject.Find("Enemy").GetComponent<Transform>();

    }
    //transform.position = Vector2.MoveTowards(from,to,speed);----------------------------------
    // Update is called once per frame
    void Update()
    {
      
    }
    void FixedUpdate()
    {
       // target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        if (Input.GetButton("Fire1") == true && schießen == false)
        {
            schießen = true;
        }

        if (schießen == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, arrowspeed * Time.deltaTime);
            //Vector2 lookVector = target.position - transform.position;
            //transform.position = Quaternion.LookRotation(lookVector);
           // player.playerstats2.damage = 4;
        }

        if (Vector2.Distance(transform.position, target.position) == 0)
        {
            schießen = false;
            transform.position = player.transform.position;
            target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();


        }
       
    }
}



