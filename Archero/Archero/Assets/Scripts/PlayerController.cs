using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    //GameObject[] wand = new GameObject[2];
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      //  wand = GameObject.FindGameObjectsWithTag("Wand");
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }

    void FixedUpdate()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        //if (wand.BoxCollider.isTriggered = true)
        //{
        // transform.material.color = Color.green;
        //}
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
