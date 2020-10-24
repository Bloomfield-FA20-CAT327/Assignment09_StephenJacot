using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DONTDESTROYPLAYER : MonoBehaviour
{
    private GameObject player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if(player)
        {
            DontDestroyOnLoad(player);
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
