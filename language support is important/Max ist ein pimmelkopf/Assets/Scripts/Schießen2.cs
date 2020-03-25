using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schießen : MonoBehaviour
{
    
    public float damage = 100;
    private Transform target;
    public float arrowspeed ;
    public bool schießen = false;
    public GameObject player;
    

  
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        player = GameObject.Find("Me");
    }
    //transform.position = Vector2.MoveTowards(from,to,speed);----------------------------------
    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        
        if (Input.GetButton("Fire1") == true && schießen == false)
        {
            schießen = true;
        }

        if (schießen == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, arrowspeed * Time.deltaTime);
        }

        if (Vector2.Distance(transform.position, target.position) == 0)
        {
            schießen = false;
            transform.position = player.transform.position;
            
        }
    }
}



