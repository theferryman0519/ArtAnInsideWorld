using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class GalleryInfoSceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    public Button BackButton;
	public Button Cat1Selection01;
	public Button Cat1Selection02;
	public Button Cat1Selection03;
	public Button Cat1Selection04;
	public Button Cat1Selection05;
	public Button Cat1Selection06;
	public Button Cat2Selection01;
	public Button Cat2Selection02;
	public Button Cat2Selection03;
	public Button Cat2Selection04;
	public Button Cat2Selection05;
	public Button Cat2Selection06;
	public Button Cat2Selection07;
	public Button Cat2Selection08;
	public Button Cat2Selection09;
	public Button Cat3Selection01;
	public Button Cat3Selection02;
	public Button Cat3Selection03;
	public Button Cat3Selection04;
	public Button Cat3Selection05;
	public Button Cat3Selection06;
	public Button Cat4Selection01;
	public Button Cat4Selection02;
	public Button Cat4Selection03;
	public Button Cat4Selection04;
	public Button Cat4Selection05;
	public Button Cat4Selection06;
	public Button Cat4Selection07;
	public Button Cat4Selection08;
	public Button Cat4Selection09;
	public Button Cat4Selection10;
	public Button Cat4Selection11;
	public Button Cat4Selection12;
	public Button Cat4Selection13;
	public Button Cat4Selection14;
	public Button Cat4Selection15;
	public Button Cat4Selection16;
	public Button Cat5Selection01;
	public Button Cat5Selection02;
	public Button Cat5Selection03;
	public Button Cat5Selection04;
	public Button Cat5Selection05;
	public Button Cat5Selection06;
	public Button Cat5Selection07;
	public Button Cat5Selection08;
	public Button Cat5Selection09;
	public Button Cat5Selection10;
	public Button Cat5Selection11;
	public Button Cat5Selection12;
	public Button Cat5Selection13;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int ArtworkSelectionButton;
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Changing
    public SceneChange GLSScene10Loading;
	public SceneChange GLSScene14Loading;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		ArtworkSelectionButton = 0;

        // Back Button
		Button BackButtonClick = BackButton.GetComponent<Button>();
		BackButtonClick.onClick.AddListener(BackButtonClicking);

		// ********** CAT 1 **********
		// Cat1Selection01 Button
		Button Cat1Selection01Click = Cat1Selection01.GetComponent<Button>();
		Cat1Selection01Click.onClick.AddListener(Cat1Selection01Clicking);

		// Cat1Selection02 Button
		Button Cat1Selection02Click = Cat1Selection02.GetComponent<Button>();
		Cat1Selection02Click.onClick.AddListener(Cat1Selection02Clicking);

		// Cat1Selection03 Button
		Button Cat1Selection03Click = Cat1Selection03.GetComponent<Button>();
		Cat1Selection03Click.onClick.AddListener(Cat1Selection03Clicking);

		// Cat1Selection04 Button
		Button Cat1Selection04Click = Cat1Selection04.GetComponent<Button>();
		Cat1Selection04Click.onClick.AddListener(Cat1Selection04Clicking);

		// Cat1Selection05 Button
		Button Cat1Selection05Click = Cat1Selection05.GetComponent<Button>();
		Cat1Selection05Click.onClick.AddListener(Cat1Selection05Clicking);

		// Cat1Selection06 Button
		Button Cat1Selection06Click = Cat1Selection06.GetComponent<Button>();
		Cat1Selection06Click.onClick.AddListener(Cat1Selection06Clicking);

		// ********** CAT 2 **********
		// Cat2Selection01 Button
		Button Cat2Selection01Click = Cat2Selection01.GetComponent<Button>();
		Cat2Selection01Click.onClick.AddListener(Cat2Selection01Clicking);

		// Cat2Selection02 Button
		Button Cat2Selection02Click = Cat2Selection02.GetComponent<Button>();
		Cat2Selection02Click.onClick.AddListener(Cat2Selection02Clicking);

		// Cat2Selection03 Button
		Button Cat2Selection03Click = Cat2Selection03.GetComponent<Button>();
		Cat2Selection03Click.onClick.AddListener(Cat2Selection03Clicking);

		// Cat2Selection04 Button
		Button Cat2Selection04Click = Cat2Selection04.GetComponent<Button>();
		Cat2Selection04Click.onClick.AddListener(Cat2Selection04Clicking);

		// Cat2Selection05 Button
		Button Cat2Selection05Click = Cat2Selection05.GetComponent<Button>();
		Cat2Selection05Click.onClick.AddListener(Cat2Selection05Clicking);

		// Cat2Selection06 Button
		Button Cat2Selection06Click = Cat2Selection06.GetComponent<Button>();
		Cat2Selection06Click.onClick.AddListener(Cat2Selection06Clicking);

		// Cat2Selection07 Button
		Button Cat2Selection07Click = Cat2Selection07.GetComponent<Button>();
		Cat2Selection07Click.onClick.AddListener(Cat2Selection07Clicking);

		// Cat2Selection08 Button
		Button Cat2Selection08Click = Cat2Selection08.GetComponent<Button>();
		Cat2Selection08Click.onClick.AddListener(Cat2Selection08Clicking);

		// Cat2Selection09 Button
		Button Cat2Selection09Click = Cat2Selection09.GetComponent<Button>();
		Cat2Selection09Click.onClick.AddListener(Cat2Selection09Clicking);

		// ********** CAT 3 **********
		// Cat3Selection01 Button
		Button Cat3Selection01Click = Cat3Selection01.GetComponent<Button>();
		Cat3Selection01Click.onClick.AddListener(Cat3Selection01Clicking);

		// Cat3Selection02 Button
		Button Cat3Selection02Click = Cat3Selection02.GetComponent<Button>();
		Cat3Selection02Click.onClick.AddListener(Cat3Selection02Clicking);

		// Cat3Selection03 Button
		Button Cat3Selection03Click = Cat3Selection03.GetComponent<Button>();
		Cat3Selection03Click.onClick.AddListener(Cat3Selection03Clicking);

		// Cat3Selection04 Button
		Button Cat3Selection04Click = Cat3Selection04.GetComponent<Button>();
		Cat3Selection04Click.onClick.AddListener(Cat3Selection04Clicking);

		// Cat3Selection05 Button
		Button Cat3Selection05Click = Cat3Selection05.GetComponent<Button>();
		Cat3Selection05Click.onClick.AddListener(Cat3Selection05Clicking);

		// Cat3Selection06 Button
		Button Cat3Selection06Click = Cat3Selection06.GetComponent<Button>();
		Cat3Selection06Click.onClick.AddListener(Cat3Selection06Clicking);

		// ********** CAT 4 **********
		// Cat4Selection01 Button
		Button Cat4Selection01Click = Cat4Selection01.GetComponent<Button>();
		Cat4Selection01Click.onClick.AddListener(Cat4Selection01Clicking);

		// Cat4Selection02 Button
		Button Cat4Selection02Click = Cat4Selection02.GetComponent<Button>();
		Cat4Selection02Click.onClick.AddListener(Cat4Selection02Clicking);

		// Cat4Selection03 Button
		Button Cat4Selection03Click = Cat4Selection03.GetComponent<Button>();
		Cat4Selection03Click.onClick.AddListener(Cat4Selection03Clicking);

		// Cat4Selection04 Button
		Button Cat4Selection04Click = Cat4Selection04.GetComponent<Button>();
		Cat4Selection04Click.onClick.AddListener(Cat4Selection04Clicking);

		// Cat4Selection05 Button
		Button Cat4Selection05Click = Cat4Selection05.GetComponent<Button>();
		Cat4Selection05Click.onClick.AddListener(Cat4Selection05Clicking);

		// Cat4Selection06 Button
		Button Cat4Selection06Click = Cat4Selection06.GetComponent<Button>();
		Cat4Selection06Click.onClick.AddListener(Cat4Selection06Clicking);

		// Cat4Selection07 Button
		Button Cat4Selection07Click = Cat4Selection07.GetComponent<Button>();
		Cat4Selection07Click.onClick.AddListener(Cat4Selection07Clicking);

		// Cat4Selection08 Button
		Button Cat4Selection08Click = Cat4Selection08.GetComponent<Button>();
		Cat4Selection08Click.onClick.AddListener(Cat4Selection08Clicking);

		// Cat4Selection09 Button
		Button Cat4Selection09Click = Cat4Selection09.GetComponent<Button>();
		Cat4Selection09Click.onClick.AddListener(Cat4Selection09Clicking);

		// Cat4Selection10 Button
		Button Cat4Selection10Click = Cat4Selection10.GetComponent<Button>();
		Cat4Selection10Click.onClick.AddListener(Cat4Selection10Clicking);

		// Cat4Selection11 Button
		Button Cat4Selection11Click = Cat4Selection11.GetComponent<Button>();
		Cat4Selection11Click.onClick.AddListener(Cat4Selection11Clicking);

		// Cat4Selection12 Button
		Button Cat4Selection12Click = Cat4Selection12.GetComponent<Button>();
		Cat4Selection12Click.onClick.AddListener(Cat4Selection12Clicking);

		// Cat4Selection13 Button
		Button Cat4Selection13Click = Cat4Selection13.GetComponent<Button>();
		Cat4Selection13Click.onClick.AddListener(Cat4Selection13Clicking);

		// Cat4Selection14 Button
		Button Cat4Selection14Click = Cat4Selection14.GetComponent<Button>();
		Cat4Selection14Click.onClick.AddListener(Cat4Selection14Clicking);

		// Cat4Selection15 Button
		Button Cat4Selection15Click = Cat4Selection15.GetComponent<Button>();
		Cat4Selection15Click.onClick.AddListener(Cat4Selection15Clicking);

		// Cat4Selection16 Button
		Button Cat4Selection16Click = Cat4Selection16.GetComponent<Button>();
		Cat4Selection16Click.onClick.AddListener(Cat4Selection16Clicking);

		// ********** CAT 5 **********
		// Cat5Selection01 Button
		Button Cat5Selection01Click = Cat5Selection01.GetComponent<Button>();
		Cat5Selection01Click.onClick.AddListener(Cat5Selection01Clicking);

		// Cat5Selection02 Button
		Button Cat5Selection02Click = Cat5Selection02.GetComponent<Button>();
		Cat5Selection02Click.onClick.AddListener(Cat5Selection02Clicking);

		// Cat5Selection03 Button
		Button Cat5Selection03Click = Cat5Selection03.GetComponent<Button>();
		Cat5Selection03Click.onClick.AddListener(Cat5Selection03Clicking);

		// Cat5Selection04 Button
		Button Cat5Selection04Click = Cat5Selection04.GetComponent<Button>();
		Cat5Selection04Click.onClick.AddListener(Cat5Selection04Clicking);

		// Cat5Selection05 Button
		Button Cat5Selection05Click = Cat5Selection05.GetComponent<Button>();
		Cat5Selection05Click.onClick.AddListener(Cat5Selection05Clicking);

		// Cat5Selection06 Button
		Button Cat5Selection06Click = Cat5Selection06.GetComponent<Button>();
		Cat5Selection06Click.onClick.AddListener(Cat5Selection06Clicking);

		// Cat5Selection07 Button
		Button Cat5Selection07Click = Cat5Selection07.GetComponent<Button>();
		Cat5Selection07Click.onClick.AddListener(Cat5Selection07Clicking);

		// Cat5Selection08 Button
		Button Cat5Selection08Click = Cat5Selection08.GetComponent<Button>();
		Cat5Selection08Click.onClick.AddListener(Cat5Selection08Clicking);

		// Cat5Selection09 Button
		Button Cat5Selection09Click = Cat5Selection09.GetComponent<Button>();
		Cat5Selection09Click.onClick.AddListener(Cat5Selection09Clicking);

		// Cat5Selection10 Button
		Button Cat5Selection10Click = Cat5Selection10.GetComponent<Button>();
		Cat5Selection10Click.onClick.AddListener(Cat5Selection10Clicking);

		// Cat5Selection11 Button
		Button Cat5Selection11Click = Cat5Selection11.GetComponent<Button>();
		Cat5Selection11Click.onClick.AddListener(Cat5Selection11Clicking);

		// Cat5Selection12 Button
		Button Cat5Selection12Click = Cat5Selection12.GetComponent<Button>();
		Cat5Selection12Click.onClick.AddListener(Cat5Selection12Clicking);

		// Cat5Selection13 Button
		Button Cat5Selection13Click = Cat5Selection13.GetComponent<Button>();
		Cat5Selection13Click.onClick.AddListener(Cat5Selection13Clicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    public void BackButtonClicking() {
        GalleryMainSceneButtons.GalleryMainShowingInt = 0;
        GalleryMainSceneButtons.GalleryMainClickInt = 0;
        GLSScene10Loading.GLSScene10Load();
    }

	// Cat 1
	public void Cat1Selection01Clicking() {
		ArtworkSelectionButton = 1;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat1Selection02Clicking() {
		ArtworkSelectionButton = 2;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat1Selection03Clicking() {
		ArtworkSelectionButton = 3;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat1Selection04Clicking() {
		ArtworkSelectionButton = 4;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat1Selection05Clicking() {
		ArtworkSelectionButton = 5;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat1Selection06Clicking() {
		ArtworkSelectionButton = 6;
		GLSScene14Loading.GLSScene14Load();
	}

	// Cat 2
	public void Cat2Selection01Clicking() {
		ArtworkSelectionButton = 7;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat2Selection02Clicking() {
		ArtworkSelectionButton = 8;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat2Selection03Clicking() {
		ArtworkSelectionButton = 9;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat2Selection04Clicking() {
		ArtworkSelectionButton = 10;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat2Selection05Clicking() {
		ArtworkSelectionButton = 11;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat2Selection06Clicking() {
		ArtworkSelectionButton = 12;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat2Selection07Clicking() {
		ArtworkSelectionButton = 13;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat2Selection08Clicking() {
		ArtworkSelectionButton = 14;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat2Selection09Clicking() {
		ArtworkSelectionButton = 15;
		GLSScene14Loading.GLSScene14Load();
	}

	// Cat 3
	public void Cat3Selection01Clicking() {
		ArtworkSelectionButton = 16;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat3Selection02Clicking() {
		ArtworkSelectionButton = 17;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat3Selection03Clicking() {
		ArtworkSelectionButton = 18;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat3Selection04Clicking() {
		ArtworkSelectionButton = 19;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat3Selection05Clicking() {
		ArtworkSelectionButton = 20;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat3Selection06Clicking() {
		ArtworkSelectionButton = 21;
		GLSScene14Loading.GLSScene14Load();
	}

	// Cat 4
	public void Cat4Selection01Clicking() {
		ArtworkSelectionButton = 22;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat4Selection02Clicking() {
		ArtworkSelectionButton = 23;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat4Selection03Clicking() {
		ArtworkSelectionButton = 24;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat4Selection04Clicking() {
		ArtworkSelectionButton = 25;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat4Selection05Clicking() {
		ArtworkSelectionButton = 26;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat4Selection06Clicking() {
		ArtworkSelectionButton = 27;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat4Selection07Clicking() {
		ArtworkSelectionButton = 28;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat4Selection08Clicking() {
		ArtworkSelectionButton = 29;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat4Selection09Clicking() {
		ArtworkSelectionButton = 30;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat4Selection10Clicking() {
		ArtworkSelectionButton = 31;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat4Selection11Clicking() {
		ArtworkSelectionButton = 32;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat4Selection12Clicking() {
		ArtworkSelectionButton = 33;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat4Selection13Clicking() {
		ArtworkSelectionButton = 34;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat4Selection14Clicking() {
		ArtworkSelectionButton = 35;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat4Selection15Clicking() {
		ArtworkSelectionButton = 36;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat4Selection16Clicking() {
		ArtworkSelectionButton = 37;
		GLSScene14Loading.GLSScene14Load();
	}

	// Cat 5
	public void Cat5Selection01Clicking() {
		ArtworkSelectionButton = 38;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat5Selection02Clicking() {
		ArtworkSelectionButton = 39;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat5Selection03Clicking() {
		ArtworkSelectionButton = 40;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat5Selection04Clicking() {
		ArtworkSelectionButton = 41;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat5Selection05Clicking() {
		ArtworkSelectionButton = 42;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat5Selection06Clicking() {
		ArtworkSelectionButton = 43;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat5Selection07Clicking() {
		ArtworkSelectionButton = 44;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat5Selection08Clicking() {
		ArtworkSelectionButton = 45;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat5Selection09Clicking() {
		ArtworkSelectionButton = 46;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat5Selection10Clicking() {
		ArtworkSelectionButton = 47;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat5Selection11Clicking() {
		ArtworkSelectionButton = 48;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat5Selection12Clicking() {
		ArtworkSelectionButton = 49;
		GLSScene14Loading.GLSScene14Load();
	}

	public void Cat5Selection13Clicking() {
		ArtworkSelectionButton = 50;
		GLSScene14Loading.GLSScene14Load();
	}

// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}