using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScriptBrownPill : MonoBehaviour
{
    public static GameObject light;

    public Color colorBlue = Color.blue;

    Text uiText;

    public Color colorYellow = Color.yellow;

    float duration2 = .5f;

    private int brownpill;


    void Awake()
    {
        


        if (light == null)
        {
            DontDestroyOnLoad(gameObject);
            light = this.gameObject;


        }
        else if (light != this)
        {
            
        }  
    }


    void Start()
    {
        uiText = GameObject.Find("ColorCountText2").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string othertextinfo = "";

        othertextinfo += "Amount of Brown Pills Eaten " + brownpill + "\n";

        uiText.text = othertextinfo;

        if (Input.GetKeyDown(KeyCode.G))
        {
            LightController.LightChanger();

            float t = Mathf.PingPong(Time.time, duration2) / duration2;

            foreach (Light light in LightController.lights)
            {
                light.color = Color.Lerp(colorBlue, colorYellow, t);
                //Detects if changing.

                if (light.color == Color.Lerp(colorBlue, colorYellow, t))
                {
                    brownpill += 1;
                }

            }


        }


        //Create a OnTriggerEnter for each pill

        //Then use playerPref to keep all values across levels

        //Create an if statement in update on gameController to check if a certain amount is met if it is then endGame

        //Do all tonight.
    }
}
