using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class PartnersMainSceneBackgroundAFade : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Object to Fade
	public Image BackgroundImageA;
	
// --------------- PRIVATE VARIABLES ---------------
	// Fade Timer
	private float BackgroundImageATimer = 0.0f;
	
	// Runtime Timer
	private float TimerTime;
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Disable Object
	public PartnersMainSceneEnable DisableBackgroundImageARun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		BackgroundImageA = GetComponent<Image>();
		TimerTime = 0.0f;
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		TimerTime += Time.deltaTime * 1.0f;

		// Start Fading Background Image Dummy A
		if (TimerTime >= BackgroundImageATimer) {
			StartCoroutine(BackgroundImageAFade(0.0f, 1.25f));
		}
		
		// Ending Fading
		if (TimerTime >= 1.26f) {
			TimerTime = 1.26f;
			DisableBackgroundImageARun.DisableBackgroundImageA();
		}
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- FADING FUNCTIONS ---------------
	public IEnumerator BackgroundImageAFade(float aValue, float aTime) {
		float alpha = BackgroundImageA.color.a;
		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime) {
			Color BackgroundImageAColor = new Color(1, 1, 1, Mathf.Lerp(alpha, aValue, t));
			BackgroundImageA.color = BackgroundImageAColor;
			yield return null;
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}