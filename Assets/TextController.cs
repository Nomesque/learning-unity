using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	int spacecounter;
	private enum States{Computer, Basement, Bottom_of_stairs, Landing, Top_of_stairs, Back_hallway, Loungeroom, Bathroom, Bedroom, Front_hallway, Front_yard, Footpath };
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
		
		}
		else if (Input.GetKeyDown(KeyCode.C) {
		
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
