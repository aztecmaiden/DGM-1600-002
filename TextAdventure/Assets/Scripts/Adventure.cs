using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour {



    public enum States { room, window, hallway, bed, sleep, mourning, investigate,talkFamily, reaper, fightReaper, emotionalMoment, sayNo, riddle, win, lose};
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
        else if (currentState == States.hallway)
        {
            Hallway();
        }
        else if (currentState == States.sleep)
        {
            Sleep();
        }
        else if (currentState == States.mourning)
        {
            Mourning();
        }
        else if (currentState == States.investigate)
        {
            Investigate();
        }
        else if (currentState == States.talkFamily)
        {
            TalkFamily();
        }
        else if (currentState == States.reaper)
        {
            Reaper();
        }
        else if (currentState == States.fightReaper)
        {
            FightReaper();
        }
        else if (currentState == States.emotionalMoment)
        {
            EmotionalMoment();
        }
        else if (currentState == States.sayNo)
        {
            SayNo();
        }
        else if (currentState == States.riddle)
        {
            Riddle();
        }
        else if (currentState == States.win)
        {
            Win();
        }
        else if (currentState == States.lose)
        {
            Lose();
        }
    }

    private void Room(){
        titleObject.text = "The Room Where it Happens";
        textObject.text = "You wake up in your room. You feel cold and dizzy. \n " +
            "There is a Window  \n" +
            "There is the Family Room. \n" +
            "There is a Bed. \n \n" +

            "Press T for Window, F for Family Room, B for Bed.";
        if (Input.GetKeyDown(KeyCode.T)) {  currentState = States.window;}
        if (Input.GetKeyDown(KeyCode.F)) { currentState = States.hallway; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }
    private void Window(){
        titleObject.text = "Waving Through a Window";
        textObject.text = "You look outside. \n" +
            "You expect to see the outside world but instead all you see is a brick wall.\n \n" + 

            "Press C to go back to room";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.room; }
    

    }
    private void Bed()
    {
        titleObject.text = "Why Leave Your Bed?";
        textObject.text = "For some reason you were sleeping on the floor but spot your bed across the room. \n" +
            "Even though you just woke up you still feel tired. \n" +

            "Should you go to sleep in the bed or actually accomplish something? \n \n" +

            "Press S to sleep or C to go back to room ";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.room; }
        if (Input.GetKeyDown(KeyCode.S)) { currentState = States.sleep; }

        }
    private void Sleep()
    {
        titleObject.text = "Any Dream Will Do";
        textObject.text = "So you give in to your lazy urges\n" +
            "Walking over to the bed, you notice that someone is already asleep\n" +
            "Someone that looks a lot like you/n" +
            "You pass out from shock.\n \n" + 

            "Press L to Continue";
        if (Input.GetKeyDown(KeyCode.L)) { currentState = States.lose; }

    }
    private void Hallway()
        {
        titleObject.text = "Skittering Down the Hallway";
        textObject.text = "You're cold and need to find a thermostat. \n" +
                "On your thermostat hunt, you hear wailing. \n \n" +

                "Press M to Investigate";
            if (Input.GetKeyDown(KeyCode.M)) { currentState = States.mourning; }
        }
    private void Mourning()
    {
        titleObject.text = "No One Mourns the Wicked";
        textObject.text = "You walk into the family room. \n" +
               "Every one of your relatives are sitting around \n" +
               "Each of them weeping. \n \n" +

               "Should you investigate (I) or talk to a family member (T)? ";
        if (Input.GetKeyDown(KeyCode.I)) { currentState = States.investigate; }
        if (Input.GetKeyDown(KeyCode.T)) { currentState = States.talkFamily; }
    }
    private void Investigate()
    {
        titleObject.text = "Investigation";
        textObject.text = "Looking around you notice that your picture is EVERYWHERE. \n" +
               "And everyone is wearing black \n" +
               "Each of them weeping and wearing black. \n" +

               "No one has noticed you except for one person. \n \n" +

               "Approach the Stranger (R) ";
        if (Input.GetKeyDown(KeyCode.R)) { currentState = States.reaper; }
    }
    private void TalkFamily()
    {
        titleObject.text = "Invisible";
        textObject.text = "No one looks at you. \n" +
                    "You even wave your hand in Gram Gram's face.\n" +
               " Something you would NEVER do, but nothing. \n" +

               "You're about to give up hope when a stranger in the corner notices you. \n \n" +

               "Approach the Stranger (R)";
        if (Input.GetKeyDown(KeyCode.R)) { currentState = States.reaper; }
    }
    private void Reaper()
    {
<<<<<<< Updated upstream
        titleObject.text = "Keeper of the Reaper";
=======
        titleObject.text = "Wait, What?";
>>>>>>> Stashed changes
        textObject.text = "A skeletal figure wearing a black hood?! \n" +
               "Jiminy Jaminy! It's the Grim Reaper. \n" +
               "Each of them weeping and wearing black.  \n" +
               "Realizing that you're dead, emotion fills you up. \n" +

               "What do you do with all this emotion? \n \n " +
               "Get in a fist fight with the grim reaper(G)\n" +
               "Or have an emotional talk with them (E)";
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.fightReaper; }
        if (Input.GetKeyDown(KeyCode.E)) { currentState = States.emotionalMoment; }
    }
    private void FightReaper()
    {
<<<<<<< Updated upstream
        titleObject.text = "Fight! Fight! Fight!";
        textObject.text = "Filled with anger and rage you rush at him, \n" +
           "with your fists raised ready for a brawl. \n" +
           "However, you can't beat death. \n  \n" +

           "Physically or Metaphorically, can't do it. \n" +

           "You have royally messed up. \n \n " +
           "Press L to continue";
=======
        titleObject.text = "What?";
        textObject.text = "Filled with anger and rage you rush at him, \n" +
           "with your fists raised ready for a brawl. \n" +

           "But it's the Grim Reaper, and you can't beat death. \n" +
           "Not Literally or Metaphorically. \n" +
           "Press L to Continue.";
>>>>>>> Stashed changes
    if (Input.GetKeyDown(KeyCode.L)) { currentState = States.lose; }
    }
    private void EmotionalMoment()
    {
        titleObject.text = "Oscar Winnin Moment";
        textObject.text = "You just start crying. \n" +
               "And whether it's actually sympathy or pity, \n" +
               "The Reaper decides to help you.  \n" +

               "But only if you answer his riddle.\n \n" +

               "Do you answer their riddle(Q) or is that a no? (N)";
        if (Input.GetKeyDown(KeyCode.Q)) { currentState = States.riddle; }
        if (Input.GetKeyDown(KeyCode.N)) { currentState = States.sayNo; }
    }
    private void Riddle()
    {
        titleObject.text = "The Reaper's Riddle";
        textObject.text = "I have three apples.  \n" +
               "If you take away two from me, \n" +
               " how many do you have? \n \n" +

               "Press a number between 1-5";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { currentState = States.lose; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { currentState = States.win; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { currentState = States.lose; }
        if (Input.GetKeyDown(KeyCode.Alpha4)) { currentState = States.lose; }
        if (Input.GetKeyDown(KeyCode.Alpha5)) { currentState = States.lose; }
        if (Input.GetKeyDown(KeyCode.Keypad1)) { currentState = States.lose; }
        if (Input.GetKeyDown(KeyCode.Keypad2)) { currentState = States.win; }
        if (Input.GetKeyDown(KeyCode.Keypad3)) { currentState = States.lose; }
        if (Input.GetKeyDown(KeyCode.Keypad4)) { currentState = States.lose; }
        if (Input.GetKeyDown(KeyCode.Keypad5)) { currentState = States.lose; }
    }
    private void SayNo()
    {
<<<<<<< Updated upstream
        titleObject.text = "Say Not to This";
        textObject.text = "You decide to not take the offer. \n" +
               "This weirdo is giving you a weird vibe. \n" +
               "Too bad, they're the actual Grim Reaper.  \n" +

               "And now you're soul is doomed \n \n" +
               
               "Press L to continue";
        if (Input.GetKeyDown(KeyCode.L)) { currentState = States.lose; }
    }

    private void Win()
    {
        titleObject.text = "You Win!";
        textObject.text = "Congratualtions! /n" +
            "You have beat Death \n \n" +


            "Press C to Play again";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.room; }

    }
    private void Lose()
    {
        titleObject.text = "You Lose.";
        textObject.text = "You Died but then again can Ghosts even die? \n \n" +
=======
        titleObject.text = "You Lose.";
        textObject.text = "You Died but then again can Ghosts even die?/n" +
>>>>>>> Stashed changes


            "Press C to Play again";
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.room; }


    }




}
