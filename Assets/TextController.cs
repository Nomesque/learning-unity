using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	int spacecounter;
	
	// Use this for initialization
	void Start () {
		text.text = "Don't worry, we'll start off nice and slow.";
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
	
	void NextPage() {
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
