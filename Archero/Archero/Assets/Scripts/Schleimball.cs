using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Schleimball : Geschoss
{
    private Transform target;
    private Vector3 zielPosition;
    private Vector3 zielPosition2;
    private Vector3 distanz;
    private float zielrichtung;
    private bool ziel;
    // Start is called before the first frame update
    void Start()
    {
        ziel = false;
        target = GameObject.Find("Me").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        schießen();
    }
    void schießen()
    {
        if (ziel == false)
        {
            zielPosition2 = target.transform.position;
            distanz = zielPosition2 - transform.position;
            zielPosition = transform.position + distanz * 100;
            ziel = true;
        }
        
        transform.position = Vector2.MoveTowards(transform.position, zielPosition, arrowspeed * Time.deltaTime);
       
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

        if (col.gameObject.tag == "Wand")
        {
            Destroy(gameObject);
        }
    }

}
