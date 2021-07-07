using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class Cat4ARSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    public Image TitleBar;
    public Text TitleText;
    public Text TutorialText;
    public Image TutorialDescription;
    public Image TutorialViewport;
    public Text TutorialDescriptionText;
    public Image TutorialCloseButton;
    public Image ArtworkDescription;
    public Image ArtworkViewport;
    public Text ArtworkDescriptionText;
    public Image ArtworkCloseButton;
    public Image VoiceOnButton;
    public Image VoiceOffButton;
    public Image TextOnButton;
    public Image TextOffButton;
    public Image OrbsOnButton;
    public Image OrbsOffButton;
    public Image BackButton;
    public Image BackgroundImageA;

    public Renderer Ceiling;
    public Renderer Floor;
    public Renderer WallBack;
    public Renderer WallFront;
    public Renderer WallLeft;
    public Renderer WallRight;

    public Renderer Artwork01;
    public Renderer Artwork02;
    public Renderer Artwork03;
    public Renderer Artwork04;
    public Renderer Artwork05;
    public Renderer Artwork06;
    public Renderer Artwork07;
    public Renderer Artwork08;
    public Renderer Artwork09;
    public Renderer Artwork10;
    public Renderer Artwork11;
    public Renderer Artwork12;
    public Renderer Artwork13;
    public Renderer Artwork14;
    public Renderer Artwork15;
    public Renderer Artwork16;

    public Renderer Orbs01Orb1;
    public Renderer Orbs01Orb2;
    public Renderer Orbs01Orb3;
    public Renderer Orbs01Orb4;
    public Renderer Orbs01Orb5;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
        EnableTitleBar();
        EnableTitleText();
        EnableTutorialText();
        DisableTutorialFeature();
        DisableArtworkFeature();
        DisableVoiceOnButton();
        EnableVoiceOffButton();
        DisableTextOnButton();
        EnableTextOffButton();
        DisableOrbsOnButton();
        EnableOrbsOffButton();
        EnableBackButton();
        EnableBackgroundImageA();

        EnableBaseBlenderObjects();

        ShowCat4Artworks();
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
    public void EnableTitleBar() {
        TitleBar.enabled = true;
    }

    public void EnableTitleText() {
        TitleText.enabled = true;
    }

    public void EnableTutorialText() {
        TutorialText.enabled = true;
    }

    public void EnableTutorialFeature() {
        TutorialDescription.enabled = true;
        TutorialDescriptionText.enabled = true;
        TutorialCloseButton.enabled = true;
        TutorialViewport.enabled = true;
    }

    public void EnableArtworkFeature() {
        ArtworkDescription.enabled = true;
        ArtworkDescriptionText.enabled = true;
        ArtworkCloseButton.enabled = true;
        ArtworkViewport.enabled = true;
    }

    public void EnableVoiceOnButton() {
        VoiceOnButton.enabled = true;
    }

    public void EnableVoiceOffButton() {
        VoiceOffButton.enabled = true;
    }

    public void EnableTextOnButton() {
        TextOnButton.enabled = true;
    }

    public void EnableTextOffButton() {
        TextOffButton.enabled = true;
    }

    public void EnableOrbsOnButton() {
        OrbsOnButton.enabled = true;
    }

    public void EnableOrbsOffButton() {
        OrbsOffButton.enabled = true;
    }

    public void EnableBackButton() {
        BackButton.enabled = true;
    }
    
    public void EnableBackgroundImageA() {
        BackgroundImageA.enabled = true;
    }
    
// --------------- DISABLE OBJECTS FUNCTIONS ---------------
    public void DisableTitleBar() {
        TitleBar.enabled = false;
    }

    public void DisableTitleText() {
        TitleText.enabled = false;
    }

    public void DisableTutorialText() {
        TutorialText.enabled = false;
    }

    public void DisableTutorialFeature() {
        TutorialDescription.enabled = false;
        TutorialDescriptionText.enabled = false;
        TutorialCloseButton.enabled = false;
        TutorialViewport.enabled = false;
    }

    public void DisableArtworkFeature() {
        ArtworkDescription.enabled = false;
        ArtworkDescriptionText.enabled = false;
        ArtworkCloseButton.enabled = false;
        ArtworkViewport.enabled = false;
    }

    public void DisableVoiceOnButton() {
        VoiceOnButton.enabled = false;
    }

    public void DisableVoiceOffButton() {
        VoiceOffButton.enabled = false;
    }

    public void DisableTextOnButton() {
        TextOnButton.enabled = false;
    }

    public void DisableTextOffButton() {
        TextOffButton.enabled = false;
    }

    public void DisableOrbsOnButton() {
        OrbsOnButton.enabled = false;
    }

    public void DisableOrbsOffButton() {
        OrbsOffButton.enabled = false;
    }

    public void DisableBackButton() {
        BackButton.enabled = false;
    }
    
    public void DisableBackgroundImageA() {
        BackgroundImageA.enabled = false;
    }

