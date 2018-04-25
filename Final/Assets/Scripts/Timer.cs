using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timer;
    public float timeLeft;
    public bool stop;



    void Update()
    {
        timeLeft -= Time.deltaTime;
        timer.text = "Time Left:" + Mathf.Round(timeLeft);
        if (timeLeft < 0)
        {
            Application.LoadLevel("GameOver");
        }
    }
}
