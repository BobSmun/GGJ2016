#pragma strict

import UnityEngine.UI;

var achievementScript: AchievementTracker;
 
function OnTriggerEnter(c:Collider){

    if(c.gameObject.tag =="Player"){

        achievementScript.octopusIdol = true;
        Destroy(this);
    }
}