using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ErfahrungsPunkte : MonoBehaviour
{
    private Bogenschütze bsscript;
    private Transform target;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        bsscript = GameObject.Find("Me").GetComponent<Bogenschütze>();
        target = GameObject.Find("Me").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(bsscript.alleTot == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
