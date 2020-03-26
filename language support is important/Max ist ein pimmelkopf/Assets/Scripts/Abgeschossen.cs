using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abgeschossen : MonoBehaviour
{
    public float leben;
    private Transform target;
    private GameObject player;
    private MeshRenderer renderer;
    static string tagUntagged = "Untagged";
    public Schießen2 schießenscript;

    // Start is called before the first frame update
    void Start()
    {
        //  schießenscript = GameObject.Find("Arrow").GetComponent<Schießen2>();

        renderer = gameObject.GetComponent<MeshRenderer>();
        player = GameObject.Find("Me");
        target = GameObject.FindGameObjectWithTag("Arrow").GetComponent<Transform>();
        if (gameObject.tag == tagUntagged)
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
            gameObject.tag = tagUntagged;
            leben = leben - schießenscript.damage;
            Debug.Log(schießenscript.damage);
        }
        if (gameObject.tag == tagUntagged)
        {
            renderer.material.color = Color.black;
        }
    }
}
