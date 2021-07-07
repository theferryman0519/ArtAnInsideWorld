using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class ArtworkOrbsCat4 : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Artwork 01
	public Renderer Orbs01Orb1;
    public Renderer Orbs01Orb2;
    public Renderer Orbs01Orb3;
    public Renderer Orbs01Orb4;
    public Renderer Orbs01Orb5;

	// Text
	public Text ArtworkDescriptionText;
	
// --------------- PRIVATE VARIABLES ---------------
	private Ray ray;
    private RaycastHit hit;
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Enable Objects
	public Cat4ARSceneEnable EnableArtworkFeatureShow;
	
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
		Cat4Artwork01Orb1Click();
		Cat4Artwork01Orb2Click();
		Cat4Artwork01Orb3Click();
		Cat4Artwork01Orb4Click();
		Cat4Artwork01Orb5Click();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ORB CLICKING FUNCTION ---------------
	// Cat 4 Artwork 01
	public void Cat4Artwork01Orb1Click() {
		if (Orbs01Orb1.enabled == true) {
			if (Input.GetMouseButtonDown(0)) {
				int MainObjectLayerMask = LayerMask.GetMask("Orbs");
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);

				if (Physics.Raycast(ray, out hit, Mathf.Infinity, MainObjectLayerMask)) {
					if (hit.collider.name.Contains("Orbs01Orb1")) {
						if (Orbs01Orb1.enabled == true) {
							EnableArtworkFeatureShow.EnableArtworkFeature();
							ArtworkDescriptionText.text = MainGalleryDatabase.Cat4AppPainting01ARPieceDescription1;
						}

						if (Orbs01Orb1.enabled == false) {
							
						}
					}
				}
			}
		}
	}

	public void Cat4Artwork01Orb2Click() {
		if (Orbs01Orb2.enabled == true) {
			if (Input.GetMouseButtonDown(0)) {
				int MainObjectLayerMask = LayerMask.GetMask("Orbs");
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);

				if (Physics.Raycast(ray, out hit, Mathf.Infinity, MainObjectLayerMask)) {
					if (hit.collider.name.Contains("Orbs01Orb2")) {
						if (Orbs01Orb2.enabled == true) {
							EnableArtworkFeatureShow.EnableArtworkFeature();
							ArtworkDescriptionText.text = MainGalleryDatabase.Cat4AppPainting01ARPieceDescription2;
						}

						if (Orbs01Orb2.enabled == false) {
							
						}
					}
				}
			}
		}
	}

	public void Cat4Artwork01Orb3Click() {
		if (Orbs01Orb3.enabled == true) {
			if (Input.GetMouseButtonDown(0)) {
				int MainObjectLayerMask = LayerMask.GetMask("Orbs");
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);

				if (Physics.Raycast(ray, out hit, Mathf.Infinity, MainObjectLayerMask)) {
					if (hit.collider.name.Contains("Orbs01Orb3")) {
						if (Orbs01Orb3.enabled == true) {
							EnableArtworkFeatureShow.EnableArtworkFeature();
							ArtworkDescriptionText.text = MainGalleryDatabase.Cat4AppPainting01ARPieceDescription3;
						}

						if (Orbs01Orb3.enabled == false) {
							
						}
					}
				}
			}
		}
	}

	public void Cat4Artwork01Orb4Click() {
		if (Orbs01Orb4.enabled == true) {
			if (Input.GetMouseButtonDown(0)) {
				int MainObjectLayerMask = LayerMask.GetMask("Orbs");
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);

				if (Physics.Raycast(ray, out hit, Mathf.Infinity, MainObjectLayerMask)) {
					if (hit.collider.name.Contains("Orbs01Orb4")) {
						if (Orbs01Orb4.enabled == true) {
							EnableArtworkFeatureShow.EnableArtworkFeature();
							ArtworkDescriptionText.text = MainGalleryDatabase.Cat4AppPainting01ARPieceDescription4;
						}

						if (Orbs01Orb4.enabled == false) {
							
						}
					}
				}
			}
		}
	}

	public void Cat4Artwork01Orb5Click() {
		if (Orbs01Orb5.enabled == true) {
			if (Input.GetMouseButtonDown(0)) {
				int MainObjectLayerMask = LayerMask.GetMask("Orbs");
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);

				if (Physics.Raycast(ray, out hit, Mathf.Infinity, MainObjectLayerMask)) {
					if (hit.collider.name.Contains("Orbs01Orb5")) {
						if (Orbs01Orb5.enabled == true) {
							EnableArtworkFeatureShow.EnableArtworkFeature();
							ArtworkDescriptionText.text = MainGalleryDatabase.Cat4AppPainting01ARPieceDescription5;
						}

						if (Orbs01Orb5.enabled == false) {
							
						}
					}
				}
			}
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}