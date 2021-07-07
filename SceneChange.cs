using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class SceneChange : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	// List of Scenes
    // Main Scenes / Section 0  ------------------------------------------------------------
    public static string OpeningScene00 = "00MainStartingScene";
    public static string OpeningScene01 = "01MainMenuScene";
		
	// Gallery & Learn & Search Scenes / Section 1 ------------------------------------------------------------
	public static string GLSScene10 = "10GalleryMainScene";
    public static string GLSScene11 = "11PartnersMainScene";
	public static string GLSScene13 = "13GalleryInfoScene";
	public static string GLSScene14 = "14ArtworkInfoScene";

    // Specific Artwork AR Scenes / Section Cat ------------------------------------------------------------
	public static string Cat4PaintingsScene = "Cat4PaintingsScene";
	
	// Settings & Contact Scenes / Section AZ ------------------------------------------------------------
	public static string SettingsSceneAZ01 = "AZ01SettingsScene";
    public static string SettingsSceneAZ02 = "AZ02ContactUsScene";
	public static string SettingsSceneAZ03 = "AZ03WarningScene";
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- MAIN SCENES LOADING FUNCTIONS / SECTION 0 ---------------
	// Load OpeningScene00 - Starting Scene
	public void OpeningScene00Load() {
		SceneManager.LoadScene(OpeningScene00);
	}
    
    // Load OpeningScene01 - Menu Scene
	public void OpeningScene01Load() {
		SceneManager.LoadScene(OpeningScene01);
	}
    
// --------------- GALLERY & LEARN & SEARCH SCENES LOADING FUNCTIONS / SECTION 1 ---------------
	// Load GLSScene10 - Gallery Main Scene
	public void GLSScene10Load() {
		SceneManager.LoadScene(GLSScene10);
	}
    
    // Load GLSScene11 - Partner Main Scene
	public void GLSScene11Load() {
		SceneManager.LoadScene(GLSScene11);
	}

	// Load GLSScene13 - Gallery Info Scene
	public void GLSScene13Load() {
		SceneManager.LoadScene(GLSScene13);
	}

	// Load GLSScene14 - Artwork Info Scene
	public void GLSScene14Load() {
		SceneManager.LoadScene(GLSScene14);
	}
    
// --------------- SPECIFIC ARTWORK SCENES LOADING FUNCTIONS / SECTION CATar ---------------
	// Load Cat4PaintingsScene - Cat 4 Paintings Scene
	public void Cat4PaintingsSceneLoad() {
		SceneManager.LoadScene(Cat4PaintingsScene);
	}
    
// --------------- SETTINGS & CONTACT SCENES LOADING FUNCTIONS / SECTION AZ ---------------
	// Load SettingsSceneAZ01 - Settings Scene
	public void SettingsSceneAZ01Load() {
		SceneManager.LoadScene(SettingsSceneAZ01);
	}
    
    // Load SettingsSceneAZ02 - Contact Us Scene
	public void SettingsSceneAZ02Load() {
		SceneManager.LoadScene(SettingsSceneAZ02);
	}

	// Load SettingsSceneAZ03 - Warning Scene
	public void SettingsSceneAZ03Load() {
		SceneManager.LoadScene(SettingsSceneAZ03);
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}