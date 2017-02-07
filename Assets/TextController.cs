using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	private enum States{Wrong_answer1, Wrong_answer2, Wrong_answer3, Welcome, Game_start, Computer, Basement, Bottom_of_stairs, Landing, Back_hallway, Loungeroom, Bathroom, Bedroom, Front_hallway, Front_yard, Footpath };
	private States myState;
	// Not using this CookieCount variable yet; I haven't figured out how to add an extra text box to the canvas.
	public int CookieCount;
	
	// Use this for initialization
	void Start () {
		myState = States.Welcome;
		CookieCount = 0;
		}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.Welcome) {
			state_welcome();
		}
		if (myState == States.Basement) {
			state_basement();
		}
		if (myState == States.Bottom_of_stairs) {
			state_bottomofstairs();
		}
		if (myState == States.Computer) {
			state_computer();
		}
		if (myState == States.Game_start) {
			state_game_start();
		}
		if (myState == States.Landing) {
			state_landing();
		}
		if (myState == States.Wrong_answer1) {
			state_wronganswer1();
		}
		if (myState == States.Back_hallway) {
			state_back_hallway();
		}
		if (myState == States.Wrong_answer2) {
			state_wronganswer2();
		}
	}
	
	void state_welcome() {
		text.text = "Welcome! This very simple text-based adventure gives you an opportunity to " +
					"test some of your assumptions and understandings around sex, consent, sexual " +
					"assault, and rape.\n\n" +
					"Trigger warning: As you might expect, some of this content could be very " +
					"upsetting to those who've experienced sexual assault.\n\n" +
					"Press SPACE to continue.";
		
		// Change place to initial basement state if user presses the SPACE key.
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.Basement;
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
					
		// Change place to the bottom of the stairs if user presses L
		if (Input.GetKeyDown(KeyCode.L)) {
				myState = States.Bottom_of_stairs;
		}
		// Change place to the computer if user presses C
		if (Input.GetKeyDown(KeyCode.C)) {
				myState = States.Computer;
		}
	}
	
	void state_bottomofstairs() {
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
					
		// Change place to the landing if user presses C
		if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.Landing;
		}
		
		// Explain the issue with lack of consent if user presses T
		if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.Wrong_answer1;
		}
	}
	void state_wronganswer1() {
		text.text = "DAH DUMMMMMMM\n\n" +
					"You screwed up. There's no consent involved if all parties involved aren't fully conscious " +
					"and aware of the full proceedings. At best, this is sexual assault - at worst, rape. Don't " +
					"be an arsehole: don't have sex with people who are unconscious or asleep.\n\n" +
					"Press the SPACE key to go back to the basement.";
		//Send the player back to the basement
		if (Input.GetKeyDown(KeyCode.Space)){
			myState = States.Basement;
		}
	}
	
	void state_computer() {
		text.text = "You click on the Windows icon and look at the Start menu. You don't see any games " +
					"or brand names from game makers. Huh. You look for Steam or Origin - zilch. Blizzard? " +
					"Nothing. It's as though someone set up this computer purely for work or trolling the " +
					"internet. Even the standard Microsoft games are absent. You shake your head disbelievingly. " +
					"An icon on the desktop catches your eye: a B filled in with bricks, sort of like the old " +
					"Zork logo, but subtly different. Could it be a Zork clone game? Well, text games are " +
					"pretty dorky, but any port in a storm, right?\n\n" +
					"Press P to double-click on the Z icon.\n\n" +
					"Press L to leave the computer and go outside.";
		// Change place to the bottom of the stairs if user presses L
		if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.Game_start;
		}
		// Change place to the computer if user presses C
		if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.Basement;
		}
	}
	
	void state_game_start() {
		text.text = "The screen to your right goes blank, then displays a large black window with " +
					"an ascii outline of one large word:\n\n" +
					" =====\\\\    //====\\\\    ====\\\\    | |    // \n" +
  					"| |    \\\\  //     \\\\   | |   \\\\   | |   // \n" +
  					"| |    // ||       ||  | |   ||   | |  // \n" +
  					"| |===<<  ||       ||  | |==<<    | |<< \n" +
  					"| |    \\\\ ||       ||  | |   \\\\   | |  \\\\ \n" +
  					"| |    //  \\\\     //   | |    \\\\  | |   \\\\ \n" +
  					" =====//    \\\\===//    | |     || | |    \\\\ \n";
  	}
  					
  					
	void state_landing() {
		CookieCount = CookieCount + 1;
		text.text = "You surmounted the first challenge, and avoided sexually assaulting someone. " +
					"Congratulations! Have a cookie.\n\n" +
					"You walk up the stairs, but pause on the landing. In front of you is a man, " +
					"pants around his ankles, mooning you.\n\n" +
					"Press T to fondle his butt cheeks.\n" +
					"Press L to shake your head in confusion and leave the scene.";
		// Change state to a 'wrong answer' message if user presses T
		if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.Wrong_answer2;
		}
		
		// Change place to the top of the stairs if user presses L
		if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.Back_hallway;
		}
	}		
	
	void state_wronganswer2 () {
		text.text = "DAHHHH DUMMMMMMM.\n\n" +
					"Voluntary display of skin - even skin of sexually-loaded body parts like buttocks, chest, " +
					"or genitals - does not equal consent to being touched on those body parts. Seeing /= permission. \n\n" +
					"Press SPACE to go back to the basement.";
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.Basement;
		}
	}
	
	void state_back_hallway() {
		CookieCount = CookieCount + 1;
		text.text = "Congratulations! Another sexual assault adroitly avoided. " +
					"Have another cookie!\n\n" +
					"You continue walking up the stairs, open the door at the top, and walk " +
					"out into the hallway. You can hear music thumping out in the back yard. " +
					"A group of teenage boys walk past, graciouslessly staggering around you when " +
					"you fail to get out of their way. The smell of cheap beer follows them in a " +
					"wave of scent. Looks like your little sister is holding an illicit party while " +
					"the folks are away.\n\n" +
					"A teenage girl walks out of the kitchen towards you, then her eyes brighten. " +
					"'Hey!' she says, bouncing over to you. She puts her arms around your neck and " +
					"kisses you, her tongue sliding over your lips.\n\n" +
					"Press T to take her up to your room.\n" +
					"Press L to head out to the lounge room.\n";
		if (Input.GetKeyDown(KeyCode.T)) {
			//need to create this function
			myState = States.Wrong_answer3;
		}
		
		// Change place to the top of the stairs if user presses L
		if (Input.GetKeyDown(KeyCode.L)) {
			// need to create this function
			myState = States.Loungeroom;
		}
	}
  					
  					
  					
}
