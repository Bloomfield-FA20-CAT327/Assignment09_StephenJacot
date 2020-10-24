using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public static Light[] lights;

    public static Color colorred = Color.red;

    private static LightController instance = null;


    public static LightController Instance
    {
        get
        {
            if(instance == null)
            {

                instance = FindObjectOfType<LightController>();
                if(instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = "LightController";
                    instance = obj.AddComponent<LightController>();

                    

                    DontDestroyOnLoad(obj);
                }
            }
            return instance;
        }
    }

    public static void LightChanger()
    {

        lights = FindObjectsOfType(typeof(Light)) as Light[];

    }

    public void Awake()
    {
        if(instance != null)
        {
            instance = this;
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
