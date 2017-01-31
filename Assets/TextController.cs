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
	
	}
	
	void NextPage() {
		if (spacecounter == 1) {
			text.text = "First challenge: Seeing vs Consent";
			}
		else if (spacecounter == 2) {
			text.text = "A woman standing near you takes hold of her top " +
						"and pulls it off over her head. She's not wearing a bra. " +
						"Her breasts are clearly visible to everyone in the room.\n " +
						"Press T to touch her breasts, M to talk to her, or SPACE " +
						"to do nothing.";
			}
		spacecounter = spacecounter + 1;
	}
}
