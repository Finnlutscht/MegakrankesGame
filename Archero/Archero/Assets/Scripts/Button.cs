using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    private Bogenschütze bsscript;
    // Start is called before the first frame update
    void Start()
    {
        bsscript = GameObject.Find("Me").GetComponent<Bogenschütze>();
    }
    public void addHealth()
    {
        bsscript.leben = bsscript.leben + 250;
        // Application.LoadLevel(sceneName);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
