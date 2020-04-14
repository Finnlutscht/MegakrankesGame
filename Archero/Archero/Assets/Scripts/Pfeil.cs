using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pfeil : Geschoss
{
    public bool geschossen = false;
    private Transform player;
    public bool critschaden;
    public int critRateInProzent;
    private GameObject closestPlayer;
    private GameObject closest;
    public float timerzahl;
    public float feuerrateProSekunde;
    public float speed;
    public float stoppingDistance;
    public bool alleTot = false;
    public bool freiesSchussfeld = true;

    public Bogenschütze bogenschützenscript;

    // Start is called before the first frame update
    void Start()
    {
        critschaden = false;
        timerzahl = 1;
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
        if (Vector2.Distance(transform.position, closestPlayer.transform.position) > 1)
        {
            freiesSchussfeld = true;
        }
    }
    void schießen ()
    {
        closestPlayer = FindClosestEnemy();
        if (closestPlayer.tag == "Finish")
        {
            alleTot = true;
            
        }

        if (bogenschützenscript.bewegung == false && geschossen == false && timerzahl == 1 && alleTot == false && freiesSchussfeld == true)
        {
            geschossen = true;
            timerzahl = 0;
            StartCoroutine(waitsec());
            zzGenerieren(1, 100);
            if (zz < critRateInProzent)
            {
                critschaden = true;
            }
        }

        if (geschossen == true && closestPlayer.tag != "Finish")
        {
            transform.position = Vector2.MoveTowards(transform.position, closestPlayer.transform.position, arrowspeed * Time.deltaTime);
            
        }

        /*if (Vector2.Distance(transform.position, closestPlayer.transform.position) == 0)
        {
            transform.position = player.position;
            geschossen = false;
            critschaden = false;
        }*/
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            transform.position = player.position;
            geschossen = false;
            critschaden = false;
            freiesSchussfeld = false;
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
    IEnumerator waitsec()
    {
        while (timerzahl != 1)
        {
            yield return new WaitForSeconds(1 / feuerrateProSekunde);
            timerzahl += 1;
        }
    }
    



}
