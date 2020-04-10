using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandBerührung : MonoBehaviour
{
    private Bogenschütze bogenschützenscript;
    // Start is called before the first frame update
    void Start()
    {
        bogenschützenscript = GameObject.Find("Me").GetComponent<Bogenschütze>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if(Input.GetAxis("Horizontal") == 1)
            {
                
            }
        }

    }
    /*void bewegen()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

        if (Input.GetButton("Horizontal") == true || Input.GetButton("Vertical") == true)
        {
            bewegung = true;
        }
        else
        {
            bewegung = false;
        }

    }*/
}
