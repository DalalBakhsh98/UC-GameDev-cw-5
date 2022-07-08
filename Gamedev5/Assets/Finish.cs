using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    //public int iLevelToLoad;
    //public string sleveltoload;

    //public bool useInt2LoadLev = false;

    // Start is called before the first frame update
    void Start()
    {
      

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level 2");
        }

        
    }

    // useless code that drove me crazy !!!

    //GameObject collisionGameObject = collision.gameObject;

    //if(collisionGameObject.name == "Player")
    //{
    //    loadscene();
    //}

    //void loadscene()
    //{
    //    if(useInt2LoadLev)
    //    {
    //        SceneManager.LoadScene(iLevelToLoad);
    //    }
    //    else
    //    {
    //        SceneManager.LoadScene(sleveltoload);   
    //    }
    //}
}
