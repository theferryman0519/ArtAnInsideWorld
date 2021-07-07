using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class Cat4ARSceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button TutorialTextButton;
	public Button TutorialCloseButton;
	public Button ArtworkCloseButton;
    public Button VoiceOnButton;
	public Button VoiceOffButton;
	public Button TextOnButton;
	public Button TextOffButton;
	public Button OrbsOnButton;
	public Button OrbsOffButton;
	public Button BackButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Changing
    public SceneChange GLSScene14Loading;

	// Enable & Disable
	public Cat4ARSceneEnable EnableTutorialFeatureShow;
	public Cat4ARSceneEnable DisableTutorialFeatureHide;
	public Cat4ARSceneEnable DisableArtworkFeatureHide;

	public Cat4ARSceneEnable EnableVoiceOnButtonShow;
	public Cat4ARSceneEnable EnableVoiceOffButtonShow;
	public Cat4ARSceneEnable EnableTextOnButtonShow;
	public Cat4ARSceneEnable EnableTextOffButtonShow;
	public Cat4ARSceneEnable EnableOrbsOnButtonShow;
	public Cat4ARSceneEnable EnableOrbsOffButtonShow;

	public Cat4ARSceneEnable DisableVoiceOnButtonHide;
	public Cat4ARSceneEnable DisableVoiceOffButtonHide;
	public Cat4ARSceneEnable DisableTextOnButtonHide;
	public Cat4ARSceneEnable DisableTextOffButtonHide;
	public Cat4ARSceneEnable DisableOrbsOnButtonHide;
	public Cat4ARSceneEnable DisableOrbsOffButtonHide;

	public Cat4ARSceneEnable DisableAllArtworkOrbsHide;
	public Cat4ARSceneEnable EnableArtwork01OrbsShow;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
        // Tutorial Text Button
		Button TutorialTextButtonClick = TutorialTextButton.GetComponent<Button>();
		TutorialTextButtonClick.onClick.AddListener(TutorialTextButtonClicking);

		// Tutorial Close Button
		Button TutorialCloseButtonClick = TutorialCloseButton.GetComponent<Button>();
		TutorialCloseButtonClick.onClick.AddListener(TutorialCloseButtonClicking);

		// Artwork Close Button
		Button ArtworkCloseButtonClick = ArtworkCloseButton.GetComponent<Button>();
		ArtworkCloseButtonClick.onClick.AddListener(ArtworkCloseButtonClicking);

		// Voice On Button
		Button VoiceOnButtonClick = VoiceOnButton.GetComponent<Button>();
		VoiceOnButtonClick.onClick.AddListener(VoiceOnButtonClicking);

		// Voice Off Button
		Button VoiceOffButtonClick = VoiceOffButton.GetComponent<Button>();
		VoiceOffButtonClick.onClick.AddListener(VoiceOffButtonClicking);

		// Text On Button
		Button TextOnButtonClick = TextOnButton.GetComponent<Button>();
		TextOnButtonClick.onClick.AddListener(TextOnButtonClicking);

		// Text Off Button
		Button TextOffButtonClick = TextOffButton.GetComponent<Button>();
		TextOffButtonClick.onClick.AddListener(TextOffButtonClicking);

		// Orbs On Button
		Button OrbsOnButtonClick = OrbsOnButton.GetComponent<Button>();
		OrbsOnButtonClick.onClick.AddListener(OrbsOnButtonClicking);

		// Orbs Off Button
		Button OrbsOffButtonClick = OrbsOffButton.GetComponent<Button>();
		OrbsOffButtonClick.onClick.AddListener(OrbsOffButtonClicking);

		// Back Button
		Button BackButtonClick = BackButton.GetComponent<Button>();
		BackButtonClick.onClick.AddListener(BackButtonClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
	public void TutorialTextButtonClicking() {
		EnableTutorialFeatureShow.EnableTutorialFeature();
	}

	public void TutorialCloseButtonClicking() {
		DisableTutorialFeatureHide.DisableTutorialFeature();
	}

	public void ArtworkCloseButtonClicking() {
		DisableArtworkFeatureHide.DisableArtworkFeature();
	}

    public void VoiceOnButtonClicking() {
		EnableVoiceOffButtonShow.EnableVoiceOffButton();
		DisableVoiceOnButtonHide.DisableVoiceOnButton();
		// Turn On Sound
	}

	public void VoiceOffButtonClicking() {
		EnableVoiceOnButtonShow.EnableVoiceOnButton();
		DisableVoiceOffButtonHide.DisableVoiceOffButton();
		// Turn Off Sound
	}

	public void TextOnButtonClicking() {
		EnableTextOffButtonShow.EnableTextOffButton();
		DisableTextOnButtonHide.DisableTextOnButton();
		// Turn On Text
	}

	public void TextOffButtonClicking() {
		EnableTextOnButtonShow.EnableTextOnButton();
		DisableTextOffButtonHide.DisableTextOffButton();
		// Turn Off Text
	}

	public void OrbsOnButtonClicking() {
		EnableOrbsOffButtonShow.EnableOrbsOffButton();
		DisableOrbsOnButtonHide.DisableOrbsOnButton();
		
		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 22) {
			DisableAllArtworkOrbsHide.DisableAllArtworkOrbs();
			EnableArtwork01OrbsShow.EnableArtwork01Orbs();
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 23) {
			DisableAllArtworkOrbsHide.DisableAllArtworkOrbs();
			// Show Orbs
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 24) {
			DisableAllArtworkOrbsHide.DisableAllArtworkOrbs();
			// Show Orbs
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 25) {
			DisableAllArtworkOrbsHide.DisableAllArtworkOrbs();
			// Show Orbs
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 26) {
			DisableAllArtworkOrbsHide.DisableAllArtworkOrbs();
			// Show Orbs
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 27) {
			DisableAllArtworkOrbsHide.DisableAllArtworkOrbs();
			// Show Orbs
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 28) {
			DisableAllArtworkOrbsHide.DisableAllArtworkOrbs();
			// Show Orbs
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 29) {
			DisableAllArtworkOrbsHide.DisableAllArtworkOrbs();
			// Show Orbs
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 30) {
			DisableAllArtworkOrbsHide.DisableAllArtworkOrbs();
			// Show Orbs
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 31) {
			DisableAllArtworkOrbsHide.DisableAllArtworkOrbs();
			// Show Orbs
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 32) {
			DisableAllArtworkOrbsHide.DisableAllArtworkOrbs();
			// Show Orbs
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 33) {
			DisableAllArtworkOrbsHide.DisableAllArtworkOrbs();
			// Show Orbs
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 34) {
			DisableAllArtworkOrbsHide.DisableAllArtworkOrbs();
			// Show Orbs
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 35) {
			DisableAllArtworkOrbsHide.DisableAllArtworkOrbs();
			// Show Orbs
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 36) {
			DisableAllArtworkOrbsHide.DisableAllArtworkOrbs();
			// Show Orbs
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 37) {
			DisableAllArtworkOrbsHide.DisableAllArtworkOrbs();
			// Show Orbs
		}
	}

	public void OrbsOffButtonClicking() {
		EnableOrbsOnButtonShow.EnableOrbsOnButton();
		DisableOrbsOffButtonHide.DisableOrbsOffButton();
		DisableAllArtworkOrbsHide.DisableAllArtworkOrbs();
	}

	public void BackButtonClicking() {
		GLSScene14Loading.GLSScene14Load();
	}

// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}