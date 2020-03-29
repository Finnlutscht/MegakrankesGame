using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sleep : MonoBehaviour
{
    private Material ownedMaterial;
    
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Renderer>().material.color = Color.red;

        StartCoroutine(waitsec());
        OnEnable();
        OnDisable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator waitsec()
    {
        
        yield return new WaitForSeconds(1);
        hallo();

    }
    void hallo()
    {
        GetComponent<Renderer>().material.color = Color.red;
       
    }
    void OnEnable()
    {
        ownedMaterial = new Material(Shader.Find("Diffuse"));
        ownedMaterial.hideFlags = HideFlags.HideAndDontSave;
        GetComponent<Renderer>().sharedMaterial = ownedMaterial;
    }
    void OnDisable()
    {
        DestroyImmediate(ownedMaterial);
    }
}
