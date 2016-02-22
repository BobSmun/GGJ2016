#pragma strict

import UnityEngine.UI;

var achievementScript: AchievementTracker;
var timer: GameObject;
var mainDoorLeft: Animator;
var mainDoorRight: Animator;
var doorSound: AudioSource;
var doorClip: AudioClip;
 
function OnTriggerEnter(c:Collider){

    if(c.gameObject.tag =="Player"){

        timer.SetActive(false);
        mainDoorLeft.SetTrigger ("CloseDoorLarge");
        mainDoorRight.SetTrigger ("CloseDoorLarge");
        doorSound.PlayOneShot(doorClip,0.7f);
        achievementScript.badSecret = true;
        Destroy(this);
    }
}