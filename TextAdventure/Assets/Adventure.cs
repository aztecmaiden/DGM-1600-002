using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour {



    public enum States { room, window, familyRoom, bed, sleep, mourning, win, lose};
    public States currentState;
    public Text textObject;
    public Text titleObject;


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
        textObject.text = "You wake up in your room. You feel cold and dizzy. \n " +
            "There is a Window  \n" +
            "There is the Family Room. \n" +
            "There is a Bed. \n" +

            "Press T for Window, F for Family Room, B for Bed.";
        if (Input.GetKeyDown(KeyCode.T)) {  currentState = States.window;}
        if (Input.GetKeyDown(KeyCode.F)) { currentState = States.familyRoom; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
    private void Window(){
        textObject.text = "You look outside. \n" +
            "You expect to see the outside world but instead all you see is a brick wall.\n" + 

            "Press C to go back to room";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.room; }
    

    }
    private void Bed()
    {
        textObject.text = "For some reason you were sleeping on the floor but spot your bed across the room. \n" +
            "Even though you just woke up you still feel tired. \n" +

            "Should you go to sleep in the bed or actually accomplish something? \n" +

            "Press S to sleep or C to go back to room ";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.room; }
        if (Input.GetKeyDown(KeyCode.S)) { currentState = States.sleep; }

        }
    private void sleep()
    {
        textObject.text = "So you give in to your lazy urges/n" +
            "Walking over to the bed, you notice that someone is already asleep/n" +
            "Someone that looks a lot like you/n" +
            "You pass out from shock./n" + 

            "Press L to Continue";
        if (Input.GetKeyDown(KeyCode.L)) { currentState = States.lose; }

    }
    private void familyRoom()
        {
         textObject.text = "You're cold and need to find a thermostat. \n" +
                "Even though you just woke up you still feel tired. \n" +

                "Should you go to sleep in the bed or actually accomplish something? \n" +

                "Press S to sleep or C to go back to room ";
            if (Input.GetKeyDown(KeyCode.C)) { currentState = States.room; }
        }
    private void Mourning()*************
    {
        textObject.text = "You walk into the family room. \n" +
               "Everyone of your relatives are sitting around \n" +

               "Should you go to sleep in the bed or actually accomplish something? \n" +

               "Press S to sleep or C to go back to room ";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.room; }
    }
        private void lose()
    {
        textObject.text = "You Died but then again can Ghosts even die?/n" +


            "Press C to Play again";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.room; }

    }




}
