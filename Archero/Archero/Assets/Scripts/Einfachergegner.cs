using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using System.Security.Cryptography;
using UnityEngine;

public class Einfachergegner : Enemy
{
    private Pfeil pfeilscript;
    private Transform target;
    private int timerzahl;

    // Start is called before the first frame update
    void Start()
    {
        pfeilscript = GameObject.Find("Arrow").GetComponent<Pfeil>();
        target = GameObject.Find("Me").GetComponent<Transform>();
        harmlos = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        verwundbar();
        bewegen();
        if (leben < 1)
        {
            Destroy(gameObject);
        }
    }
    public void bewegen()
    {
        //target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)//enemystatsscript.leben > 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }
    }
    void verwundbar()
    {
        if (timerzahl == 3)
        {
            harmlos = false;
            timerzahl = 0;
        }
    }
    IEnumerator waitsec()
    {
       for(int i = 0; i < 4; i++)
       {
            yield return new WaitForSeconds(1);
            timerzahl = timerzahl + 1;
       }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Me" && harmlos == false)
        {
            //harmlos = true;
            StartCoroutine(waitsec());
        }

        if (col.gameObject.tag == "Arrow" && pfeilscript.geschossen == true && pfeilscript.critschaden == false)
        {
            leben = leben - pfeilscript.damage;
           // Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "Arrow" && pfeilscript.geschossen == true && pfeilscript.critschaden == true)
        {
            leben = leben - pfeilscript.damage * 2;
        }
    }
    public float getLeben() {
        return leben;
    }
}
