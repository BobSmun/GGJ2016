#pragma strict

import UnityEngine.UI;

var endGameUI: GameObject;
var achievementScript: AchievementTracker;

function OnTriggerEnter(c:Collider){

    if(c.gameObject.tag =="Player"){
        
        endGameUI.SetActive(true);
        achievementScript.finishGame = true;
    }
}