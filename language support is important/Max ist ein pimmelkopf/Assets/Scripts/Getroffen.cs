using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getroffen : MonoBehaviour
{
     public Schießen2 schießenscript;


    public float leben;
    private Transform target;
    private GameObject player;
    private MeshRenderer renderer;
    static string tagTot = "tot";
    
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(schießenscript.damage);
        //  schießenscript = GameObject.Find("Arrow").GetComponent<Schießen2>();
        
        renderer = gameObject.GetComponent<MeshRenderer>();
        player = GameObject.Find("Me");
        target = GameObject.FindGameObjectWithTag("Arrow").GetComponent<Transform>();
        if (gameObject.tag == tagTot)
        {
            renderer.material.color = Color.black;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, target.position) < 0.5)
        {
            renderer.material.color = Color.blue;
            gameObject.tag = tagTot;
            leben = leben - schießenscript.damage;
            Debug.Log(schießenscript.damage);
        }
        if (gameObject.tag == tagTot)
        {
            renderer.material.color = Color.black;
        }
    }
}
