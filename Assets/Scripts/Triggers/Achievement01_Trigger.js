#pragma strict

import UnityEngine.UI;

var achievementScript: AchievementTracker;
var mainDoorTrigger: GameObject;
 
function OnTriggerEnter(c:Collider){

    if(c.gameObject.tag =="Player"){

        achievementScript.firstRun = true;
        mainDoorTrigger.SetActive(true);
        Destroy(this);
    }
}