// --------------- BLENDER OBJECTS FUNCTIONS ---------------
    public void EnableBaseBlenderObjects() {
        Ceiling.enabled = true;
        Floor.enabled = true;
        WallBack.enabled = true;
        WallFront.enabled = true;
        WallLeft.enabled = true;
        WallRight.enabled = true;
    }

    public void DisableBaseBlenderObjects() {
        Ceiling.enabled = false;
        Floor.enabled = false;
        WallBack.enabled = false;
        WallFront.enabled = false;
        WallLeft.enabled = false;
        WallRight.enabled = false;
    }

// --------------- ARTWORK OBJECTS FUNCTIONS ---------------
    public void EnableArtwork01() {
        Artwork01.enabled = true;
    }

    public void EnableArtwork02() {
        Artwork02.enabled = true;
    }

    public void EnableArtwork03() {
        Artwork03.enabled = true;
    }

    public void EnableArtwork04() {
        Artwork04.enabled = true;
    }

    public void EnableArtwork05() {
        Artwork05.enabled = true;
    }

    public void EnableArtwork06() {
        Artwork06.enabled = true;
    }

    public void EnableArtwork07() {
        Artwork07.enabled = true;
    }

    public void EnableArtwork08() {
        Artwork08.enabled = true;
    }

    public void EnableArtwork09() {
        Artwork09.enabled = true;
    }

    public void EnableArtwork10() {
        Artwork10.enabled = true;
    }

    public void EnableArtwork11() {
        Artwork11.enabled = true;
    }

    public void EnableArtwork12() {
        Artwork12.enabled = true;
    }

    public void EnableArtwork13() {
        Artwork13.enabled = true;
    }

    public void EnableArtwork14() {
        Artwork14.enabled = true;
    }

    public void EnableArtwork15() {
        Artwork15.enabled = true;
    }

    public void EnableArtwork16() {
        Artwork16.enabled = true;
    }

    public void DisableArtwork01() {
        Artwork01.enabled = false;
    }

    public void DisableArtwork02() {
        Artwork02.enabled = false;
    }

    public void DisableArtwork03() {
        Artwork03.enabled = false;
    }

    public void DisableArtwork04() {
        Artwork04.enabled = false;
    }

    public void DisableArtwork05() {
        Artwork05.enabled = false;
    }

    public void DisableArtwork06() {
        Artwork06.enabled = false;
    }

    public void DisableArtwork07() {
        Artwork07.enabled = false;
    }

    public void DisableArtwork08() {
        Artwork08.enabled = false;
    }

    public void DisableArtwork09() {
        Artwork09.enabled = false;
    }

    public void DisableArtwork10() {
        Artwork10.enabled = false;
    }

    public void DisableArtwork11() {
        Artwork11.enabled = false;
    }

    public void DisableArtwork12() {
        Artwork12.enabled = false;
    }

    public void DisableArtwork13() {
        Artwork13.enabled = false;
    }

    public void DisableArtwork14() {
        Artwork14.enabled = false;
    }

    public void DisableArtwork15() {
        Artwork15.enabled = false;
    }

    public void DisableArtwork16() {
        Artwork16.enabled = false;
    }

    public void EnableArtwork01Orbs() {
        Orbs01Orb1.enabled = true;
        Orbs01Orb2.enabled = true;
        Orbs01Orb3.enabled = true;
        Orbs01Orb4.enabled = true;
        Orbs01Orb5.enabled = true;
    }

    public void DisableArtwork01Orbs() {
        Orbs01Orb1.enabled = false;
        Orbs01Orb2.enabled = false;
        Orbs01Orb3.enabled = false;
        Orbs01Orb4.enabled = false;
        Orbs01Orb5.enabled = false;
    }

    public void DisableAllArtworks() {
        DisableArtwork01();
        DisableArtwork02();
        DisableArtwork03();
        DisableArtwork04();
        DisableArtwork05();
        DisableArtwork06();
        DisableArtwork07();
        DisableArtwork08();
        DisableArtwork09();
        DisableArtwork10();
        DisableArtwork11();
        DisableArtwork12();
        DisableArtwork13();
        DisableArtwork14();
        DisableArtwork15();
        DisableArtwork16();
    }

    public void DisableAllArtworkOrbs() {
        DisableArtwork01Orbs();
    }

    public void ShowCat4Artworks() {
        if (GalleryInfoSceneButtons.ArtworkSelectionButton == 22) {
            DisableAllArtworks();
            DisableAllArtworkOrbs();
            EnableArtwork01();
            TitleText.text = MainGalleryDatabase.Cat4AppPainting01Name;
            EnableArtwork01Orbs();
        }

        if (GalleryInfoSceneButtons.ArtworkSelectionButton == 23) {
            DisableAllArtworks();
            DisableAllArtworkOrbs();
            EnableArtwork02();
            TitleText.text = MainGalleryDatabase.Cat4AppPainting02Name;
        }

        if (GalleryInfoSceneButtons.ArtworkSelectionButton == 24) {
            DisableAllArtworks();
            DisableAllArtworkOrbs();
            EnableArtwork03();
            TitleText.text = MainGalleryDatabase.Cat4AppPainting03Name;
        }

        if (GalleryInfoSceneButtons.ArtworkSelectionButton == 25) {
            DisableAllArtworks();
            DisableAllArtworkOrbs();
            EnableArtwork04();
            TitleText.text = MainGalleryDatabase.Cat4AppPainting04Name;
        }

        if (GalleryInfoSceneButtons.ArtworkSelectionButton == 26) {
            DisableAllArtworks();
            DisableAllArtworkOrbs();
            EnableArtwork05();
            TitleText.text = MainGalleryDatabase.Cat4AppPainting05Name;
        }

        if (GalleryInfoSceneButtons.ArtworkSelectionButton == 27) {
            DisableAllArtworks();
            DisableAllArtworkOrbs();
            EnableArtwork06();
            TitleText.text = MainGalleryDatabase.Cat4AppPainting06Name;
        }

        if (GalleryInfoSceneButtons.ArtworkSelectionButton == 28) {
            DisableAllArtworks();
            DisableAllArtworkOrbs();
            EnableArtwork07();
            TitleText.text = MainGalleryDatabase.Cat4AppPainting07Name;
        }

        if (GalleryInfoSceneButtons.ArtworkSelectionButton == 29) {
            DisableAllArtworks();
            DisableAllArtworkOrbs();
            EnableArtwork08();
            TitleText.text = MainGalleryDatabase.Cat4AppPainting08Name;
        }

        if (GalleryInfoSceneButtons.ArtworkSelectionButton == 30) {
            DisableAllArtworks();
            DisableAllArtworkOrbs();
            EnableArtwork09();
            TitleText.text = MainGalleryDatabase.Cat4AppPainting09Name;
        }

        if (GalleryInfoSceneButtons.ArtworkSelectionButton == 31) {
            DisableAllArtworks();
            DisableAllArtworkOrbs();
            EnableArtwork10();
            TitleText.text = MainGalleryDatabase.Cat4AppPainting10Name;
        }

        if (GalleryInfoSceneButtons.ArtworkSelectionButton == 32) {
            DisableAllArtworks();
            DisableAllArtworkOrbs();
            EnableArtwork11();
            TitleText.text = MainGalleryDatabase.Cat4AppPainting11Name;
        }

        if (GalleryInfoSceneButtons.ArtworkSelectionButton == 33) {
            DisableAllArtworks();
            DisableAllArtworkOrbs();
            EnableArtwork12();
            TitleText.text = MainGalleryDatabase.Cat4AppPainting12Name;
        }

        if (GalleryInfoSceneButtons.ArtworkSelectionButton == 34) {
            DisableAllArtworks();
            DisableAllArtworkOrbs();
            EnableArtwork13();
            TitleText.text = MainGalleryDatabase.Cat4AppPainting13Name;
        }

        if (GalleryInfoSceneButtons.ArtworkSelectionButton == 35) {
            DisableAllArtworks();
            DisableAllArtworkOrbs();
            EnableArtwork14();
            TitleText.text = MainGalleryDatabase.Cat4AppPainting14Name;
        }

        if (GalleryInfoSceneButtons.ArtworkSelectionButton == 36) {
            DisableAllArtworks();
            DisableAllArtworkOrbs();
            EnableArtwork15();
            TitleText.text = MainGalleryDatabase.Cat4AppPainting15Name;
        }

        if (GalleryInfoSceneButtons.ArtworkSelectionButton == 37) {
            DisableAllArtworks();
            DisableAllArtworkOrbs();
            EnableArtwork16();
            TitleText.text = MainGalleryDatabase.Cat4AppPainting16Name;
        }
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}