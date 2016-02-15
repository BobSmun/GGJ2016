#pragma strict

import UnityEngine.UI;

var hasCollided : boolean = false;
var labelText : String = "";
var UIObject : Text;
var timer: CanvasGroup;
var doorLeft: Animator;
var doorRight: Animator;
var doorLeftSound: AudioSource;
var doorRightSound: AudioSource;

function Start(){
    
}
 
function Update(){

	if (Input.GetKey(KeyCode.E) && hasCollided == true){
	    timer.alpha = 0;	    
	    doorLeft.SetTrigger("OpenDoorLarge");	    
	    doorRight.SetTrigger("OpenDoorLarge");
	    doorLeftSound.enabled = true;
	    doorRightSound.enabled = true;
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