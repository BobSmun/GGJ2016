#pragma strict

import UnityEngine.UI;

var hasCollided : boolean = false;
var labelText : String = "";
var UIObject : Text;
var timer: CanvasGroup;
var doorLeft: Animator;
var doorRight: Animator;

var achievementScript: AchievementTracker;

function Start(){
    
}
 
function Update(){

	if (Input.GetKey(KeyCode.E) && hasCollided == true){

	    achievementScript.badSecret = true;
  		timer.alpha = 0;
  		doorLeft.SetTrigger("OpenDoorLarge");
		doorRight.SetTrigger("OpenDoorLarge");
		UIObject.text = "";
		Destroy(this);

  	}

}

function OnTriggerEnter(c:Collider){

  	if(c.gameObject.tag =="Player"){

  	    hasCollided = true;
  	    UIObject.text = "Press E to open the door";
  	}


}
 
function OnTriggerExit( other : Collider ){

    UIObject.text = "";
 	hasCollided = false;
}