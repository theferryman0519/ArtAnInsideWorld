using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class MainMenuSceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button SettingsButton;
    public Button ContactUsButton;
    public Button MainGalleryButton;
    public Button PartnerGalleriesButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Change
    public SceneChange GLSScene10Loading;
    public SceneChange GLSScene11Loading;
    public SceneChange SettingsSceneAZ01Loading;
    public SceneChange SettingsSceneAZ02Loading;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
        // Settings Button
		Button SettingsButtonClick = SettingsButton.GetComponent<Button>();
		SettingsButtonClick.onClick.AddListener(SettingsButtonClicking);
        
        // Contact Us Button
		Button ContactUsButtonClick = ContactUsButton.GetComponent<Button>();
		ContactUsButtonClick.onClick.AddListener(ContactUsButtonClicking);
        
        // Main Gallery Button
		Button MainGalleryButtonClick = MainGalleryButton.GetComponent<Button>();
		MainGalleryButtonClick.onClick.AddListener(MainGalleryButtonClicking);
        
        // Partner Galleries Button
		Button PartnerGalleriesButtonClick = PartnerGalleriesButton.GetComponent<Button>();
		PartnerGalleriesButtonClick.onClick.AddListener(PartnerGalleriesButtonClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    public void SettingsButtonClicking() {
        SettingsSceneAZ01Loading.SettingsSceneAZ01Load();
    }
    
    public void ContactUsButtonClicking() {
        SettingsSceneAZ02Loading.SettingsSceneAZ02Load();
    }
    
    public void MainGalleryButtonClicking() {
        GLSScene10Loading.GLSScene10Load();
    }
    
    public void PartnerGalleriesButtonClicking() {
        GLSScene11Loading.GLSScene11Load();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}