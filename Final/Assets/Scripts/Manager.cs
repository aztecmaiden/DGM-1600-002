﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Manager : MonoBehaviour {

    private static Manager instance = null;
    public Text scoreboard;
    private int score;
    public Text levelDisplay;
    public Text livesDisplay;
    public int lives;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this.gameObject.GetComponent<Manager>();
        }
        DontDestroyOnLoad(gameObject);
    }

    public void IncrementScore(int value)
    {
        score += value;
        scoreboard.text = score.ToString();
    }

    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Application.Quit");
    }

}
