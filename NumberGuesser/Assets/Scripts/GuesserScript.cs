using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuesserScript : MonoBehaviour {

    public int max;
    public int min;
    public int guess;

    // Use this for initialization
    private void Start () {

       
        print("Welcome to Number Guesser");
        print("Pick a Number between " + min + " and " + max);


        //Is the value GUESS
        print("Is the number 500?");
        //Instructions -Push these buttons
        print("Up arrow for higher, Down arrow for lower, Enter for correct.");
      

	}
	
	// Update is called once per frame
	public void Update () {
       
	}
}
