using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCountDown : MonoBehaviour
{

    private GameFlow GFlow;
    /// <summary>
    /// 3... 2... 1... GO
    /// </summary>
    public void SetCountDownTimer()
    {
        GFlow = GameObject.Find("GameManager").GetComponent<GameFlow>();
        GFlow.countDownDone = true;
    }
}
