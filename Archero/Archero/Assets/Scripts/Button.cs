using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    private Bogenschütze bsscript;
    public float delay ;
    public string NewLevel = "2";
    // Start is called before the first frame update
    void Start()
    {
        bsscript = GameObject.Find("Me").GetComponent<Bogenschütze>();
    }
    public void addHealth0()
    {
        bsscript.leben = bsscript.leben + 250;
        // Application.LoadLevel(sceneName);
        Destroy(gameObject);
        SceneManager.LoadScene(0);
    }
    public void addHealth1()
    {
        //StartCoroutine(LoadLevelAfterDelay(1));
        bsscript.leben = bsscript.leben + 250;
        // Application.LoadLevel(sceneName);
        Destroy(gameObject);
        PlayerPrefs.SetFloat("leben", bsscript.leben);
        SceneManager.LoadScene(1);
    }
    public void addHealth2()
    {
        bsscript.leben = bsscript.leben + 250;
        // Application.LoadLevel(sceneName);
        Destroy(gameObject);
        SceneManager.LoadScene(2);
    }
   
   
    
        
  

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(NewLevel);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
