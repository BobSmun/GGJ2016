using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KeyDoor_Trigger : MonoBehaviour {

	public bool HasKey = false;
	public bool HasCollided = false;
	public Text UIObject;

	public GameObject doorLeft;
	public GameObject doorRight;
	private Animator doorLeft_anim;
	private Animator doorRight_anim;

	// Use this for initialization
	void Start () {
		doorLeft_anim = doorLeft.GetComponent<Animator> ();
		doorRight_anim = doorRight.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if(HasKey && HasCollided && Input.GetKey(KeyCode.E)){
			OpenDoor ();
			UIObject.text = "";
			Destroy (this);
		}
	
	}

	void OpenDoor() {
		doorLeft_anim.SetTrigger ("OpenSmallDoor");
		doorRight_anim.SetTrigger ("OpenSmallDoor");
		//Debug.Log ("Triggered");
		//doorRight_anim.SetBool ("Right_SmallDoor", true);
	}

	void OnTriggerEnter(Collider other) {

		HasCollided = true;

		if (HasKey) {	
			
			UIObject.text = "Press E to use the key";

		}
		else if(HasKey == false){
			UIObject.text = "You don't have a key for this door";
		}
		else{
			UIObject.text = "";
		}

	}

	void OnTriggerExit(Collider other) {
		HasCollided = false;
		UIObject.text = "";
	}
}
