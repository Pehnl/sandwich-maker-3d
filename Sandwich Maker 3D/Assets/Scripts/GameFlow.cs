using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameFlow : MonoBehaviour
{
    public static GameFlow instance;

    

    public static int order = SandwichMenu.orderValue;
    public static int plateValue = 000000;
    public static int playerScore = 0;
    public bool countDownDone = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 /*   public void AddPoint()
    {
        playerScore += 1;
        scoreText.text = "SCORE: " + playerScore.ToString();
        Debug.Log("Nice");
        GameFlow.plateValue = 000000;
    }*/


}
