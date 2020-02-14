using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Joystick jsl;
    public float fwws = 40f;
    public float bwws = 20f;
    public Rigidbody rb;


    void Update()
    {
        if (jsl.Vertical >= .2f)
        {
            rb.AddForce(0, 0, fwws * Time.deltaTime);
        }
        else if (jsl.Vertical <= -.2f)
        {
            rb.AddForce(0, 0, - fwws * Time.deltaTime);
        }

        if (jsl.Horizontal >= .2f)
        {
            rb.AddForce(fwws * Time.deltaTime, 0, 0);
        }
        else if (jsl.Horizontal <= - .2f)
        {
            rb.AddForce(- fwws * Time.deltaTime, 0, 0);
        }
    }
}
