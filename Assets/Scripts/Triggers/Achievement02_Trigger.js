#pragma strict

import UnityEngine.UI;

var achievementScript: AchievementTracker;
 
function OnTriggerEnter(c:Collider){

    if(c.gameObject.tag =="Player"){

        achievementScript.badSecret = true;
        Destroy(this);
    }
}