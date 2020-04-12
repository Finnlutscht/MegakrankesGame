using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Enemyprefab;
    public Transform point;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            spawn();
        }
    }
    public void spawn()
    {
        Vector3 pos = point.position;
        Instantiate(Enemyprefab, pos, Quaternion.identity);
    }
}
