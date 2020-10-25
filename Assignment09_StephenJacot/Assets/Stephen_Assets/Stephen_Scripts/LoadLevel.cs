using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LoadLevel : MonoBehaviour
{

    private GameObject levelDoor;
    public int buildIndex = 0;
    
    void Start()
    {

        if (levelDoor == null)
        {
            DontDestroyOnLoad(gameObject);
            levelDoor = this.gameObject;
        }
        else if(levelDoor != this)
        {
            Destroy(gameObject);
        }
            
           
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }


    void OnTriggerEnter(Collider other)
    {
        GameControllerScript gc = GameObject.FindGameObjectWithTag("Player").GetComponent<GameControllerScript>();
        GameControllerScript.UpLevel();
       
    }
}
