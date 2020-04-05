using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrowstats : MonoBehaviour
{
    private Transform spitze;
    // Start is called before the first frame update
    void Start()
    {
        spitze = GameObject.FindGameObjectWithTag("Spitze").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector3 lookVektor = spitze.position - transform.position;
        //transform.rotation = Quaternion.LookRotation(lookVektor);
    }
}
