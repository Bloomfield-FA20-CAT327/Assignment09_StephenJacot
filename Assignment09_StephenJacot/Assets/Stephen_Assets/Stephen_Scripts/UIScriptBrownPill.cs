using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScriptBrownPill : MonoBehaviour
{
    public static GameObject light;

    public Color colorBlue = Color.blue;

    public Color colorYellow = Color.yellow;

    float duration2 = .5f;
    

    void OnTriggerEnter(Collider other)
    {


        LightController.LightChanger();

        float t = Mathf.PingPong(Time.time, duration2) / duration2;

        foreach (Light light in LightController.lights)
        {
            light.color = Color.Lerp(colorBlue, colorYellow, t);
            //Detects if changing.
        }

        if(other.gameObject.tag == "Player")
        {
            
            GameControllerScript gc = GameObject.FindGameObjectWithTag("Player").GetComponent<GameControllerScript>();
            GameControllerScript.BrownPillAdd();
            Destroy(gameObject);

        }
    }
}
