using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float damage;
    public float leben;



    void Start()
    {
        damage = 100;
        leben = 500;
    }
    //transform.position = Vector2.MoveTowards(from,to,speed);----------------------------------
    // Update is called once per frame
    void FixedUpdate()
    {
        if (leben < 1)
        {
            Destroy(gameObject);
        }



    }


}
