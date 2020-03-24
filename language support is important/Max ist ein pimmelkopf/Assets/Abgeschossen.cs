using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abgeschossen : MonoBehaviour
{
    public float leben;
    private Transform target;
    public GameObject arrow;
    private GameObject player;
    private MeshRenderer renderer;
    
    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<MeshRenderer>();
        player = GameObject.Find("Me");
        target = GameObject.FindGameObjectWithTag("Arrow").GetComponent<Transform>();
        
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
        }
    }
}
