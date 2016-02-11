using UnityEngine;
using System.Collections;

<<<<<<< HEAD
[RequireComponent(typeof(AudioSource))]
=======
>>>>>>> remotes/origin/master
public class Key_Trigger : MonoBehaviour {

	public GameObject doorTrigger;
	public GameObject key;
<<<<<<< HEAD
	public AudioSource KeyAudio;
=======
>>>>>>> remotes/origin/master

	private KeyDoor_Trigger otherScript;
	private MeshRenderer keyRender;

	// Use this for initialization
<<<<<<< HEAD
	void Start () {		

		otherScript = doorTrigger.GetComponent<KeyDoor_Trigger> ();
		keyRender = key.GetComponent<MeshRenderer> ();

=======
	void Start () {
		otherScript = doorTrigger.GetComponent<KeyDoor_Trigger> ();
		keyRender = key.GetComponent<MeshRenderer> ();
>>>>>>> remotes/origin/master
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {

		otherScript.HasKey = true;
<<<<<<< HEAD
		keyRender.enabled = false;
		KeyAudio.enabled = true;
=======

		keyRender.enabled = false;
>>>>>>> remotes/origin/master

	}
}
