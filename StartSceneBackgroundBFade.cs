using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class StartSceneBackgroundBFade : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Object to Fade
	public Image BackgroundImageB;
	
// --------------- PRIVATE VARIABLES ---------------
	// Fade Timer
	private float BackgroundImageBTimer = 9.0f;
	
	// Runtime Timer
	private float TimerTime;
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Disable Object
	public StartSceneEnable DisableBackgroundImageBRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		BackgroundImageB = GetComponent<Image>();
		TimerTime = 0.0f;
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		TimerTime += Time.deltaTime * 1.0f;

		// Start Fading Background Image Dummy A
		if (TimerTime >= BackgroundImageBTimer) {
			StartCoroutine(BackgroundImageBFade(0.0f, 3.0f));
		}
		
		// Ending Fading
		if (TimerTime >= 12.1f) {
			TimerTime = 12.1f;
			DisableBackgroundImageBRun.DisableBackgroundImageB();
		}
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- FADING FUNCTIONS ---------------
	public IEnumerator BackgroundImageBFade(float aValue, float aTime) {
		float alpha = BackgroundImageB.color.a;
		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime) {
			Color BackgroundImageBColor = new Color(1, 1, 1, Mathf.Lerp(alpha, aValue, t));
			BackgroundImageB.color = BackgroundImageBColor;
			yield return null;
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}