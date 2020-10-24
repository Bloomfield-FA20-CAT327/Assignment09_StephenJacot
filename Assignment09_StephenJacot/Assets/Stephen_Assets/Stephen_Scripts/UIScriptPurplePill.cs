using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScriptPurplePill : MonoBehaviour
{
    public Color colorRed = Color.red;
    public Color colorGreen = Color.green;

    Text uiText;

    public int purplePill;
    public int greenLightNumber;
    

    float duration = .5f;

    void Start()
    {
        uiText = GameObject.Find("ColorCountText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string textInfo = "";

        textInfo += "Amount of Purple Pills Eaten " + purplePill + "\n";

        uiText.text = textInfo;
        if(Input.GetKeyDown(KeyCode.F))
        {
            LightController.LightChanger();

            float t = Mathf.PingPong(Time.time, duration) / duration;

            foreach(Light light in LightController.lights)
            {
                light.color = Color.Lerp(colorRed, colorGreen, t);
                //Detects if changing.

                if(light.color == Color.Lerp(colorRed,colorGreen,t))
                {
                    purplePill += 1;
                }

            }
        }


    }
}
