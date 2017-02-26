using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	
	int max;
	int min;
	int guess;
	
	void Start () {
		StartGame();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
				
		print("====================================");
		print("Willkommen zu Number Wizard!");
		print("Denk dir eine Zahl, aber sage sie nicht!");
		print("Die höchste Zahl, die du wählen kannst ist " + max);
		print("Die niedrigste Zahl, die du wählen kannst ist " + min);
		print("Ist die Zahl größer oder niedriger als " + guess);
		print("Drücke die Pfeiltaste oben für höher, Pfeiltaste unten für niedriger und Enter für gleich.");
		
		max = max + 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			// print("Pfeiltaste Hoch wurde gedrückt");
			min = guess;
			NextGuess();
			} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			// print("Pfeiltaste Runter wurde gedrückt");
			max = guess;
			NextGuess();
			} else if (Input.GetKeyDown(KeyCode.KeypadEnter)) {
			print("ICH HABE GEWONNEN!");
			StartGame();
		}
	}
		
	void NextGuess () {
		guess = (min + max) / 2;
		print("Höher oder niedriger als " + guess);
		print("Drücke die Pfeiltaste oben für höher, Pfeiltaste unten für niedriger und Enter für gleich.");
	}
}
