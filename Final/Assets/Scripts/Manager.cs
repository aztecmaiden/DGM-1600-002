using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Manager : MonoBehaviour {

    public Text scoreboard;
    private int score;

    public void IncrementScore(int value)
    {
        score += value;
        scoreboard.text = score.ToString();
    }


}
