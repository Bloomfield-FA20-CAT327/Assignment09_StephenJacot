using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{

    Text uiText1;

    Text uiText2;

    Text gameOver;

    public static PillStats pill;



    public static int bluepill;
    // Start is called before the first frame update

    void Awake()
    {


       if(this == null)
        {
            pill = new PillStats();
        }

        
    }
    void Start()
    {
        uiText1 = GameObject.Find("ColorCountText2").GetComponent<Text>();

        gameOver = GameObject.Find("GameOverText").GetComponent<Text>();

        uiText2 = GameObject.Find("ColorCountText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PillStats.bluepill != 6)
        {
            gameOver.enabled = false;
        }
        else if(PillStats.bluepill == 6)
        {
            uiText1.enabled = false;
            uiText2.enabled = false;
            gameOver.enabled = true;
        }
        string othertextinfo = "";
        string textInfo = "";

        if(PillStats.bluepill > 6 && PillStats.bluepill > 6)
        {
            
        }

        othertextinfo += "Amount of Brown Pills Eaten " + PillStats.brownpill + "\n";
        

        textInfo += "Amount of Purple Pills Eaten " + PillStats.bluepill + "\n";

        uiText2.text = textInfo;


        uiText1.text = othertextinfo;
    }

    public static void BrownPillAdd()
    {
        PillStats.brownpill += 1;
    }

    public static void BluePillAdd()
    {
        PillStats.bluepill += 1;
    }


    public static void LastLevel()
    {
        PillStats.level = SceneManager.GetActiveScene().buildIndex - 1;
        
    }

    public static void UpLevel()
    {
        PillStats.level = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(PillStats.level);
    }

    

    
}
