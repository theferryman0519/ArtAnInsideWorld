using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class GalleryMainSceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button GalleryCat1Select;
    public Button GalleryCat2Select;
    public Button GalleryCat3Select;
    public Button GalleryCat4Select;
    public Button GalleryCat5Select;
    public Button EnterCertainGalleryButton;
    public Button BackButtonGallery;
    public Button BackButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int GalleryMainClickInt;
    public static int GalleryMainShowingInt;
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Changing
    public SceneChange OpeningScene01Loading;
    public SceneChange GLSScene13Loading;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
        GalleryMainClickInt = 0;
        GalleryMainShowingInt = 0;

        // Gallery Cat 1 Select Button
		Button GalleryCat1SelectClick = GalleryCat1Select.GetComponent<Button>();
		GalleryCat1SelectClick.onClick.AddListener(GalleryCat1SelectClicking);

        // Gallery Cat 2 Select Button
		Button GalleryCat2SelectClick = GalleryCat2Select.GetComponent<Button>();
		GalleryCat2SelectClick.onClick.AddListener(GalleryCat2SelectClicking);

        // Gallery Cat 3 Select Button
		Button GalleryCat3SelectClick = GalleryCat3Select.GetComponent<Button>();
		GalleryCat3SelectClick.onClick.AddListener(GalleryCat3SelectClicking);

        // Gallery Cat 4 Select Button
		Button GalleryCat4SelectClick = GalleryCat4Select.GetComponent<Button>();
		GalleryCat4SelectClick.onClick.AddListener(GalleryCat4SelectClicking);

        // Gallery Cat 5 Select Button
		Button GalleryCat5SelectClick = GalleryCat5Select.GetComponent<Button>();
		GalleryCat5SelectClick.onClick.AddListener(GalleryCat5SelectClicking);

        // Enter Certain Gallery Button
		Button EnterCertainGalleryButtonClick = EnterCertainGalleryButton.GetComponent<Button>();
		EnterCertainGalleryButtonClick.onClick.AddListener(EnterCertainGalleryButtonClicking);

        // Back Button Gallery
		Button BackButtonGalleryClick = BackButtonGallery.GetComponent<Button>();
		BackButtonGalleryClick.onClick.AddListener(BackButtonGalleryClicking);

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
    public void GalleryCat1SelectClicking() {
        GalleryMainShowingInt = 1;
    }

    public void GalleryCat2SelectClicking() {
        GalleryMainShowingInt = 2;
    }

    public void GalleryCat3SelectClicking() {
        GalleryMainShowingInt = 3;
    }

    public void GalleryCat4SelectClicking() {
        GalleryMainShowingInt = 4;
    }

    public void GalleryCat5SelectClicking() {
        GalleryMainShowingInt = 5;
    }

    public void EnterCertainGalleryButtonClicking() {
        if (GalleryMainShowingInt == 1) {
            GalleryMainClickInt = 1;
            GLSScene13Loading.GLSScene13Load();
        }

        if (GalleryMainShowingInt == 2) {
            GalleryMainClickInt = 2;
            GLSScene13Loading.GLSScene13Load();
        }

        if (GalleryMainShowingInt == 3) {
            GalleryMainClickInt = 3;
            GLSScene13Loading.GLSScene13Load();
        }

        if (GalleryMainShowingInt == 4) {
            GalleryMainClickInt = 4;
            GLSScene13Loading.GLSScene13Load();
        }

        if (GalleryMainShowingInt == 5) {
            GalleryMainClickInt = 5;
            GLSScene13Loading.GLSScene13Load();
        }
    }

    public void BackButtonGalleryClicking() {
        GalleryMainShowingInt = 0;
    }

    public void BackButtonClicking() {
        OpeningScene01Loading.OpeningScene01Load();
    }

// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}