using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrowspitzestats : MonoBehaviour
{
   
    private Transform target;
    public bool schießen1 = false;
    private GameObject player;
    private float arrowspeed = 40;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         Vector3 lookVektor = target.position - transform.position;
         transform.rotation = Quaternion.LookRotation(lookVektor);
         //schießen();
    }

   /* public void schießen()
    {
        if (Input.GetButton("Fire1") == true && schießen1 == false)
        {
            schießen1 = true;

        }

        if (schießen1 == true)
        {

            transform.position = Vector2.MoveTowards(transform.position, target.position, arrowspeed * Time.deltaTime);
        }

        if (Vector2.Distance(transform.position, target.position) == 0)
        {
            schießen1 = false;

        }
    }*/
}
