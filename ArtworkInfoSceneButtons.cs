using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class ArtworkInfoSceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    public Button ARButton;
	public Button BackButton;
	public Button ArtworkImage;
	public Button EnlargedBackButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int ARSelectionButton;
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Changing
    public SceneChange GLSScene13Loading;
	public SceneChange Cat4PaintingsSceneLoading;

	// Enable / Disable
	public ArtworkInfoSceneEnable DisableBackgroundImageCHide;
    public ArtworkInfoSceneEnable DisableEnlargedArtworkHide;
    public ArtworkInfoSceneEnable DisableEnlargedBackButtonHide;

	public ArtworkInfoSceneEnable EnableBackgroundImageCHide;
    public ArtworkInfoSceneEnable EnableEnlargedArtworkHide;
    public ArtworkInfoSceneEnable EnableEnlargedBackButtonHide;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		ARSelectionButton = 0;

        // AR Button
		Button ARButtonClick = ARButton.GetComponent<Button>();
		ARButtonClick.onClick.AddListener(ARButtonClicking);

		// Artwork Image
		Button ArtworkImageClick = ArtworkImage.GetComponent<Button>();
		ArtworkImageClick.onClick.AddListener(ArtworkImageClicking);

		// Enlarged Back Button
		Button EnlargedBackButtonClick = EnlargedBackButton.GetComponent<Button>();
		EnlargedBackButtonClick.onClick.AddListener(EnlargedBackButtonClicking);

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
    public void ARButtonClicking() {        
		// Cat 1


		// Cat 2


		// Cat 3


		// Cat 4
		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 22) {
			Cat4PaintingsSceneLoading.Cat4PaintingsSceneLoad();
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 23) {
			Cat4PaintingsSceneLoading.Cat4PaintingsSceneLoad();
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 24) {
			Cat4PaintingsSceneLoading.Cat4PaintingsSceneLoad();
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 25) {
			Cat4PaintingsSceneLoading.Cat4PaintingsSceneLoad();
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 26) {
			Cat4PaintingsSceneLoading.Cat4PaintingsSceneLoad();
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 27) {
			Cat4PaintingsSceneLoading.Cat4PaintingsSceneLoad();
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 28) {
			Cat4PaintingsSceneLoading.Cat4PaintingsSceneLoad();
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 29) {
			Cat4PaintingsSceneLoading.Cat4PaintingsSceneLoad();
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 30) {
			Cat4PaintingsSceneLoading.Cat4PaintingsSceneLoad();
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 31) {
			Cat4PaintingsSceneLoading.Cat4PaintingsSceneLoad();
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 32) {
			Cat4PaintingsSceneLoading.Cat4PaintingsSceneLoad();
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 33) {
			Cat4PaintingsSceneLoading.Cat4PaintingsSceneLoad();
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 34) {
			Cat4PaintingsSceneLoading.Cat4PaintingsSceneLoad();
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 35) {
			Cat4PaintingsSceneLoading.Cat4PaintingsSceneLoad();
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 36) {
			Cat4PaintingsSceneLoading.Cat4PaintingsSceneLoad();
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 37) {
			Cat4PaintingsSceneLoading.Cat4PaintingsSceneLoad();
		}

		// Cat 5

    }

	public void ArtworkImageClicking() {
		EnableBackgroundImageCHide.EnableBackgroundImageC();
		EnableEnlargedArtworkHide.EnableEnlargedArtwork();
		EnableEnlargedBackButtonHide.EnableEnlargedBackButton();
	}

	public void EnlargedBackButtonClicking() {
		DisableBackgroundImageCHide.DisableBackgroundImageC();
		DisableEnlargedArtworkHide.DisableEnlargedArtwork();
		DisableEnlargedBackButtonHide.DisableEnlargedBackButton();
	}

	public void BackButtonClicking() {
		ARSelectionButton = 0;
        GLSScene13Loading.GLSScene13Load();
    }

// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}