using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour {



    public enum States { room, window, familyRoom, bed, sleep, mourning, investigate,talkFamily, reaper, win, lose};
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
    private void Mourning()
    {
        textObject.text = "You walk into the family room. \n" +
               "Every one of your relatives are sitting around \n" +
               "Each of them weeping. \n" +

               "Should you investigate (I) or talk to a family member (T)? ";
        if (Input.GetKeyDown(KeyCode.I)) { currentState = States.investigate; }
        if (Input.GetKeyDown(KeyCode.T)) { currentState = States.talkFamily; }
    }
    private void Investigate()
    {
        textObject.text = "Looking around you notice that your picture is EVERYWHERE. \n" +
               "And everyone is wearing black \n" +
               "Each of them weeping and wearing black. \n" +

               "No one has noticed you except for one person. \n" +

               "Approach the Stranger (R) ";
        if (Input.GetKeyDown(KeyCode.R)) { currentState = States.reaper; }
    }
    private void talkFamily()
    {
        textObject.text = "No one looks at you. \n" +
                    "You even wave your hand in Gram Gram's face.\n" +
               " Something you would NEVER do, but nothing. \n" +

               "You're about to give up hope when a stranger in the corner notices you. \n" +

               "Approach the Stranger (R)";
        if (Input.GetKeyDown(KeyCode.R)) { currentState = States.reaper; }
    }
    private void Reaper()
    {
        textObject.text = "A skeletal figure wearing a black hood?! \n" +
               "Jiminy Jaminy! It's the Grim Reaper. \n" +
               "Each of them weeping and wearing black.  \n" +

               "Realizing that you're dead, emotion fills you up. \n" +

               "What do you do with all this emotion? \n " +
               "Get in a fist fight with the grim reaper(G) or have an emotional talk with them (E)";
        if (Input.GetKeyDown(KeyCode.I)) { currentState = States.investigate; }
    }
    private void lose()
    {
        textObject.text = "You Died but then again can Ghosts even die?/n" +


            "Press C to Play again";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.room; }

    }




}
