#pragma strict

import UnityEngine.UI;

var hasCollided: boolean = false;
var arcadeDoor: Animator;
var arcadeDoorSound: AudioSource;
var arcadeSwitch: Animator;
var arcadeOn: boolean = true;
var prompt: Text;
var arcadeLight: GameObject;
private var arcadeSound: AudioSource;

var achievementScript: AchievementTracker;


function Start(){
    arcadeSound = gameObject.GetComponent(AudioSource);
}

function Update(){

    if (hasCollided && arcadeOn){ 
        
        prompt.text = "Press E to turn off";
        
        if(Input.GetKeyDown(KeyCode.E)) {  
            arcadeSwitch.SetBool ("ArcadeOn", false);
            arcadeLight.SetActive(false);
            arcadeDoorSound.enabled = true;
            arcadeSound.enabled = true;
            arcadeOn = false;   
            arcadeDoor.SetTrigger("OpenArcadeDoor");
            achievementScript.playArcade = true;
        }
    }
    else if (hasCollided && arcadeOn == false){ 
        
        prompt.text = "Press E to turn on";
        
        if(Input.GetKeyDown(KeyCode.E)) {  
            arcadeSwitch.SetBool ("ArcadeOn", true);
            arcadeOn = true;
        }
    }
}

function OnTriggerEnter(c:Collider){
    if(c.gameObject.tag =="Player"){
        hasCollided = true;
    }
}
function OnTriggerExit( other : Collider ){
        prompt.text = "";
        hasCollided = false;
}