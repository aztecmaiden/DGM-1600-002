using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Manager : MonoBehaviour {

    private static Manager instance = null;
    private int score;
    public Text levelDisplay;    
    public Text scoreboard;
    public int lives;
   

    public void Awake()
    {
        if(instance == null)
        {
            instance = this.gameObject.GetComponent<Manager>();
        }
        else {
            Destroy(this.gameObject);
         }
        DontDestroyOnLoad(gameObject);
    }

    public void IncrementScore(int value)
    {
        score += value;
        if(scoreboard == null)
        {
            scoreboard = GameObject.Find("Score").gameObject.GetComponent<Text>();
        }
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

