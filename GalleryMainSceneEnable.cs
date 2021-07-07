using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class GalleryMainSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    public Image BackgroundImageB;
    public Text TitleText;
    public Text CommandText;
    public Image FullGalleryImage;
    public Image GalleryCat1Select;
    public Image GalleryCat2Select;
    public Image GalleryCat3Select;
    public Image GalleryCat4Select;
    public Image GalleryCat5Select;
    public Image FullGalleryImageOverlay;
    public Text GalleryNameText;
    public Image EnterCertainGalleryButton;
    public Image BackButtonGallery;
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
        EnableFullGalleryImage();
        EnableGalleryCat1Select();
        EnableGalleryCat2Select();
        EnableGalleryCat3Select();
        EnableGalleryCat4Select();
        EnableGalleryCat5Select();
        DisableFullGalleryImageOverlay();
        DisableGalleryNameText();
        DisableEnterCertainGalleryButton();
        DisableBackButtonGallery();
        EnableBackButton();
        EnableBackgroundImageA();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		if (GalleryMainSceneButtons.GalleryMainShowingInt > 0) {
            // Disable Selections
            DisableGalleryCat1Select();
            DisableGalleryCat2Select();
            DisableGalleryCat3Select();
            DisableGalleryCat4Select();
            DisableGalleryCat5Select();
            DisableBackButton();

            // Enable Overlay
            EnableFullGalleryImageOverlay();
            EnableGalleryNameText();
            EnableEnterCertainGalleryButton();
            EnableBackButtonGallery();
        }

        if (GalleryMainSceneButtons.GalleryMainShowingInt == 0) {
            // Enable Selections
            EnableGalleryCat1Select();
            EnableGalleryCat2Select();
            EnableGalleryCat3Select();
            EnableGalleryCat4Select();
            EnableGalleryCat5Select();
            EnableBackButton();

            // Disable Overlay
            DisableFullGalleryImageOverlay();
            DisableGalleryNameText();
            DisableEnterCertainGalleryButton();
            DisableBackButtonGallery();
        }

        GalleryNameChange();
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
    
    public void EnableFullGalleryImage() {
        FullGalleryImage.enabled = true;
    }
    
    public void EnableGalleryCat1Select() {
        GalleryCat1Select.enabled = true;
    }
    
    public void EnableGalleryCat2Select() {
        GalleryCat2Select.enabled = true;
    }
    
    public void EnableGalleryCat3Select() {
        GalleryCat3Select.enabled = true;
    }
    
    public void EnableGalleryCat4Select() {
        GalleryCat4Select.enabled = true;
    }
    
    public void EnableGalleryCat5Select() {
        GalleryCat5Select.enabled = true;
    }
    
    public void EnableFullGalleryImageOverlay() {
        FullGalleryImageOverlay.enabled = true;
    }
    
    public void EnableGalleryNameText() {
        GalleryNameText.enabled = true;
    }
    
    public void EnableEnterCertainGalleryButton() {
        EnterCertainGalleryButton.enabled = true;
    }
    
    public void EnableBackButtonGallery() {
        BackButtonGallery.enabled = true;
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
    
    public void DisableFullGalleryImage() {
        FullGalleryImage.enabled = false;
    }
    
    public void DisableGalleryCat1Select() {
        GalleryCat1Select.enabled = false;
    }
    
    public void DisableGalleryCat2Select() {
        GalleryCat2Select.enabled = false;
    }
    
    public void DisableGalleryCat3Select() {
        GalleryCat3Select.enabled = false;
    }
    
    public void DisableGalleryCat4Select() {
        GalleryCat4Select.enabled = false;
    }
    
    public void DisableGalleryCat5Select() {
        GalleryCat5Select.enabled = false;
    }
    
    public void DisableFullGalleryImageOverlay() {
        FullGalleryImageOverlay.enabled = false;
    }
    
    public void DisableGalleryNameText() {
        GalleryNameText.enabled = false;
    }
    
    public void DisableEnterCertainGalleryButton() {
        EnterCertainGalleryButton.enabled = false;
    }
    
    public void DisableBackButtonGallery() {
        BackButtonGallery.enabled = false;
    }

    public void DisableBackButton() {
        BackButton.enabled = false;
    }
    
    public void DisableBackgroundImageA() {
        BackgroundImageA.enabled = false;
    }

// --------------- CHANGE TEXT FUNCTIONS ---------------
    public void GalleryNameChange() {
        if (GalleryMainSceneButtons.GalleryMainShowingInt == 0) {
            GalleryNameText.text = "";
        }

        if (GalleryMainSceneButtons.GalleryMainShowingInt == 1) {
            GalleryNameText.text = "Art of Britain & America";
        }

        if (GalleryMainSceneButtons.GalleryMainShowingInt == 2) {
            GalleryNameText.text = "Art of the Italian Peninsula";
        }

        if (GalleryMainSceneButtons.GalleryMainShowingInt == 3) {
            GalleryNameText.text = "Art of the East";
        }

        if (GalleryMainSceneButtons.GalleryMainShowingInt == 4) {
            GalleryNameText.text = "Art of the Netherlands";
        }

        if (GalleryMainSceneButtons.GalleryMainShowingInt == 5) {
            GalleryNameText.text = "Art of the Rest of the World";
        }
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}