using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DONTDESTROYCANVAS : MonoBehaviour
{
    public GameObject canvas;

    void Awake()
    {
        canvas = GameObject.FindGameObjectWithTag("Canvas");

        if(canvas)
        {
            DontDestroyOnLoad(canvas);
        }    
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
