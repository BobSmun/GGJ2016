using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Breakout_GameStart : MonoBehaviour {

	public GameObject breakoutMain;
	private BreakoutGame gameScript;

	// Use this for initialization
	void Start () {
		gameScript = breakoutMain.GetComponent<BreakoutGame>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	void OnTriggerEnter(Collider other) {
		gameScript.StartGame ();
	}
}
