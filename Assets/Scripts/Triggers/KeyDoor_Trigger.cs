using UnityEngine;
using System.Collections;

public class KeyDoor_Trigger : MonoBehaviour {

	public bool HasKey = false;

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
	void FixedUpdate () {
	
	}

	void OpenDoor() {
		doorLeft_anim.SetTrigger ("OpenSmallDoor");
		doorRight_anim.SetTrigger ("OpenSmallDoor");
		//Debug.Log ("Triggered");
		//doorRight_anim.SetBool ("Right_SmallDoor", true);
	}

	void OnTriggerEnter(Collider other) {
		if (HasKey) {
			OpenDoor ();
		}

	}
}
