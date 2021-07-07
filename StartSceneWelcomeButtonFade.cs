using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class StartSceneWelcomeButtonFade : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Object to Fade
	public Image WelcomeButton;
	
// --------------- PRIVATE VARIABLES ---------------
	// Fade Timer
	private float WelcomeButtonTimer = 0.0f;
	
	// Runtime Timer
	private float TimerTime;
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Disable Object
	public StartSceneEnable DisableWelcomeButtonRun;
    
    // Scene Change
    public SceneChange SettingsSceneAZ03LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		WelcomeButton = GetComponent<Image>();
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
            if (TimerTime >= WelcomeButtonTimer) {
                StartCoroutine(WelcomeButtonFade(0.0f, 3.0f));
            }

            // Ending Fading
            if (TimerTime >= 3.1f) {
                TimerTime = 3.1f;
                DisableWelcomeButtonRun.DisableWelcomeButton();
                SettingsSceneAZ03LoadRun.SettingsSceneAZ03Load();
            }
        }
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- FADING FUNCTIONS ---------------
	public IEnumerator WelcomeButtonFade(float aValue, float aTime) {
		float alpha = WelcomeButton.color.a;
		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime) {
			Color WelcomeButtonColor = new Color(1, 1, 1, Mathf.Lerp(alpha, aValue, t));
			WelcomeButton.color = WelcomeButtonColor;
			yield return null;
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}