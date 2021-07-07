using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class StartSceneStudioLogoFade : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Object to Fade
	public Image StudioLogo;
	
// --------------- PRIVATE VARIABLES ---------------
	// Fade Timer
	private float StudioLogoTimer = 6.0f;
	
	// Runtime Timer
	private float TimerTime;
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Disable Object
	public StartSceneEnable DisableStudioLogoRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		StudioLogo = GetComponent<Image>();
		TimerTime = 0.0f;
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		TimerTime += Time.deltaTime * 1.0f;

		// Start Fading Background Image Dummy A
		if (TimerTime >= StudioLogoTimer) {
			StartCoroutine(StudioLogoFade(0.0f, 3.0f));
		}
		
		// Ending Fading
		if (TimerTime >= 12.1f) {
			TimerTime = 12.1f;
			DisableStudioLogoRun.DisableStudioLogo();
		}
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- FADING FUNCTIONS ---------------
	public IEnumerator StudioLogoFade(float aValue, float aTime) {
		float alpha = StudioLogo.color.a;
		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime) {
			Color StudioLogoColor = new Color(1, 1, 1, Mathf.Lerp(alpha, aValue, t));
			StudioLogo.color = StudioLogoColor;
			yield return null;
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}