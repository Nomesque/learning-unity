using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	int spacecounter;
	private enum States{Game, Computer, Basement, Bottom_of_stairs, Landing, Top_of_stairs, Back_hallway, Loungeroom, Bathroom, Bedroom, Front_hallway, Front_yard, Footpath };
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.Basement;
		text.text = "Welcome! This very simple text-based adventure gives you an opportunity to " +
					"test some of your assumptions and understandings around sex, consent, sexual " +
					"assault, and rape.\n\n" +
					"Trigger warning: As you might expect, some of this content could be very " +
					"upsetting to those who've experienced sexual assault.\n\n" +
					"Press SPACE to continue.";
		spacecounter = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.Space)) {
			NextPage();
		}
		if (Input.GetKeyDown(KeyCode.T)) {
			TouchPerson();
		}
	
	}
	
	void state_basement() {
		text.text = "You are in a large room. It is lit by two large computer monitors, currently " +
					"displaying a desktop background of a naked Lieutenant Uhura. It smells musty, " +
					"as though ten thousand dirty socks ate a lot of pizza and died many, many years " +
					"ago. A small grimy window, high on the wall, lets in the sound of traffic and the " +
					"sight of many tramping feet. The walls are painted black. Do you want to leave this " +
					"basement? \n\n" +
					"Press L to leave.\n\n" +
					"Press C to check which games are installed on the computer.";
		if (Input.GetKeyDown(KeyCode.L) {
			myState = States.Bottom_of_stairs;
			text.text = "Hey, brave move! But you have a challenge to face before you can get out.\n\n" +
						"A flash of light dazzles you, then fades away. When your eyes clear, you " +
						"can see a large, dark form on your couch. It might be... someone lying there? " +
						"You creep closer to figure out what it is, and as you do so, you move from between " +
						"the shape and a monitor, letting light flood over it. It groans and moves. It's " +
						"human! And... female? The person starts to sit up, then flops back into a prone " +
						"position.\n\n" +
						"'I'm so drunk,' she says. 'I can't even sit up. Wow, I've never been this drunk.' " +
						"She starts to snore quietly.\n\n" +
						"Press C to get her comfortable and make sure she won't choke if she throws up.\n\n" +
						"Press T to take off the blanket and touch her.\n\n";
		}
		else if (Input.GetKeyDown(KeyCode.C) {
			myState = States.Computer;
			text.text = "You click on the Windows icon and look at the Start menu. You don't see any games " +
						"or brand names from game makers. Huh. You look for Steam or Origin - zilch. Blizzard? " +
						"Nothing. It's as though someone set up this computer purely for work or trolling the " +
						"internet. Even the standard Microsoft games are absent. You shake your head disbelievingly. " +
						"An icon on the desktop catches your eye: a Z filled in with bricks, sort of like the old " +
						"Zork logo, but subtly different. Could it be a Zork clone game? Well, text games are " +
						"pretty dorky, but any port in a storm, right?\n\n" +
						"Press P to double-click on the Z icon.\n\n" +
						"Press L to leave the computer and go outside.";
		}
	}
	
	void NextPage() {
		if (myState == States.Basement) {
			
		}
		spacecounter = spacecounter + 1;
		if (spacecounter == 2) {
			text.text = "First challenge: Seeing vs Consent";
			}
		else if (spacecounter == 3) {
			text.text = "A woman standing near you takes hold of her top " +
						"and pulls it off over her head. She's not wearing a bra. " +
						"Her breasts are clearly visible to everyone in the room.\n\n " +
						"Press T to touch her breasts, M to talk to her, or SPACE " +
						"to do nothing.";
			}
		
	}
	
	void TouchPerson() {
		if (spacecounter == 3) {
			text.text = "DAHHHH DUMMMM!!!!!\n\n" +
						"Making skin visible does not give you permission to touch it.";
		}
	}
}
