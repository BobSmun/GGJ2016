#pragma strict

import UnityEngine.UI;

var endGameUI: GameObject;
var achievementScript: AchievementTracker;
var playerSound: AudioSource;


function OnTriggerEnter(c:Collider){

    if(c.gameObject.tag =="Player"){

        playerSound = c.gameObject.GetComponent(AudioSource);
        playerSound.enabled = false;
        endGameUI.SetActive(true);
        achievementScript.finishGame = true;
        Destroy(this);
    }
}