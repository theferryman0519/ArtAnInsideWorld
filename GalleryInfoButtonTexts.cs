using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class GalleryInfoButtonTexts : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Cat 1
	public Text Cat1TextSelection01;
	public Text Cat1TextSelection02;
	public Text Cat1TextSelection03;
	public Text Cat1TextSelection04;
	public Text Cat1TextSelection05;
	public Text Cat1TextSelection06;

	// Cat 2
	public Text Cat2TextSelection01;
	public Text Cat2TextSelection02;
	public Text Cat2TextSelection03;
	public Text Cat2TextSelection04;
	public Text Cat2TextSelection05;
	public Text Cat2TextSelection06;
	public Text Cat2TextSelection07;
	public Text Cat2TextSelection08;
	public Text Cat2TextSelection09;

	// Cat 3
	public Text Cat3TextSelection01;
	public Text Cat3TextSelection02;
	public Text Cat3TextSelection03;
	public Text Cat3TextSelection04;
	public Text Cat3TextSelection05;
	public Text Cat3TextSelection06;

	// Cat 4
	public Text Cat4TextSelection01;
	public Text Cat4TextSelection02;
	public Text Cat4TextSelection03;
	public Text Cat4TextSelection04;
	public Text Cat4TextSelection05;
	public Text Cat4TextSelection06;
	public Text Cat4TextSelection07;
	public Text Cat4TextSelection08;
	public Text Cat4TextSelection09;
	public Text Cat4TextSelection10;
	public Text Cat4TextSelection11;
	public Text Cat4TextSelection12;
	public Text Cat4TextSelection13;
	public Text Cat4TextSelection14;
	public Text Cat4TextSelection15;
	public Text Cat4TextSelection16;

	// Cat 5
	public Text Cat5TextSelection01;
	public Text Cat5TextSelection02;
	public Text Cat5TextSelection03;
	public Text Cat5TextSelection04;
	public Text Cat5TextSelection05;
	public Text Cat5TextSelection06;
	public Text Cat5TextSelection07;
	public Text Cat5TextSelection08;
	public Text Cat5TextSelection09;
	public Text Cat5TextSelection10;
	public Text Cat5TextSelection11;
	public Text Cat5TextSelection12;
	public Text Cat5TextSelection13;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Cat 1
		Cat1TextSelection01.text = MainGalleryDatabase.Cat1AppPainting01Name;
		Cat1TextSelection02.text = MainGalleryDatabase.Cat1AppPainting02Name;
		Cat1TextSelection03.text = MainGalleryDatabase.Cat1AppPainting03Name;
		Cat1TextSelection04.text = MainGalleryDatabase.Cat1AppPainting04Name;
		Cat1TextSelection05.text = MainGalleryDatabase.Cat1AppPainting05Name;
		Cat1TextSelection06.text = MainGalleryDatabase.Cat1AppPainting06Name;

		// Cat 2
		Cat2TextSelection01.text = MainGalleryDatabase.Cat2AppPainting01Name;
		Cat2TextSelection02.text = MainGalleryDatabase.Cat2AppPainting02Name;
		Cat2TextSelection03.text = MainGalleryDatabase.Cat2AppPainting03Name;
		Cat2TextSelection04.text = MainGalleryDatabase.Cat2AppPainting04Name;
		Cat2TextSelection05.text = MainGalleryDatabase.Cat2AppPainting05Name;
		Cat2TextSelection06.text = MainGalleryDatabase.Cat2AppPainting06Name;
		Cat2TextSelection07.text = MainGalleryDatabase.Cat2AppPainting07Name;
		Cat2TextSelection08.text = MainGalleryDatabase.Cat2AppPainting08Name;
		Cat2TextSelection09.text = MainGalleryDatabase.Cat2AppPainting09Name;

		// Cat 3
		Cat3TextSelection01.text = MainGalleryDatabase.Cat3AppPainting01Name;
		Cat3TextSelection02.text = MainGalleryDatabase.Cat3AppPainting02Name;
		Cat3TextSelection03.text = MainGalleryDatabase.Cat3AppPainting03Name;
		Cat3TextSelection04.text = MainGalleryDatabase.Cat3AppPainting04Name;
		Cat3TextSelection05.text = MainGalleryDatabase.Cat3AppPainting05Name;
		Cat3TextSelection06.text = MainGalleryDatabase.Cat3AppPainting06Name;

		// Cat 4
		Cat4TextSelection01.text = MainGalleryDatabase.Cat4AppPainting01Name;
		Cat4TextSelection02.text = MainGalleryDatabase.Cat4AppPainting02Name;
		Cat4TextSelection03.text = MainGalleryDatabase.Cat4AppPainting03Name;
		Cat4TextSelection04.text = MainGalleryDatabase.Cat4AppPainting04Name;
		Cat4TextSelection05.text = MainGalleryDatabase.Cat4AppPainting05Name;
		Cat4TextSelection06.text = MainGalleryDatabase.Cat4AppPainting06Name;
		Cat4TextSelection07.text = MainGalleryDatabase.Cat4AppPainting07Name;
		Cat4TextSelection08.text = MainGalleryDatabase.Cat4AppPainting08Name;
		Cat4TextSelection09.text = MainGalleryDatabase.Cat4AppPainting09Name;
		Cat4TextSelection10.text = MainGalleryDatabase.Cat4AppPainting10Name;
		Cat4TextSelection11.text = MainGalleryDatabase.Cat4AppPainting11Name;
		Cat4TextSelection12.text = MainGalleryDatabase.Cat4AppPainting12Name;
		Cat4TextSelection13.text = MainGalleryDatabase.Cat4AppPainting13Name;
		Cat4TextSelection14.text = MainGalleryDatabase.Cat4AppPainting14Name;
		Cat4TextSelection15.text = MainGalleryDatabase.Cat4AppPainting15Name;
		Cat4TextSelection16.text = MainGalleryDatabase.Cat4AppPainting16Name;

		// Cat 5
		Cat5TextSelection01.text = MainGalleryDatabase.Cat5AppPainting01Name;
		Cat5TextSelection02.text = MainGalleryDatabase.Cat5AppPainting02Name;
		Cat5TextSelection03.text = MainGalleryDatabase.Cat5AppPainting03Name;
		Cat5TextSelection04.text = MainGalleryDatabase.Cat5AppPainting04Name;
		Cat5TextSelection05.text = MainGalleryDatabase.Cat5AppPainting05Name;
		Cat5TextSelection06.text = MainGalleryDatabase.Cat5AppPainting06Name;
		Cat5TextSelection07.text = MainGalleryDatabase.Cat5AppPainting07Name;
		Cat5TextSelection08.text = MainGalleryDatabase.Cat5AppPainting08Name;
		Cat5TextSelection09.text = MainGalleryDatabase.Cat5AppPainting09Name;
		Cat5TextSelection10.text = MainGalleryDatabase.Cat5AppPainting10Name;
		Cat5TextSelection11.text = MainGalleryDatabase.Cat5AppPainting11Name;
		Cat5TextSelection12.text = MainGalleryDatabase.Cat5AppPainting12Name;
		Cat5TextSelection13.text = MainGalleryDatabase.Cat5AppPainting13Name;
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}