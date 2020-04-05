using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Einfachergegner : Enemy
{
    private Schießen2 schießenscript;

    // Start is called before the first frame update
    void Start()
    {

        schießenscript = GameObject.Find("Arrow").GetComponent<Schießen2>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
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
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Arrow" && schießenscript.geschossen == true && schießenscript.critschaden == false)
        {
            leben = leben - schießenscript.damage;


        }
        if (col.gameObject.tag == "Arrow" && schießenscript.geschossen == true && schießenscript.critschaden == true)
        {
            leben = leben - schießenscript.damage * 2;

        }

    }

    public float getLeben() {
        return leben;
    }

}
