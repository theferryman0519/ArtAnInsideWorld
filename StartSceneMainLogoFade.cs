using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class StartSceneMainLogoFade : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Object to Fade
	public Image MainLogo;
	
// --------------- PRIVATE VARIABLES ---------------
	// Fade Timer
	private float MainLogoTimer = 0.0f;
	
	// Runtime Timer
	private float TimerTime;
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Disable Object
	public StartSceneEnable DisableMainLogoRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		MainLogo = GetComponent<Image>();
		TimerTime = 0.0f;
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		if (StartSceneButtons.WelcomeButtonInt == 0) {
            
        }
        
        if (StartSceneButtons.WelcomeButtonInt == 1) {
            TimerTime += Time.deltaTime * 1.0f;

            // Start Fading Background Image Dummy A
            if (TimerTime >= MainLogoTimer) {
                StartCoroutine(MainLogoFade(0.0f, 3.0f));
            }

            // Ending Fading
            if (TimerTime >= 6.1f) {
                TimerTime = 6.1f;
                DisableMainLogoRun.DisableMainLogo();
            }
        }
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- FADING FUNCTIONS ---------------
	public IEnumerator MainLogoFade(float aValue, float aTime) {
		float alpha = MainLogo.color.a;
		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime) {
			Color MainLogoColor = new Color(1, 1, 1, Mathf.Lerp(alpha, aValue, t));
			MainLogo.color = MainLogoColor;
			yield return null;
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}