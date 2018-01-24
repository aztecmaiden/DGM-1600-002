using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventure : MonoBehaviour {



    public enum States { room, window, familyRoom, bed};
    public States currentState;


	// Use this for initialization
	void Start () {
        currentState = States.room;
		
	}

    // Update is called once per frame
    void Update() {
        if (currentState == States.room) {
            Room();
        }
        else if (currentState == States.window){
            Window();
        }
        else if (currentState == States.bed)
        {
            Bed();
        }
    }
    private void Room(){
        print("You wake up in your room. You feel cold and dizzy. \n " +
            "There is a Window  \n" +
            "There is the Family Room. \n" +
            "There is a Bed. \n" +

            "Press W for Window, G for Gate, B for Bed.");
        if (Input.GetKeyDown(KeyCode.W)) {  currentState = States.window;}
        if (Input.GetKeyDown(KeyCode.F)) { currentState = States.familyRoom; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
    private void Window()
    {
        print("You look outside. \n" +
            "You expect to see the outside world but instead all you see is a brick wall.\n" + 

            "Press C to go back to room"
            );
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.room; }
    

    }
    private void Bed()
    {
        print("Even though you just woke up you still feel tired. \n" +
            "For some reason you were sleeping on the floor but spot your bed across the room. \n" +

            "Press "
            );
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.room; }


    }




}
