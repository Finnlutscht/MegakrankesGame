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
       // StartCoroutine(waitsec());
       //----------------------------------
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
        //Vector3 lookVektor = target.position - transform.position;
        //transform.rotation = Quaternion.LookRotation(lookVektor);
    }
    /*
    IEnumerator DoSomething()
    {
        DoThingOne();
        yield return new WaitForSeconds(1);
        DoThingTwo();
    }*/
    //---------------------------------------------------------
    /*void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Enemy")
        {
            Destroy(col.gameObject);
        }
    }*/
    /*
     * public void ChangeScene(String sceneName)
     * {
     * Application.LoadLevel(sceneName);
     * }
     */
}
