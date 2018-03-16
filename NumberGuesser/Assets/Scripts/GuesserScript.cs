using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuesserScript : MonoBehaviour {

    public int max;
    public int min;
    private int guess;
    public int count;

    // Use this for initialization
    private void Start () {

       
        print("Welcome to Number Guesser");
        print("Pick a Number between " + min + " and " + max);


        //Is the value GUESS
        GuessQuestion();
        //Instructions -Push these buttons
        print("Up arrow for higher, Down arrow for lower, Enter for correct.");

        max = max + 1;
	}

    private void GuessQuestion(){
        count --;
        //figure out how to get guess to be randomized**************************
        // guess = (max + min) / 2;
        guess = Random.Range(min, max);
        print("Is the number " + guess + "?");

    }
	
	// Update is called once per frame
	public void Update () {
    //up arrow
       if (Input.GetKeyDown(KeyCode.UpArrow)){
            min = guess;
            GuessQuestion();
        }
        //down arrow
         else if (Input.GetKeyUp(KeyCode.DownArrow)) {
            max = guess;
            GuessQuestion();

        }
        //enter button
          else if (Input.GetKeyDown(KeyCode.Return)){
            print("The System wins!");
        }
        // if count gets to zero you win***************
        else if (count == 0)
        {
            print("The Indvidual Wins! \n");
        }
    }
}

