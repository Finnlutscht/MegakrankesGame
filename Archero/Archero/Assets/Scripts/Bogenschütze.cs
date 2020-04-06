using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bogenschütze : Player
{
    private Player playerscript;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    private Transform target;
    public int timerzahl;
    public bool unverwundbar;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (leben < 1)
        {
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {
        bewegen();
        verwundbar();
    }
    void bewegen()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        
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
