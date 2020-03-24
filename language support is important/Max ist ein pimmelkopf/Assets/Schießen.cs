using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schießen : MonoBehaviour
{
    public float damage = 100;
    private Transform target;
    public float arrowspeed = 10;
    public bool schießen = false;
    private Vector2 moveVelocity;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
    }
    //transform.position = Vector2.MoveTowards(from,to,speed);----------------------------------
    // Update is called once per frame
    void Update()
    {
      

       
    }
    void FixedUpdate()
    {
        if (Input.GetAxis("Fire1") == 1 && schießen == false)
        {
            
            schießen = true;

        }
       
        if (schießen == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, arrowspeed * Time.deltaTime);

        }
    }
}


