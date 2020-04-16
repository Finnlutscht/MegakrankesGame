using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Pfeil : Geschoss
{
    public bool geschossen = false;
    private Transform player;
    public bool critschaden;
    public int critRateInProzent;
    private GameObject closestPlayer;
    private GameObject closest;
    public float feuerrateProSekunde;
    public float speed;
    public float stoppingDistance;
    public bool freiesSchussfeld = true;
    private Vector2 zielPosition;

    private Bogenschütze bogenschützenscript;

    // Start is called before the first frame update
    void Start()
    {
        critschaden = false;
        freiesSchussfeld = true;
        geschossen = false;

        damage = 100;
        player = GameObject.Find("Me").GetComponent<Transform>();
        bogenschützenscript = GameObject.Find("Me").GetComponent<Bogenschütze>();
    }

    void FixedUpdate()
    {
        schießen();
        bewegen();
    }
    void schießen ()
    {
        closestPlayer = FindClosestEnemy();
        zielPosition = closestPlayer.transform.position;
        zzGenerieren(1, 100);
        if (zz < critRateInProzent)
        {
            critschaden = true;
        }
        transform.position = Vector2.MoveTowards(transform.position, zielPosition, arrowspeed * Time.deltaTime);

        /*if(Vector2.Distance(transform.position,zielPosition) == 0)
        {
            Destroy(gameObject);
        }*/
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            critschaden = false;
            Destroy(gameObject);
        }

        if (col.gameObject.name == "Marker")
        {
            Destroy(col.gameObject);
        }

        if(col.gameObject.tag == "Wand")
        {
            Destroy(gameObject);
        }
        
        
       
    }
    void bewegen()
    {
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        }
    }
    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Enemy");
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
   
    



}
