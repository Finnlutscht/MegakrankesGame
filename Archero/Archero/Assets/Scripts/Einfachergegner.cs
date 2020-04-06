using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Einfachergegner : Enemy
{
    private Pfeil pfeilscript;

    // Start is called before the first frame update
    void Start()
    {
        pfeilscript = GameObject.Find("Arrow").GetComponent<Pfeil>();
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
        if (col.gameObject.tag == "Arrow" && pfeilscript.geschossen == true && pfeilscript.critschaden == false)
        {
            leben = leben - pfeilscript.damage;
        }
        if (col.gameObject.tag == "Arrow" && pfeilscript.geschossen == true && pfeilscript.critschaden == true)
        {
            leben = leben - pfeilscript.damage * 2;
        }
    }
    public float getLeben() {
        return leben;
    }
}
