using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class MainMenuSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    public Image BackgroundImageB;
    public Image TextLogo;
    public Text VersionText;
    public Image SettingsButton;
    public Image ContactUsButton;
    public Image MainGalleryButton;
    public Image PartnerGalleriesButton;
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
        EnableBackgroundImageB();
        EnableTextLogo();
        EnableVersionText();
        EnableSettingsButton();
        EnableContactUsButton();
        EnableMainGalleryButton();
        EnablePartnerGalleriesButton();
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
    public void EnableBackgroundImageB() {
        BackgroundImageB.enabled = true;
    }
    
    public void EnableTextLogo() {
        TextLogo.enabled = true;
    }

    public void EnableVersionText() {
        VersionText.enabled = true;
    }
    
    public void EnableSettingsButton() {
        SettingsButton.enabled = true;
    }
    
    public void EnableContactUsButton() {
        ContactUsButton.enabled = true;
    }
    
    public void EnableMainGalleryButton() {
        MainGalleryButton.enabled = true;
    }
    
    public void EnablePartnerGalleriesButton() {
        PartnerGalleriesButton.enabled = true;
    }
    
    public void EnableBackgroundImageA() {
        BackgroundImageA.enabled = true;
    }
    
// --------------- DISABLE OBJECTS FUNCTIONS ---------------
    public void DisableBackgroundImageB() {
        BackgroundImageB.enabled = false;
    }
    
    public void DisableTextLogo() {
        TextLogo.enabled = false;
    }

    public void DisableVersionText() {
        VersionText.enabled = false;
    }
    
    public void DisableSettingsButton() {
        SettingsButton.enabled = false;
    }
    
    public void DisableContactUsButton() {
        ContactUsButton.enabled = false;
    }
    
    public void DisableMainGalleryButton() {
        MainGalleryButton.enabled = false;
    }
    
    public void DisablePartnerGalleriesButton() {
        PartnerGalleriesButton.enabled = false;
    }
    
    public void DisableBackgroundImageA() {
        BackgroundImageA.enabled = false;
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}