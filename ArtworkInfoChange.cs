using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class ArtworkInfoChange : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Text TitleText;
    public Text ArtistText;
    public Text DateText;
    public Text MovementText;
    public Text OriginationText;
    public Text MuseumText;
	public Image ArtworkImage;
	public Text ArtworkDescription;
	public Image EnlargedArtwork;

	// Sprites
	public Sprite Cat1Art01;
	public Sprite Cat1Art02;
	public Sprite Cat1Art03;
	public Sprite Cat1Art04;
	public Sprite Cat1Art05;
	public Sprite Cat1Art06;
	public Sprite Cat2Art01;
	public Sprite Cat2Art02;
	public Sprite Cat2Art03;
	public Sprite Cat2Art04;
	public Sprite Cat2Art05;
	public Sprite Cat2Art06;
	public Sprite Cat2Art07;
	public Sprite Cat2Art08;
	public Sprite Cat2Art09;
	public Sprite Cat3Art01;
	public Sprite Cat3Art02;
	public Sprite Cat3Art03;
	public Sprite Cat3Art04;
	public Sprite Cat3Art05;
	public Sprite Cat3Art06;
	public Sprite Cat4Art01;
	public Sprite Cat4Art02;
	public Sprite Cat4Art03;
	public Sprite Cat4Art04;
	public Sprite Cat4Art05;
	public Sprite Cat4Art06;
	public Sprite Cat4Art07;
	public Sprite Cat4Art08;
	public Sprite Cat4Art09;
	public Sprite Cat4Art10;
	public Sprite Cat4Art11;
	public Sprite Cat4Art12;
	public Sprite Cat4Art13;
	public Sprite Cat4Art14;
	public Sprite Cat4Art15;
	public Sprite Cat4Art16;
	public Sprite Cat5Art01;
	public Sprite Cat5Art02;
	public Sprite Cat5Art03;
	public Sprite Cat5Art04;
	public Sprite Cat5Art05;
	public Sprite Cat5Art06;
	public Sprite Cat5Art07;
	public Sprite Cat5Art08;
	public Sprite Cat5Art09;
	public Sprite Cat5Art10;
	public Sprite Cat5Art11;
	public Sprite Cat5Art12;
	public Sprite Cat5Art13;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
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
		UpdateMainText();
		UpdateScroll();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    public void UpdateMainText() {
		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 0) {
			TitleText.text = "";
			ArtistText.text = "";
			DateText.text = "";
			MovementText.text = "";
			OriginationText.text = "";
			MuseumText.text = "";
		}

		// Cat 1
		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 1) {
			TitleText.text = MainGalleryDatabase.Cat1AppPainting01Name;
			ArtistText.text = MainGalleryDatabase.Cat1AppPainting01Artist;
			DateText.text = MainGalleryDatabase.Cat1AppPainting01Date;
			MovementText.text = MainGalleryDatabase.Cat1AppPainting01Movement;
			OriginationText.text = MainGalleryDatabase.Cat1AppPainting01Origintation;
			MuseumText.text = MainGalleryDatabase.Cat1AppPainting01MuseumName + " (" + MainGalleryDatabase.Cat1AppPainting01MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 2) {
			TitleText.text = MainGalleryDatabase.Cat1AppPainting02Name;
			ArtistText.text = MainGalleryDatabase.Cat1AppPainting02Artist;
			DateText.text = MainGalleryDatabase.Cat1AppPainting02Date;
			MovementText.text = MainGalleryDatabase.Cat1AppPainting02Movement;
			OriginationText.text = MainGalleryDatabase.Cat1AppPainting02Origintation;
			MuseumText.text = MainGalleryDatabase.Cat1AppPainting02MuseumName + " (" + MainGalleryDatabase.Cat1AppPainting02MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 3) {
			TitleText.text = MainGalleryDatabase.Cat1AppPainting03Name;
			ArtistText.text = MainGalleryDatabase.Cat1AppPainting03Artist;
			DateText.text = MainGalleryDatabase.Cat1AppPainting03Date;
			MovementText.text = MainGalleryDatabase.Cat1AppPainting03Movement;
			OriginationText.text = MainGalleryDatabase.Cat1AppPainting03Origintation;
			MuseumText.text = MainGalleryDatabase.Cat1AppPainting03MuseumName + " (" + MainGalleryDatabase.Cat1AppPainting03MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 4) {
			TitleText.text = MainGalleryDatabase.Cat1AppPainting04Name;
			ArtistText.text = MainGalleryDatabase.Cat1AppPainting04Artist;
			DateText.text = MainGalleryDatabase.Cat1AppPainting04Date;
			MovementText.text = MainGalleryDatabase.Cat1AppPainting04Movement;
			OriginationText.text = MainGalleryDatabase.Cat1AppPainting04Origintation;
			MuseumText.text = MainGalleryDatabase.Cat1AppPainting04MuseumName + " (" + MainGalleryDatabase.Cat1AppPainting04MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 5) {
			TitleText.text = MainGalleryDatabase.Cat1AppPainting05Name;
			ArtistText.text = MainGalleryDatabase.Cat1AppPainting05Artist;
			DateText.text = MainGalleryDatabase.Cat1AppPainting05Date;
			MovementText.text = MainGalleryDatabase.Cat1AppPainting05Movement;
			OriginationText.text = MainGalleryDatabase.Cat1AppPainting05Origintation;
			MuseumText.text = MainGalleryDatabase.Cat1AppPainting05MuseumName + " (" + MainGalleryDatabase.Cat1AppPainting05MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 6) {
			TitleText.text = MainGalleryDatabase.Cat1AppPainting06Name;
			ArtistText.text = MainGalleryDatabase.Cat1AppPainting06Artist;
			DateText.text = MainGalleryDatabase.Cat1AppPainting06Date;
			MovementText.text = MainGalleryDatabase.Cat1AppPainting06Movement;
			OriginationText.text = MainGalleryDatabase.Cat1AppPainting06Origintation;
			MuseumText.text = MainGalleryDatabase.Cat1AppPainting06MuseumName + " (" + MainGalleryDatabase.Cat1AppPainting06MuseumLocation + ")";
		}

		// Cat 2
		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 7) {
			TitleText.text = MainGalleryDatabase.Cat2AppPainting01Name;
			ArtistText.text = MainGalleryDatabase.Cat2AppPainting01Artist;
			DateText.text = MainGalleryDatabase.Cat2AppPainting01Date;
			MovementText.text = MainGalleryDatabase.Cat2AppPainting01Movement;
			OriginationText.text = MainGalleryDatabase.Cat2AppPainting01Origintation;
			MuseumText.text = MainGalleryDatabase.Cat2AppPainting01MuseumName + " (" + MainGalleryDatabase.Cat2AppPainting01MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 8) {
			TitleText.text = MainGalleryDatabase.Cat2AppPainting02Name;
			ArtistText.text = MainGalleryDatabase.Cat2AppPainting02Artist;
			DateText.text = MainGalleryDatabase.Cat2AppPainting02Date;
			MovementText.text = MainGalleryDatabase.Cat2AppPainting02Movement;
			OriginationText.text = MainGalleryDatabase.Cat2AppPainting02Origintation;
			MuseumText.text = MainGalleryDatabase.Cat2AppPainting02MuseumName + " (" + MainGalleryDatabase.Cat2AppPainting02MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 9) {
			TitleText.text = MainGalleryDatabase.Cat2AppPainting03Name;
			ArtistText.text = MainGalleryDatabase.Cat2AppPainting03Artist;
			DateText.text = MainGalleryDatabase.Cat2AppPainting03Date;
			MovementText.text = MainGalleryDatabase.Cat2AppPainting03Movement;
			OriginationText.text = MainGalleryDatabase.Cat2AppPainting03Origintation;
			MuseumText.text = MainGalleryDatabase.Cat2AppPainting03MuseumName + " (" + MainGalleryDatabase.Cat2AppPainting03MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 10) {
			TitleText.text = MainGalleryDatabase.Cat2AppPainting04Name;
			ArtistText.text = MainGalleryDatabase.Cat2AppPainting04Artist;
			DateText.text = MainGalleryDatabase.Cat2AppPainting04Date;
			MovementText.text = MainGalleryDatabase.Cat2AppPainting04Movement;
			OriginationText.text = MainGalleryDatabase.Cat2AppPainting04Origintation;
			MuseumText.text = MainGalleryDatabase.Cat2AppPainting04MuseumName + " (" + MainGalleryDatabase.Cat2AppPainting04MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 11) {
			TitleText.text = MainGalleryDatabase.Cat2AppPainting05Name;
			ArtistText.text = MainGalleryDatabase.Cat2AppPainting05Artist;
			DateText.text = MainGalleryDatabase.Cat2AppPainting05Date;
			MovementText.text = MainGalleryDatabase.Cat2AppPainting05Movement;
			OriginationText.text = MainGalleryDatabase.Cat2AppPainting05Origintation;
			MuseumText.text = MainGalleryDatabase.Cat2AppPainting05MuseumName + " (" + MainGalleryDatabase.Cat2AppPainting05MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 12) {
			TitleText.text = MainGalleryDatabase.Cat2AppPainting06Name;
			ArtistText.text = MainGalleryDatabase.Cat2AppPainting06Artist;
			DateText.text = MainGalleryDatabase.Cat2AppPainting06Date;
			MovementText.text = MainGalleryDatabase.Cat2AppPainting06Movement;
			OriginationText.text = MainGalleryDatabase.Cat2AppPainting06Origintation;
			MuseumText.text = MainGalleryDatabase.Cat2AppPainting06MuseumName + " (" + MainGalleryDatabase.Cat2AppPainting06MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 13) {
			TitleText.text = MainGalleryDatabase.Cat2AppPainting07Name;
			ArtistText.text = MainGalleryDatabase.Cat2AppPainting07Artist;
			DateText.text = MainGalleryDatabase.Cat2AppPainting07Date;
			MovementText.text = MainGalleryDatabase.Cat2AppPainting07Movement;
			OriginationText.text = MainGalleryDatabase.Cat2AppPainting07Origintation;
			MuseumText.text = MainGalleryDatabase.Cat2AppPainting07MuseumName + " (" + MainGalleryDatabase.Cat2AppPainting07MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 14) {
			TitleText.text = MainGalleryDatabase.Cat2AppPainting08Name;
			ArtistText.text = MainGalleryDatabase.Cat2AppPainting08Artist;
			DateText.text = MainGalleryDatabase.Cat2AppPainting08Date;
			MovementText.text = MainGalleryDatabase.Cat2AppPainting08Movement;
			OriginationText.text = MainGalleryDatabase.Cat2AppPainting08Origintation;
			MuseumText.text = MainGalleryDatabase.Cat2AppPainting08MuseumName + " (" + MainGalleryDatabase.Cat2AppPainting08MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 15) {
			TitleText.text = MainGalleryDatabase.Cat2AppPainting09Name;
			ArtistText.text = MainGalleryDatabase.Cat2AppPainting09Artist;
			DateText.text = MainGalleryDatabase.Cat2AppPainting09Date;
			MovementText.text = MainGalleryDatabase.Cat2AppPainting09Movement;
			OriginationText.text = MainGalleryDatabase.Cat2AppPainting09Origintation;
			MuseumText.text = MainGalleryDatabase.Cat2AppPainting09MuseumName + " (" + MainGalleryDatabase.Cat2AppPainting09MuseumLocation + ")";
		}

		// Cat 3
		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 16) {
			TitleText.text = MainGalleryDatabase.Cat3AppPainting01Name;
			ArtistText.text = MainGalleryDatabase.Cat3AppPainting01Artist;
			DateText.text = MainGalleryDatabase.Cat3AppPainting01Date;
			MovementText.text = MainGalleryDatabase.Cat3AppPainting01Movement;
			OriginationText.text = MainGalleryDatabase.Cat3AppPainting01Origintation;
			MuseumText.text = MainGalleryDatabase.Cat3AppPainting01MuseumName + " (" + MainGalleryDatabase.Cat3AppPainting01MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 17) {
			TitleText.text = MainGalleryDatabase.Cat3AppPainting02Name;
			ArtistText.text = MainGalleryDatabase.Cat3AppPainting02Artist;
			DateText.text = MainGalleryDatabase.Cat3AppPainting02Date;
			MovementText.text = MainGalleryDatabase.Cat3AppPainting02Movement;
			OriginationText.text = MainGalleryDatabase.Cat3AppPainting02Origintation;
			MuseumText.text = MainGalleryDatabase.Cat3AppPainting02MuseumName + " (" + MainGalleryDatabase.Cat3AppPainting02MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 18) {
			TitleText.text = MainGalleryDatabase.Cat3AppPainting03Name;
			ArtistText.text = MainGalleryDatabase.Cat3AppPainting03Artist;
			DateText.text = MainGalleryDatabase.Cat3AppPainting03Date;
			MovementText.text = MainGalleryDatabase.Cat3AppPainting03Movement;
			OriginationText.text = MainGalleryDatabase.Cat3AppPainting03Origintation;
			MuseumText.text = MainGalleryDatabase.Cat3AppPainting03MuseumName + " (" + MainGalleryDatabase.Cat3AppPainting03MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 19) {
			TitleText.text = MainGalleryDatabase.Cat3AppPainting04Name;
			ArtistText.text = MainGalleryDatabase.Cat3AppPainting04Artist;
			DateText.text = MainGalleryDatabase.Cat3AppPainting04Date;
			MovementText.text = MainGalleryDatabase.Cat3AppPainting04Movement;
			OriginationText.text = MainGalleryDatabase.Cat3AppPainting04Origintation;
			MuseumText.text = MainGalleryDatabase.Cat3AppPainting04MuseumName + " (" + MainGalleryDatabase.Cat3AppPainting04MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 20) {
			TitleText.text = MainGalleryDatabase.Cat3AppPainting05Name;
			ArtistText.text = MainGalleryDatabase.Cat3AppPainting05Artist;
			DateText.text = MainGalleryDatabase.Cat3AppPainting05Date;
			MovementText.text = MainGalleryDatabase.Cat3AppPainting05Movement;
			OriginationText.text = MainGalleryDatabase.Cat3AppPainting05Origintation;
			MuseumText.text = MainGalleryDatabase.Cat3AppPainting05MuseumName + " (" + MainGalleryDatabase.Cat3AppPainting05MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 21) {
			TitleText.text = MainGalleryDatabase.Cat3AppPainting06Name;
			ArtistText.text = MainGalleryDatabase.Cat3AppPainting06Artist;
			DateText.text = MainGalleryDatabase.Cat3AppPainting06Date;
			MovementText.text = MainGalleryDatabase.Cat3AppPainting06Movement;
			OriginationText.text = MainGalleryDatabase.Cat3AppPainting06Origintation;
			MuseumText.text = MainGalleryDatabase.Cat3AppPainting06MuseumName + " (" + MainGalleryDatabase.Cat3AppPainting06MuseumLocation + ")";
		}

		// Cat 4
		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 22) {
			TitleText.text = MainGalleryDatabase.Cat4AppPainting01Name;
			ArtistText.text = MainGalleryDatabase.Cat4AppPainting01Artist;
			DateText.text = MainGalleryDatabase.Cat4AppPainting01Date;
			MovementText.text = MainGalleryDatabase.Cat4AppPainting01Movement;
			OriginationText.text = MainGalleryDatabase.Cat4AppPainting01Origintation;
			MuseumText.text = MainGalleryDatabase.Cat4AppPainting01MuseumName + " (" + MainGalleryDatabase.Cat4AppPainting01MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 23) {
			TitleText.text = MainGalleryDatabase.Cat4AppPainting02Name;
			ArtistText.text = MainGalleryDatabase.Cat4AppPainting02Artist;
			DateText.text = MainGalleryDatabase.Cat4AppPainting02Date;
			MovementText.text = MainGalleryDatabase.Cat4AppPainting02Movement;
			OriginationText.text = MainGalleryDatabase.Cat4AppPainting02Origintation;
			MuseumText.text = MainGalleryDatabase.Cat4AppPainting02MuseumName + " (" + MainGalleryDatabase.Cat4AppPainting02MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 24) {
			TitleText.text = MainGalleryDatabase.Cat4AppPainting03Name;
			ArtistText.text = MainGalleryDatabase.Cat4AppPainting03Artist;
			DateText.text = MainGalleryDatabase.Cat4AppPainting03Date;
			MovementText.text = MainGalleryDatabase.Cat4AppPainting03Movement;
			OriginationText.text = MainGalleryDatabase.Cat4AppPainting03Origintation;
			MuseumText.text = MainGalleryDatabase.Cat4AppPainting03MuseumName + " (" + MainGalleryDatabase.Cat4AppPainting03MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 25) {
			TitleText.text = MainGalleryDatabase.Cat4AppPainting04Name;
			ArtistText.text = MainGalleryDatabase.Cat4AppPainting04Artist;
			DateText.text = MainGalleryDatabase.Cat4AppPainting04Date;
			MovementText.text = MainGalleryDatabase.Cat4AppPainting04Movement;
			OriginationText.text = MainGalleryDatabase.Cat4AppPainting04Origintation;
			MuseumText.text = MainGalleryDatabase.Cat4AppPainting04MuseumName + " (" + MainGalleryDatabase.Cat4AppPainting04MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 26) {
			TitleText.text = MainGalleryDatabase.Cat4AppPainting05Name;
			ArtistText.text = MainGalleryDatabase.Cat4AppPainting05Artist;
			DateText.text = MainGalleryDatabase.Cat4AppPainting05Date;
			MovementText.text = MainGalleryDatabase.Cat4AppPainting05Movement;
			OriginationText.text = MainGalleryDatabase.Cat4AppPainting05Origintation;
			MuseumText.text = MainGalleryDatabase.Cat4AppPainting05MuseumName + " (" + MainGalleryDatabase.Cat4AppPainting05MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 27) {
			TitleText.text = MainGalleryDatabase.Cat4AppPainting06Name;
			ArtistText.text = MainGalleryDatabase.Cat4AppPainting06Artist;
			DateText.text = MainGalleryDatabase.Cat4AppPainting06Date;
			MovementText.text = MainGalleryDatabase.Cat4AppPainting06Movement;
			OriginationText.text = MainGalleryDatabase.Cat4AppPainting06Origintation;
			MuseumText.text = MainGalleryDatabase.Cat4AppPainting06MuseumName + " (" + MainGalleryDatabase.Cat4AppPainting06MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 28) {
			TitleText.text = MainGalleryDatabase.Cat4AppPainting07Name;
			ArtistText.text = MainGalleryDatabase.Cat4AppPainting07Artist;
			DateText.text = MainGalleryDatabase.Cat4AppPainting07Date;
			MovementText.text = MainGalleryDatabase.Cat4AppPainting07Movement;
			OriginationText.text = MainGalleryDatabase.Cat4AppPainting07Origintation;
			MuseumText.text = MainGalleryDatabase.Cat4AppPainting07MuseumName + " (" + MainGalleryDatabase.Cat4AppPainting07MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 29) {
			TitleText.text = MainGalleryDatabase.Cat4AppPainting08Name;
			ArtistText.text = MainGalleryDatabase.Cat4AppPainting08Artist;
			DateText.text = MainGalleryDatabase.Cat4AppPainting08Date;
			MovementText.text = MainGalleryDatabase.Cat4AppPainting08Movement;
			OriginationText.text = MainGalleryDatabase.Cat4AppPainting08Origintation;
			MuseumText.text = MainGalleryDatabase.Cat4AppPainting08MuseumName + " (" + MainGalleryDatabase.Cat4AppPainting08MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 30) {
			TitleText.text = MainGalleryDatabase.Cat4AppPainting09Name;
			ArtistText.text = MainGalleryDatabase.Cat4AppPainting09Artist;
			DateText.text = MainGalleryDatabase.Cat4AppPainting09Date;
			MovementText.text = MainGalleryDatabase.Cat4AppPainting09Movement;
			OriginationText.text = MainGalleryDatabase.Cat4AppPainting09Origintation;
			MuseumText.text = MainGalleryDatabase.Cat4AppPainting09MuseumName + " (" + MainGalleryDatabase.Cat4AppPainting09MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 31) {
			TitleText.text = MainGalleryDatabase.Cat4AppPainting10Name;
			ArtistText.text = MainGalleryDatabase.Cat4AppPainting10Artist;
			DateText.text = MainGalleryDatabase.Cat4AppPainting10Date;
			MovementText.text = MainGalleryDatabase.Cat4AppPainting10Movement;
			OriginationText.text = MainGalleryDatabase.Cat4AppPainting10Origintation;
			MuseumText.text = MainGalleryDatabase.Cat4AppPainting10MuseumName + " (" + MainGalleryDatabase.Cat4AppPainting10MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 32) {
			TitleText.text = MainGalleryDatabase.Cat4AppPainting11Name;
			ArtistText.text = MainGalleryDatabase.Cat4AppPainting11Artist;
			DateText.text = MainGalleryDatabase.Cat4AppPainting11Date;
			MovementText.text = MainGalleryDatabase.Cat4AppPainting11Movement;
			OriginationText.text = MainGalleryDatabase.Cat4AppPainting11Origintation;
			MuseumText.text = MainGalleryDatabase.Cat4AppPainting11MuseumName + " (" + MainGalleryDatabase.Cat4AppPainting11MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 33) {
			TitleText.text = MainGalleryDatabase.Cat4AppPainting12Name;
			ArtistText.text = MainGalleryDatabase.Cat4AppPainting12Artist;
			DateText.text = MainGalleryDatabase.Cat4AppPainting12Date;
			MovementText.text = MainGalleryDatabase.Cat4AppPainting12Movement;
			OriginationText.text = MainGalleryDatabase.Cat4AppPainting12Origintation;
			MuseumText.text = MainGalleryDatabase.Cat4AppPainting12MuseumName + " (" + MainGalleryDatabase.Cat4AppPainting12MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 34) {
			TitleText.text = MainGalleryDatabase.Cat4AppPainting13Name;
			ArtistText.text = MainGalleryDatabase.Cat4AppPainting13Artist;
			DateText.text = MainGalleryDatabase.Cat4AppPainting13Date;
			MovementText.text = MainGalleryDatabase.Cat4AppPainting13Movement;
			OriginationText.text = MainGalleryDatabase.Cat4AppPainting13Origintation;
			MuseumText.text = MainGalleryDatabase.Cat4AppPainting13MuseumName + " (" + MainGalleryDatabase.Cat4AppPainting13MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 35) {
			TitleText.text = MainGalleryDatabase.Cat4AppPainting14Name;
			ArtistText.text = MainGalleryDatabase.Cat4AppPainting14Artist;
			DateText.text = MainGalleryDatabase.Cat4AppPainting14Date;
			MovementText.text = MainGalleryDatabase.Cat4AppPainting14Movement;
			OriginationText.text = MainGalleryDatabase.Cat4AppPainting14Origintation;
			MuseumText.text = MainGalleryDatabase.Cat4AppPainting14MuseumName + " (" + MainGalleryDatabase.Cat4AppPainting14MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 36) {
			TitleText.text = MainGalleryDatabase.Cat4AppPainting15Name;
			ArtistText.text = MainGalleryDatabase.Cat4AppPainting15Artist;
			DateText.text = MainGalleryDatabase.Cat4AppPainting15Date;
			MovementText.text = MainGalleryDatabase.Cat4AppPainting15Movement;
			OriginationText.text = MainGalleryDatabase.Cat4AppPainting15Origintation;
			MuseumText.text = MainGalleryDatabase.Cat4AppPainting15MuseumName + " (" + MainGalleryDatabase.Cat4AppPainting15MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 37) {
			TitleText.text = MainGalleryDatabase.Cat4AppPainting16Name;
			ArtistText.text = MainGalleryDatabase.Cat4AppPainting16Artist;
			DateText.text = MainGalleryDatabase.Cat4AppPainting16Date;
			MovementText.text = MainGalleryDatabase.Cat4AppPainting16Movement;
			OriginationText.text = MainGalleryDatabase.Cat4AppPainting16Origintation;
			MuseumText.text = MainGalleryDatabase.Cat4AppPainting16MuseumName + " (" + MainGalleryDatabase.Cat4AppPainting16MuseumLocation + ")";
		}

		// Cat 5
		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 38) {
			TitleText.text = MainGalleryDatabase.Cat5AppPainting01Name;
			ArtistText.text = MainGalleryDatabase.Cat5AppPainting01Artist;
			DateText.text = MainGalleryDatabase.Cat5AppPainting01Date;
			MovementText.text = MainGalleryDatabase.Cat5AppPainting01Movement;
			OriginationText.text = MainGalleryDatabase.Cat5AppPainting01Origintation;
			MuseumText.text = MainGalleryDatabase.Cat5AppPainting01MuseumName + " (" + MainGalleryDatabase.Cat5AppPainting01MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 39) {
			TitleText.text = MainGalleryDatabase.Cat5AppPainting02Name;
			ArtistText.text = MainGalleryDatabase.Cat5AppPainting02Artist;
			DateText.text = MainGalleryDatabase.Cat5AppPainting02Date;
			MovementText.text = MainGalleryDatabase.Cat5AppPainting02Movement;
			OriginationText.text = MainGalleryDatabase.Cat5AppPainting02Origintation;
			MuseumText.text = MainGalleryDatabase.Cat5AppPainting02MuseumName + " (" + MainGalleryDatabase.Cat5AppPainting02MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 40) {
			TitleText.text = MainGalleryDatabase.Cat5AppPainting03Name;
			ArtistText.text = MainGalleryDatabase.Cat5AppPainting03Artist;
			DateText.text = MainGalleryDatabase.Cat5AppPainting03Date;
			MovementText.text = MainGalleryDatabase.Cat5AppPainting03Movement;
			OriginationText.text = MainGalleryDatabase.Cat5AppPainting03Origintation;
			MuseumText.text = MainGalleryDatabase.Cat5AppPainting03MuseumName + " (" + MainGalleryDatabase.Cat5AppPainting03MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 41) {
			TitleText.text = MainGalleryDatabase.Cat5AppPainting04Name;
			ArtistText.text = MainGalleryDatabase.Cat5AppPainting04Artist;
			DateText.text = MainGalleryDatabase.Cat5AppPainting04Date;
			MovementText.text = MainGalleryDatabase.Cat5AppPainting04Movement;
			OriginationText.text = MainGalleryDatabase.Cat5AppPainting04Origintation;
			MuseumText.text = MainGalleryDatabase.Cat5AppPainting04MuseumName + " (" + MainGalleryDatabase.Cat5AppPainting04MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 42) {
			TitleText.text = MainGalleryDatabase.Cat5AppPainting05Name;
			ArtistText.text = MainGalleryDatabase.Cat5AppPainting05Artist;
			DateText.text = MainGalleryDatabase.Cat5AppPainting05Date;
			MovementText.text = MainGalleryDatabase.Cat5AppPainting05Movement;
			OriginationText.text = MainGalleryDatabase.Cat5AppPainting05Origintation;
			MuseumText.text = MainGalleryDatabase.Cat5AppPainting05MuseumName + " (" + MainGalleryDatabase.Cat5AppPainting05MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 43) {
			TitleText.text = MainGalleryDatabase.Cat5AppPainting06Name;
			ArtistText.text = MainGalleryDatabase.Cat5AppPainting06Artist;
			DateText.text = MainGalleryDatabase.Cat5AppPainting06Date;
			MovementText.text = MainGalleryDatabase.Cat5AppPainting06Movement;
			OriginationText.text = MainGalleryDatabase.Cat5AppPainting06Origintation;
			MuseumText.text = MainGalleryDatabase.Cat5AppPainting06MuseumName + " (" + MainGalleryDatabase.Cat5AppPainting06MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 44) {
			TitleText.text = MainGalleryDatabase.Cat5AppPainting07Name;
			ArtistText.text = MainGalleryDatabase.Cat5AppPainting07Artist;
			DateText.text = MainGalleryDatabase.Cat5AppPainting07Date;
			MovementText.text = MainGalleryDatabase.Cat5AppPainting07Movement;
			OriginationText.text = MainGalleryDatabase.Cat5AppPainting07Origintation;
			MuseumText.text = MainGalleryDatabase.Cat5AppPainting07MuseumName + " (" + MainGalleryDatabase.Cat5AppPainting07MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 45) {
			TitleText.text = MainGalleryDatabase.Cat5AppPainting08Name;
			ArtistText.text = MainGalleryDatabase.Cat5AppPainting08Artist;
			DateText.text = MainGalleryDatabase.Cat5AppPainting08Date;
			MovementText.text = MainGalleryDatabase.Cat5AppPainting08Movement;
			OriginationText.text = MainGalleryDatabase.Cat5AppPainting08Origintation;
			MuseumText.text = MainGalleryDatabase.Cat5AppPainting08MuseumName + " (" + MainGalleryDatabase.Cat5AppPainting08MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 46) {
			TitleText.text = MainGalleryDatabase.Cat5AppPainting09Name;
			ArtistText.text = MainGalleryDatabase.Cat5AppPainting09Artist;
			DateText.text = MainGalleryDatabase.Cat5AppPainting09Date;
			MovementText.text = MainGalleryDatabase.Cat5AppPainting09Movement;
			OriginationText.text = MainGalleryDatabase.Cat5AppPainting09Origintation;
			MuseumText.text = MainGalleryDatabase.Cat5AppPainting09MuseumName + " (" + MainGalleryDatabase.Cat5AppPainting09MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 47) {
			TitleText.text = MainGalleryDatabase.Cat5AppPainting10Name;
			ArtistText.text = MainGalleryDatabase.Cat5AppPainting10Artist;
			DateText.text = MainGalleryDatabase.Cat5AppPainting10Date;
			MovementText.text = MainGalleryDatabase.Cat5AppPainting10Movement;
			OriginationText.text = MainGalleryDatabase.Cat5AppPainting10Origintation;
			MuseumText.text = MainGalleryDatabase.Cat5AppPainting10MuseumName + " (" + MainGalleryDatabase.Cat5AppPainting10MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 48) {
			TitleText.text = MainGalleryDatabase.Cat5AppPainting11Name;
			ArtistText.text = MainGalleryDatabase.Cat5AppPainting11Artist;
			DateText.text = MainGalleryDatabase.Cat5AppPainting11Date;
			MovementText.text = MainGalleryDatabase.Cat5AppPainting11Movement;
			OriginationText.text = MainGalleryDatabase.Cat5AppPainting11Origintation;
			MuseumText.text = MainGalleryDatabase.Cat5AppPainting11MuseumName + " (" + MainGalleryDatabase.Cat5AppPainting11MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 49) {
			TitleText.text = MainGalleryDatabase.Cat5AppPainting12Name;
			ArtistText.text = MainGalleryDatabase.Cat5AppPainting12Artist;
			DateText.text = MainGalleryDatabase.Cat5AppPainting12Date;
			MovementText.text = MainGalleryDatabase.Cat5AppPainting12Movement;
			OriginationText.text = MainGalleryDatabase.Cat5AppPainting12Origintation;
			MuseumText.text = MainGalleryDatabase.Cat5AppPainting12MuseumName + " (" + MainGalleryDatabase.Cat5AppPainting12MuseumLocation + ")";
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 50) {
			TitleText.text = MainGalleryDatabase.Cat5AppPainting13Name;
			ArtistText.text = MainGalleryDatabase.Cat5AppPainting13Artist;
			DateText.text = MainGalleryDatabase.Cat5AppPainting13Date;
			MovementText.text = MainGalleryDatabase.Cat5AppPainting13Movement;
			OriginationText.text = MainGalleryDatabase.Cat5AppPainting13Origintation;
			MuseumText.text = MainGalleryDatabase.Cat5AppPainting13MuseumName + " (" + MainGalleryDatabase.Cat5AppPainting13MuseumLocation + ")";
		}
	}

	public void UpdateScroll() {
		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 0) {
			ArtworkDescription.text = "";
		}

		// Cat 1
		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 1) {
			ArtworkImage.sprite = Cat1Art01;
			EnlargedArtwork.sprite = Cat1Art01;
			ArtworkDescription.text = MainGalleryDatabase.Cat1AppPainting01MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 2) {
			ArtworkImage.sprite = Cat1Art02;
			EnlargedArtwork.sprite = Cat1Art02;
			ArtworkDescription.text = MainGalleryDatabase.Cat1AppPainting02MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 3) {
			ArtworkImage.sprite = Cat1Art03;
			EnlargedArtwork.sprite = Cat1Art03;
			ArtworkDescription.text = MainGalleryDatabase.Cat1AppPainting03MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 4) {
			ArtworkImage.sprite = Cat1Art04;
			EnlargedArtwork.sprite = Cat1Art04;
			ArtworkDescription.text = MainGalleryDatabase.Cat1AppPainting04MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 5) {
			ArtworkImage.sprite = Cat1Art05;
			EnlargedArtwork.sprite = Cat1Art05;
			ArtworkDescription.text = MainGalleryDatabase.Cat1AppPainting05MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 6) {
			ArtworkImage.sprite = Cat1Art06;
			EnlargedArtwork.sprite = Cat1Art06;
			ArtworkDescription.text = MainGalleryDatabase.Cat1AppPainting06MainDescription;
		}

		// Cat 2
		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 7) {
			ArtworkImage.sprite = Cat2Art01;
			EnlargedArtwork.sprite = Cat2Art01;
			ArtworkDescription.text = MainGalleryDatabase.Cat2AppPainting01MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 8) {
			ArtworkImage.sprite = Cat2Art02;
			EnlargedArtwork.sprite = Cat2Art02;
			ArtworkDescription.text = MainGalleryDatabase.Cat2AppPainting02MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 9) {
			ArtworkImage.sprite = Cat2Art03;
			EnlargedArtwork.sprite = Cat2Art03;
			ArtworkDescription.text = MainGalleryDatabase.Cat2AppPainting03MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 10) {
			ArtworkImage.sprite = Cat2Art04;
			EnlargedArtwork.sprite = Cat2Art04;
			ArtworkDescription.text = MainGalleryDatabase.Cat2AppPainting04MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 11) {
			ArtworkImage.sprite = Cat2Art05;
			EnlargedArtwork.sprite = Cat2Art05;
			ArtworkDescription.text = MainGalleryDatabase.Cat2AppPainting05MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 12) {
			ArtworkImage.sprite = Cat2Art06;
			EnlargedArtwork.sprite = Cat2Art06;
			ArtworkDescription.text = MainGalleryDatabase.Cat2AppPainting06MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 13) {
			ArtworkImage.sprite = Cat2Art07;
			EnlargedArtwork.sprite = Cat2Art07;
			ArtworkDescription.text = MainGalleryDatabase.Cat2AppPainting07MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 14) {
			ArtworkImage.sprite = Cat2Art08;
			EnlargedArtwork.sprite = Cat2Art08;
			ArtworkDescription.text = MainGalleryDatabase.Cat2AppPainting08MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 15) {
			ArtworkImage.sprite = Cat2Art09;
			EnlargedArtwork.sprite = Cat2Art09;
			ArtworkDescription.text = MainGalleryDatabase.Cat2AppPainting09MainDescription;
		}

		// Cat 3
		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 16) {
			ArtworkImage.sprite = Cat3Art01;
			EnlargedArtwork.sprite = Cat3Art01;
			ArtworkDescription.text = MainGalleryDatabase.Cat3AppPainting01MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 17) {
			ArtworkImage.sprite = Cat3Art02;
			EnlargedArtwork.sprite = Cat3Art02;
			ArtworkDescription.text = MainGalleryDatabase.Cat3AppPainting02MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 18) {
			ArtworkImage.sprite = Cat3Art03;
			EnlargedArtwork.sprite = Cat3Art03;
			ArtworkDescription.text = MainGalleryDatabase.Cat3AppPainting03MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 19) {
			ArtworkImage.sprite = Cat3Art04;
			EnlargedArtwork.sprite = Cat3Art04;
			ArtworkDescription.text = MainGalleryDatabase.Cat3AppPainting04MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 20) {
			ArtworkImage.sprite = Cat3Art05;
			EnlargedArtwork.sprite = Cat3Art05;
			ArtworkDescription.text = MainGalleryDatabase.Cat3AppPainting05MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 21) {
			ArtworkImage.sprite = Cat3Art06;
			EnlargedArtwork.sprite = Cat3Art06;
			ArtworkDescription.text = MainGalleryDatabase.Cat3AppPainting06MainDescription;
		}

		// Cat 4
		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 22) {
			ArtworkImage.sprite = Cat4Art01;
			EnlargedArtwork.sprite = Cat4Art01;
			ArtworkDescription.text = MainGalleryDatabase.Cat4AppPainting01MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 23) {
			ArtworkImage.sprite = Cat4Art02;
			EnlargedArtwork.sprite = Cat4Art02;
			ArtworkDescription.text = MainGalleryDatabase.Cat4AppPainting02MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 24) {
			ArtworkImage.sprite = Cat4Art03;
			EnlargedArtwork.sprite = Cat4Art03;
			ArtworkDescription.text = MainGalleryDatabase.Cat4AppPainting03MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 25) {
			ArtworkImage.sprite = Cat4Art04;
			EnlargedArtwork.sprite = Cat4Art04;
			ArtworkDescription.text = MainGalleryDatabase.Cat4AppPainting04MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 26) {
			ArtworkImage.sprite = Cat4Art05;
			EnlargedArtwork.sprite = Cat4Art05;
			ArtworkDescription.text = MainGalleryDatabase.Cat4AppPainting05MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 27) {
			ArtworkImage.sprite = Cat4Art06;
			EnlargedArtwork.sprite = Cat4Art06;
			ArtworkDescription.text = MainGalleryDatabase.Cat4AppPainting06MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 28) {
			ArtworkImage.sprite = Cat4Art07;
			EnlargedArtwork.sprite = Cat4Art07;
			ArtworkDescription.text = MainGalleryDatabase.Cat4AppPainting07MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 29) {
			ArtworkImage.sprite = Cat4Art08;
			EnlargedArtwork.sprite = Cat4Art08;
			ArtworkDescription.text = MainGalleryDatabase.Cat4AppPainting08MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 30) {
			ArtworkImage.sprite = Cat4Art09;
			EnlargedArtwork.sprite = Cat4Art09;
			ArtworkDescription.text = MainGalleryDatabase.Cat4AppPainting09MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 31) {
			ArtworkImage.sprite = Cat4Art10;
			EnlargedArtwork.sprite = Cat4Art10;
			ArtworkDescription.text = MainGalleryDatabase.Cat4AppPainting10MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 32) {
			ArtworkImage.sprite = Cat4Art11;
			EnlargedArtwork.sprite = Cat4Art11;
			ArtworkDescription.text = MainGalleryDatabase.Cat4AppPainting11MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 33) {
			ArtworkImage.sprite = Cat4Art12;
			EnlargedArtwork.sprite = Cat4Art12;
			ArtworkDescription.text = MainGalleryDatabase.Cat4AppPainting12MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 34) {
			ArtworkImage.sprite = Cat4Art13;
			EnlargedArtwork.sprite = Cat4Art13;
			ArtworkDescription.text = MainGalleryDatabase.Cat4AppPainting13MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 35) {
			ArtworkImage.sprite = Cat4Art14;
			EnlargedArtwork.sprite = Cat4Art14;
			ArtworkDescription.text = MainGalleryDatabase.Cat4AppPainting14MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 36) {
			ArtworkImage.sprite = Cat4Art15;
			EnlargedArtwork.sprite = Cat4Art15;
			ArtworkDescription.text = MainGalleryDatabase.Cat4AppPainting15MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 37) {
			ArtworkImage.sprite = Cat4Art16;
			EnlargedArtwork.sprite = Cat4Art16;
			ArtworkDescription.text = MainGalleryDatabase.Cat4AppPainting16MainDescription;
		}

		// Cat 5
		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 38) {
			ArtworkImage.sprite = Cat5Art01;
			EnlargedArtwork.sprite = Cat5Art01;
			ArtworkDescription.text = MainGalleryDatabase.Cat5AppPainting01MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 39) {
			ArtworkImage.sprite = Cat5Art02;
			EnlargedArtwork.sprite = Cat5Art02;
			ArtworkDescription.text = MainGalleryDatabase.Cat5AppPainting02MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 40) {
			ArtworkImage.sprite = Cat5Art03;
			EnlargedArtwork.sprite = Cat5Art03;
			ArtworkDescription.text = MainGalleryDatabase.Cat5AppPainting03MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 41) {
			ArtworkImage.sprite = Cat5Art04;
			EnlargedArtwork.sprite = Cat5Art04;
			ArtworkDescription.text = MainGalleryDatabase.Cat5AppPainting04MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 42) {
			ArtworkImage.sprite = Cat5Art05;
			EnlargedArtwork.sprite = Cat5Art05;
			ArtworkDescription.text = MainGalleryDatabase.Cat5AppPainting05MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 43) {
			ArtworkImage.sprite = Cat5Art06;
			EnlargedArtwork.sprite = Cat5Art06;
			ArtworkDescription.text = MainGalleryDatabase.Cat5AppPainting06MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 44) {
			ArtworkImage.sprite = Cat5Art07;
			EnlargedArtwork.sprite = Cat5Art07;
			ArtworkDescription.text = MainGalleryDatabase.Cat5AppPainting07MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 45) {
			ArtworkImage.sprite = Cat5Art08;
			EnlargedArtwork.sprite = Cat5Art08;
			ArtworkDescription.text = MainGalleryDatabase.Cat5AppPainting08MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 46) {
			ArtworkImage.sprite = Cat5Art09;
			EnlargedArtwork.sprite = Cat5Art09;
			ArtworkDescription.text = MainGalleryDatabase.Cat5AppPainting09MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 47) {
			ArtworkImage.sprite = Cat5Art10;
			EnlargedArtwork.sprite = Cat5Art10;
			ArtworkDescription.text = MainGalleryDatabase.Cat5AppPainting10MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 48) {
			ArtworkImage.sprite = Cat5Art11;
			EnlargedArtwork.sprite = Cat5Art11;
			ArtworkDescription.text = MainGalleryDatabase.Cat5AppPainting11MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 49) {
			ArtworkImage.sprite = Cat5Art12;
			EnlargedArtwork.sprite = Cat5Art12;
			ArtworkDescription.text = MainGalleryDatabase.Cat5AppPainting12MainDescription;
		}

		if (GalleryInfoSceneButtons.ArtworkSelectionButton == 50) {
			ArtworkImage.sprite = Cat5Art13;
			EnlargedArtwork.sprite = Cat5Art13;
			ArtworkDescription.text = MainGalleryDatabase.Cat5AppPainting13MainDescription;
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}