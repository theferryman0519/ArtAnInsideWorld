using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class ArtworkInfoSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    public Image BackgroundImageB;
    public Text TitleText;
    public Text ArtistText;
    public Text DateText;
    public Text MovementText;
    public Text OriginationText;
    public Text MuseumText;
    public Image BackButton;
    public Image BackgroundImageC;
    public Image EnlargedArtwork;
    public Image EnlargedBackButton;
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
        EnableTitleText();
        EnableArtistText();
        EnableDateText();
        EnableMovementText();
        EnableOriginationText();
        EnableMuseumText();
        EnableBackButton();
        DisableBackgroundImageC();
        DisableEnlargedArtwork();
        DisableEnlargedBackButton();
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

    public void EnableTitleText() {
        TitleText.enabled = true;
    }

    public void EnableArtistText() {
        ArtistText.enabled = true;
    }

    public void EnableDateText() {
        DateText.enabled = true;
    }

    public void EnableMovementText() {
        MovementText.enabled = true;
    }

    public void EnableOriginationText() {
        OriginationText.enabled = true;
    }

    public void EnableMuseumText() {
        MuseumText.enabled = true;
    }

    public void EnableBackButton() {
        BackButton.enabled = true;
    }

    public void EnableBackgroundImageC() {
        BackgroundImageC.enabled = true;
    }

    public void EnableEnlargedArtwork() {
        EnlargedArtwork.enabled = true;
    }

    public void EnableEnlargedBackButton() {
        EnlargedBackButton.enabled = true;
    }
    
    public void EnableBackgroundImageA() {
        BackgroundImageA.enabled = true;
    }
    
// --------------- DISABLE OBJECTS FUNCTIONS ---------------
    public void DisableBackgroundImageB() {
        BackgroundImageB.enabled = false;
    }

    public void DisableTitleText() {
        TitleText.enabled = false;
    }
    
    public void DisableArtistText() {
        ArtistText.enabled = false;
    }

    public void DisableDateText() {
        DateText.enabled = false;
    }

    public void DisableMovementText() {
        MovementText.enabled = false;
    }

    public void DisableOriginationText() {
        OriginationText.enabled = false;
    }

    public void DisableMuseumText() {
        MuseumText.enabled = false;
    }

    public void DisableBackButton() {
        BackButton.enabled = false;
    }

    public void DisableBackgroundImageC() {
        BackgroundImageC.enabled = false;
    }

    public void DisableEnlargedArtwork() {
        EnlargedArtwork.enabled = false;
    }

    public void DisableEnlargedBackButton() {
        EnlargedBackButton.enabled = false;
    }
    
    public void DisableBackgroundImageA() {
        BackgroundImageA.enabled = false;
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}