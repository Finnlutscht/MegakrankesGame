﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFollow : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;


    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    //transform.position = Vector2.MoveTowards(from,to,speed);----------------------------------
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }
    }
}
