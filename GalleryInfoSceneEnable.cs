using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class GalleryInfoSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    public Image BackgroundImageB;
    public Text TitleText;
    public Text CommandText;
    public Image GalleryDescription;
    public Text GalleryDescriptionText;
    public Image ArtworksListCat1;
    public Image ArtworksListCat2;
    public Image ArtworksListCat3;
    public Image ArtworksListCat4;
    public Image ArtworksListCat5;
    public Image ScrollArtworksListCat1;
    public Image ScrollArtworksListCat2;
    public Image ScrollArtworksListCat3;
    public Image ScrollArtworksListCat4;
    public Image ScrollArtworksListCat5;
    public GameObject ContentArtworksListCat1;
    public GameObject ContentArtworksListCat2;
    public GameObject ContentArtworksListCat3;
    public GameObject ContentArtworksListCat4;
    public GameObject ContentArtworksListCat5;
    public Image BackButton;
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
        EnableCommandText();
        EnableGalleryDescription();
        EnableBackButton();
        EnableBackgroundImageA();

        DisableArtworksListCat1();
        DisableArtworksListCat2();
        DisableArtworksListCat3();
        DisableArtworksListCat4();
        DisableArtworksListCat5();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
        GalleryInfoTextChange();
        GalleryArtworkShow();
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
    
    public void EnableCommandText() {
        CommandText.enabled = true;
    }

    public void EnableGalleryDescription() {
        GalleryDescription.enabled = true;
        GalleryDescriptionText.enabled = true;
    }

    public void EnableArtworksListCat1() {
        ArtworksListCat1.enabled = true;
        ScrollArtworksListCat1.enabled = true;
        ContentArtworksListCat1.SetActive(true);
    }

    public void EnableArtworksListCat2() {
        ArtworksListCat2.enabled = true;
        ScrollArtworksListCat2.enabled = true;
        ContentArtworksListCat2.SetActive(true);
    }

    public void EnableArtworksListCat3() {
        ArtworksListCat3.enabled = true;
        ScrollArtworksListCat3.enabled = true;
        ContentArtworksListCat3.SetActive(true);
    }

    public void EnableArtworksListCat4() {
        ArtworksListCat4.enabled = true;
        ScrollArtworksListCat4.enabled = true;
        ContentArtworksListCat4.SetActive(true);
    }

    public void EnableArtworksListCat5() {
        ArtworksListCat5.enabled = true;
        ScrollArtworksListCat5.enabled = true;
        ContentArtworksListCat5.SetActive(true);
    }

    public void EnableBackButton() {
        BackButton.enabled = true;
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
    
    public void DisableCommandText() {
        CommandText.enabled = false;
    }
    
    public void DisableGalleryDescription() {
        GalleryDescription.enabled = false;
        GalleryDescriptionText.enabled = false;
    }

    public void DisableArtworksListCat1() {
        ArtworksListCat1.enabled = false;
        ScrollArtworksListCat1.enabled = false;
        ContentArtworksListCat1.SetActive(false);
    }

    public void DisableArtworksListCat2() {
        ArtworksListCat2.enabled = false;
        ScrollArtworksListCat2.enabled = false;
        ContentArtworksListCat2.SetActive(false);
    }

    public void DisableArtworksListCat3() {
        ArtworksListCat3.enabled = false;
        ScrollArtworksListCat3.enabled = false;
        ContentArtworksListCat3.SetActive(false);
    }

    public void DisableArtworksListCat4() {
        ArtworksListCat4.enabled = false;
        ScrollArtworksListCat4.enabled = false;
        ContentArtworksListCat4.SetActive(false);
    }

    public void DisableArtworksListCat5() {
        ArtworksListCat5.enabled = false;
        ScrollArtworksListCat5.enabled = false;
        ContentArtworksListCat5.SetActive(false);
    }

    public void DisableBackButton() {
        BackButton.enabled = false;
    }
    
    public void DisableBackgroundImageA() {
        BackgroundImageA.enabled = false;
    }

// --------------- CHANGE TEXT FUNCTIONS ---------------
    public void GalleryInfoTextChange() {
        if (GalleryMainSceneButtons.GalleryMainShowingInt == 0) {
            TitleText.text = "";
            CommandText.text = "";
            GalleryDescriptionText.text = "";
        }

        if (GalleryMainSceneButtons.GalleryMainShowingInt == 1) {
            TitleText.text = MainGalleryDatabase.AppGalleryName1;
            CommandText.text = "Welcome to the " + TitleText.text + " Gallery! Feel free to choose a work of art from this gallery in order to view more information and enter its Augmented Reality experience.";
            GalleryDescriptionText.text = MainGalleryDatabase.AppGalleryDescription1;
        }

        if (GalleryMainSceneButtons.GalleryMainShowingInt == 2) {
            TitleText.text = MainGalleryDatabase.AppGalleryName2;
            CommandText.text = "Welcome to the " + TitleText.text + " Gallery! Feel free to choose a work of art from this gallery in order to view more information and enter its Augmented Reality experience.";
            GalleryDescriptionText.text = MainGalleryDatabase.AppGalleryDescription2;
        }

        if (GalleryMainSceneButtons.GalleryMainShowingInt == 3) {
            TitleText.text = MainGalleryDatabase.AppGalleryName3;
            CommandText.text = "Welcome to the " + TitleText.text + " Gallery! Feel free to choose a work of art from this gallery in order to view more information and enter its Augmented Reality experience.";
            GalleryDescriptionText.text = MainGalleryDatabase.AppGalleryDescription3;
        }

        if (GalleryMainSceneButtons.GalleryMainShowingInt == 4) {
            TitleText.text = MainGalleryDatabase.AppGalleryName4;
            CommandText.text = "Welcome to the " + TitleText.text + " Gallery! Feel free to choose a work of art from this gallery in order to view more information and enter its Augmented Reality experience.";
            GalleryDescriptionText.text = MainGalleryDatabase.AppGalleryDescription4;
        }

        if (GalleryMainSceneButtons.GalleryMainShowingInt == 5) {
            TitleText.text = MainGalleryDatabase.AppGalleryName5;
            CommandText.text = "Welcome to the " + TitleText.text + " Gallery! Feel free to choose a work of art from this gallery in order to view more information and enter its Augmented Reality experience.";
            GalleryDescriptionText.text = MainGalleryDatabase.AppGalleryDescription5;
        }
    }

// --------------- SHOW ARTWORK BUTTONS FUNCTIONS ---------------
    public void GalleryArtworkShow() {
        if (GalleryMainSceneButtons.GalleryMainShowingInt == 0) {
            DisableArtworksListCat1();
            DisableArtworksListCat2();
            DisableArtworksListCat3();
            DisableArtworksListCat4();
            DisableArtworksListCat5();
        }

        if (GalleryMainSceneButtons.GalleryMainShowingInt == 1) {
            EnableArtworksListCat1();
            DisableArtworksListCat2();
            DisableArtworksListCat3();
            DisableArtworksListCat4();
            DisableArtworksListCat5();
        }

        if (GalleryMainSceneButtons.GalleryMainShowingInt == 2) {
            DisableArtworksListCat1();
            EnableArtworksListCat2();
            DisableArtworksListCat3();
            DisableArtworksListCat4();
            DisableArtworksListCat5();
        }

        if (GalleryMainSceneButtons.GalleryMainShowingInt == 3) {
            DisableArtworksListCat1();
            DisableArtworksListCat2();
            EnableArtworksListCat3();
            DisableArtworksListCat4();
            DisableArtworksListCat5();
        }

        if (GalleryMainSceneButtons.GalleryMainShowingInt == 4) {
            DisableArtworksListCat1();
            DisableArtworksListCat2();
            DisableArtworksListCat3();
            EnableArtworksListCat4();
            DisableArtworksListCat5();
        }

        if (GalleryMainSceneButtons.GalleryMainShowingInt == 5) {
            DisableArtworksListCat1();
            DisableArtworksListCat2();
            DisableArtworksListCat3();
            DisableArtworksListCat4();
            EnableArtworksListCat5();
        }
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}