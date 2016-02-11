using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Key_Trigger : MonoBehaviour {

	public GameObject doorTrigger;
	public GameObject key;
	public AudioSource KeyAudio;

	private KeyDoor_Trigger otherScript;
	private MeshRenderer keyRender;

	// Use this for initialization
	void Start () {		

		otherScript = doorTrigger.GetComponent<KeyDoor_Trigger> ();
		keyRender = key.GetComponent<MeshRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {

		otherScript.HasKey = true;
		keyRender.enabled = false;
		KeyAudio.enabled = true;

	}
}
