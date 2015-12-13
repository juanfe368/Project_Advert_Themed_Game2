using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
	public int score = 0;					// The player's score.


	private PlayerControl playerControl;	// Reference to the player control script.
	private MovePlayer movePlayer;
	private int previousScore = 0;			// The score in the previous frame.


	void Awake ()
	{
		// Setting up the reference.
		playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
		movePlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<MovePlayer>();
	}


	void Update ()
	{
		// Set the score text.
		GetComponent<GUIText> ().text = "Score: " + score;

		// If the score has changed...
		if(previousScore != score){ 
			// ... play a taunt.

			if (playerControl != null) {
				playerControl.StartCoroutine(playerControl.Taunt());
			}
			if (movePlayer != null) {
				movePlayer.StartCoroutine(movePlayer.Taunt());
			}
		    // Set the previous score to this frame's score.
			previousScore = score;		
		}

	}
}
