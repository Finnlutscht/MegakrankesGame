using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bogenschütze : Player
{
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public bool bewegung = false;
    private Vector2 moveInput;
    public GameObject Arrowprefab;
    public float feuerrateProSekunde;
    public float critRateInProzent;
    public float mehrfachSchuss;
    public bool alleTot;
    private GameObject closestPlayer;
    private GameObject closest;
    private Spawn spawnscript;
    private bool gespawnt;

    private Transform target;
    private bool timer;
    private bool linkeWand;
    private bool rechteWand;
    private bool obereWand;
    private bool untereWand;

    // Start is called before the first frame update
    void Start()
    {
        leben = PlayerPrefs.GetFloat("leben");
        gespawnt = false;
        spawnscript = GameObject.Find("Spawn").GetComponent<Spawn>();
        timer = true;
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
        if (alleTot == true && gespawnt == false)
        {

            gespawnt = true;
            spawnscript.belohnugAussuchen();

        }
    }
    void FixedUpdate()
    {
        bewegen();
        abschuss();
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
    void abschuss()
    {
        closestPlayer = FindClosestEnemy();

        if (bewegung == false && timer == true && alleTot == false)
        {
            Instantiate(Arrowprefab, transform.position, Quaternion.identity);
            for (int i = 0; i < mehrfachSchuss; i++)
            {
                StartCoroutine(zweiterAbschuss());
            }
            timer = false;
            StartCoroutine(waitsec());
        }
        if (closestPlayer.name == "Test")
        {
            alleTot = true;

        }
    }
    IEnumerator zweiterAbschuss()
    {
        yield return new WaitForSeconds(0.05f);
        Instantiate(Arrowprefab, transform.position, Quaternion.identity);

    }


    IEnumerator waitsec()
    {
        if (timer == false)
        {
            yield return new WaitForSeconds(1 / feuerrateProSekunde);
            timer = true;
        }
    }



    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Health")
        {
            leben = leben + 200;
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "Enemy")
        {
            leben = leben - 100;

        }
        if (col.gameObject.tag == "Schleimball")
        {
            leben = leben - 150;
        }
        //-------------Rand-----------------
        if (col.gameObject.name == "Rand1")
        {
            linkeWand = true;

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
    void OnCollisionExit2D(Collision2D excol)
    {
        if (excol.gameObject.name == "Rand1")
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
    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Enemy");
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }

    void OnGUI()
    {
        string healthstring = leben.ToString();
        GUI.Label(new Rect(1000, 10, 100, 30), healthstring);
    }
    public void addHealth()
    {
        leben = leben + 250;
    }
    public void ChangeScene(String sceneName)
    {
        Application.LoadLevel(sceneName);
    }

    /*void endSzene()
    {
        PlayerPrefs.SetFloat("leben", leben);
    }
*/
}
