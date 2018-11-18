using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
	public void LoadLevel() {
		Application.LoadLevel ("GamePlay");
	}
	public void QuitGame() {
		Application.Quit ();
	}
	public void LoadMenuGame() {
		Application.LoadLevel ("Start Menu");
	}
	public void LoadEndGame() {
		Application.LoadLevel ("EndGame");
	}
}
