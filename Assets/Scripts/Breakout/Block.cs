using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	void OnTriggerEnter () {
        BreakoutGame.SP.HitBlock();
		StartCoroutine (deathTimer());
        //Destroy(gameObject);
	}


	IEnumerator deathTimer(){
		int timer = 0;
		while (timer < 2) {
			timer += 1;
			yield return null;
		}
		Destroy (gameObject);
	}

}
