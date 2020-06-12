using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchießenderGegner : Enemy
{
    private Pfeil pfeilscript;
    private Bogenschütze bsscript;
    private bool freigabe;
    public GameObject SchleimballPrefab;
    public GameObject EpPrefab;

    void Start()
    {
        freigabe = true;
        pfeilscript = GameObject.FindGameObjectWithTag("Arrow").GetComponent<Pfeil>();
        bsscript = GameObject.Find("Me").GetComponent<Bogenschütze>();

    }
    
    void FixedUpdate()
    {
        abschuss();
        if (leben < 1)
        {
            Instantiate(EpPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    void abschuss()
    {
        
        if (freigabe == true)
        {
            Instantiate(SchleimballPrefab, transform.position, Quaternion.identity);
            freigabe = false;
            StartCoroutine(warten());
        }
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Arrow" && pfeilscript.critschaden == false)
        {
            leben = leben - bsscript.damage;
        }
        else if (col.gameObject.tag == "Arrow" && pfeilscript.critschaden == true)
        {
            leben = leben - bsscript.damage * 2;
        }
    }
    IEnumerator warten()
    {
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(1);
        }
        freigabe = true;
    }
}
