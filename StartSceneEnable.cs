using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class StartSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image BackgroundImageC;
    public Image WelcomeButton;
    public Image MainLogo;
    public Image BackgroundImageB;
    public Image StudioLogo;
    public Image BackgroundImageA;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		EnableBackgroundImageC();
        EnableWelcomeButton();
        EnableMainLogo();
        EnableBackgroundImageB();
        EnableStudioLogo();
        EnableBackgroundImageA();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE OBJECTS FUNCTIONS ---------------
    public void EnableBackgroundImageC() {
        BackgroundImageC.enabled = true;
    }
    
    public void EnableWelcomeButton() {
        WelcomeButton.enabled = true;
    }
    
    public void EnableMainLogo() {
        MainLogo.enabled = true;
    }
    
    public void EnableBackgroundImageB() {
        BackgroundImageB.enabled = true;
    }
    
    public void EnableStudioLogo() {
        StudioLogo.enabled = true;
    }
    
    public void EnableBackgroundImageA() {
        BackgroundImageA.enabled = true;
    }
    
// --------------- DISABLE OBJECTS FUNCTIONS ---------------
    public void DisableBackgroundImageC() {
        BackgroundImageC.enabled = false;
    }
    
    public void DisableWelcomeButton() {
        WelcomeButton.enabled = false;
    }
    
    public void DisableMainLogo() {
        MainLogo.enabled = false;
    }
    
    public void DisableBackgroundImageB() {
        BackgroundImageB.enabled = false;
    }
    
    public void DisableStudioLogo() {
        StudioLogo.enabled = false;
    }
    
    public void DisableBackgroundImageA() {
        BackgroundImageA.enabled = false;
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}