using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;


public class GamePlay : MonoBehaviour {
	int max, min;
	int guess;
	public Text guessText;
	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame() {
		max = 1000;
		min = 0;
		NextGuess ();
		max = max + 1;
	}

	public void GuessHigher() {
		min = guess;
		NextGuess ();
	}

	public void GuessLower() {
		max = guess;
		NextGuess ();
	}

	void NextGuess() {
		guess = Random.Range (min, max);
		guessText.text = guess.ToString ();
	}
}
