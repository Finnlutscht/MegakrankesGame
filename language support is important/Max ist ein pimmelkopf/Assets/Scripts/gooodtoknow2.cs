using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gooodtoknow : MonoBehaviour
{
    //public LevelMaganger myLevelManager;
    //-----------------------------
    //LevelMaganger myLevelManager;
    //myLevelManager = GameObject.Find("LevelManager).GetComponent<LevelManager>();

    //------------------------------------------------------
    private Transform target;
    private GameObject player;
    private MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        //renderer = gameObject.GetComponent<MeshRenderer>();
      //  player = GameObject.Find("Me");
      //  target = GameObject.FindGameObjectWithTag("Arrow").GetComponent<Transform>();
      //  renderer.material.color = Color.blue;
        //-------------------------------------------------------------------
    }

    // Update is called once per frame
    void Update()
    {
        // float horizontal_movement = Input.GetAxis("Horizontal") ;
        // float vertical_movement = Input.GetAxis("Vertical") ;
        // transform.Translate(horizontal_movement * speed * Time.deltaTime, vertical_movement * speed * Time.deltaTime, 0);
        //System.Threading.Thread.Sleep(3000);
        //Vector3 lookVektor = target.position - transform.position;
        //transform.rotation = Quaternion.LookRotation(lookVektor);
    }
}
