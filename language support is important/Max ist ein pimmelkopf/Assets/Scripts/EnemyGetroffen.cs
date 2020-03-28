using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGetroffen : MonoBehaviour
{
    private Schießen2 schießenscript;
    private EnemyStats enemystatsscript;

    public float leben;
    private Transform target;
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        schießenscript = GameObject.Find("Arrow").GetComponent<Schießen2>();
        enemystatsscript = GameObject.Find("Enemy").GetComponent<EnemyStats>();

        player = GameObject.Find("Me");
        target = GameObject.FindGameObjectWithTag("Arrow").GetComponent<Transform>();


    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, target.position) < 0.5 && schießenscript.geschossen == true)
        {
            enemystatsscript.leben = enemystatsscript.leben - schießenscript.damage;
        }
    }
}
