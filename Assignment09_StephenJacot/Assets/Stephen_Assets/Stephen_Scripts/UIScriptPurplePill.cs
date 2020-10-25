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

    void OnTriggerEnter(Collider other)
    {
        LightController.LightChanger();

        float t = Mathf.PingPong(Time.time, duration) / duration;

        foreach (Light light in LightController.lights)
        {
            light.color = Color.Lerp(colorRed, colorGreen, t);
        }

        if (other.gameObject.tag == "Player")
        {

            GameControllerScript gc = GameObject.FindGameObjectWithTag("Player").GetComponent<GameControllerScript>();
            GameControllerScript.BluePillAdd();
            Destroy(gameObject);

        }
    }
}
