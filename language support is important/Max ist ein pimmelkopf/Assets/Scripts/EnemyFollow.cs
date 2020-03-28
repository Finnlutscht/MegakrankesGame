using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    private EnemyStats enemystatsscript;

    public float speed;
    public float stoppingDistance;


    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        enemystatsscript = GameObject.Find("Enemy").GetComponent<EnemyStats>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    //transform.position = Vector2.MoveTowards(from,to,speed);----------------------------------
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance && enemystatsscript.leben > 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }
    }
}
