using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bogenschütze : Player
{
    private Player playerscript;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public bool bewegung = false;
    private Vector2 moveInput;

    private Transform target;
    public int timerzahl;
    public bool unverwundbar;
    private GameObject wand1;
    public bool linkeWand;
    private bool rechteWand;
    private bool obereWand;
    private bool untereWand;
    public float integer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        wand1 = GameObject.Find("Rand1");
    }

    // Update is called once per frame
    void Update()
    {
        if (leben < 1)
        {
            Destroy(gameObject);
        }
        integer = Input.GetAxis("Horizontal");
        
        
    }
    void FixedUpdate()
    {
        bewegen();
        verwundbar();
        
    }
    void bewegen()
    {
            moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            moveVelocity = moveInput.normalized * speed;
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

        if (linkeWand == true)
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                moveInput = new Vector2(0, Input.GetAxis("Vertical"));
                moveVelocity = moveInput.normalized * speed;
                rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
            }
        }
        //----------------------------------------------------------
        if (obereWand == true)
        {
            if (Input.GetAxis("Vertical") > 0)
            {
                moveInput = new Vector2(Input.GetAxis("Horizontal"), 0);
                moveVelocity = moveInput.normalized * speed;
                rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
            }
        }
        //--------------------------------------------------------------
        if (rechteWand == true)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                moveInput = new Vector2(0, Input.GetAxis("Vertical"));
                moveVelocity = moveInput.normalized * speed;
                rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
            }
        }
        //-------------------------------------------------------------------
        if (untereWand == true)
        {
            if (Input.GetAxis("Vertical") < 0)
            {
                moveInput = new Vector2(Input.GetAxis("Horizontal"), 0);
                moveVelocity = moveInput.normalized * speed;
                rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
            }
        }
        //-----------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------
        if (linkeWand == true && obereWand == true)
        {
            if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") < 0)
            {
                moveInput = new Vector2(0, 0);
                moveVelocity = moveInput.normalized * speed;
                rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
            }
        }
        //-----------------------------------------------------------------------------------
        if (linkeWand == true && untereWand == true)
        {
            if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") < 0)
            {
                moveInput = new Vector2(0, 0);
                moveVelocity = moveInput.normalized * speed;
                rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
            }
        }
        //-----------------------------------------------------------------------------------
        if (rechteWand == true && obereWand == true)
        {
            if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") > 0)
            {
                moveInput = new Vector2(0, 0);
                moveVelocity = moveInput.normalized * speed;
                rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
            }
        }
        //-----------------------------------------------------------------------------------
        if (rechteWand == true && untereWand == true)
        {
            if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") > 0)
            {
                moveInput = new Vector2(0, 0);
                moveVelocity = moveInput.normalized * speed;
                rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
            }
        }


        if (Input.GetButton("Horizontal") == true || Input.GetButton("Vertical") == true)
        {
            bewegung = true;
        }
        else
        {
            bewegung = false;
        }
    }
    

    void verwundbar()
    {
        if (Vector2.Distance(transform.position, target.position) > 1.5 || timerzahl == 3)
        {
            unverwundbar = false;
            timerzahl = 0;
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "Enemy" && unverwundbar == false)
        {
            leben = leben - 100;
            unverwundbar = true;
            StartCoroutine(waitsec());
        }

        if(col.gameObject.name == "Rand1") 
        {
            linkeWand = true;
            wand1.GetComponent<Renderer>().material.color = Color.green;
        }
        if (col.gameObject.name == "Rand2")
        {
            obereWand = true;
        }
        if (col.gameObject.name == "Rand3")
        {
            rechteWand = true;
        }
        if (col.gameObject.name == "Rand4")
        {
            untereWand = true;

        }

    }
    void OnCollisionExit2D (Collision2D excol)
    {
        if(excol.gameObject.name == "Rand1")
        {
            linkeWand = false;
        }
        if (excol.gameObject.name == "Rand2")
        {
            obereWand = false;
        }
        if (excol.gameObject.name == "Rand3")
        {
            rechteWand = false;
        }
        if (excol.gameObject.name == "Rand4")
        {
            untereWand = false;
        }
    }
    IEnumerator waitsec()
    {
        while (timerzahl < 4)
        {
            yield return new WaitForSeconds(1);
            timerzahl = timerzahl + 1;
        }
    }
    void OnGUI()
    {
        string healthstring = leben.ToString();
        GUI.Label(new Rect(1000, 10, 100, 30), healthstring);
    }
}
