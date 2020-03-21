using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schießen : MonoBehaviour
{
    public PlayerController controller;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        if (moveVelocity == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}

