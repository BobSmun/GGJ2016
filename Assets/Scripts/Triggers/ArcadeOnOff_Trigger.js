#pragma strict

import UnityEngine.UI;

var hasCollided: boolean = false;
var arcadeDoor: Animator;
var arcadeDoorSound: AudioSource;
var arcadeSwitch: Animator;
var arcadeOn: boolean = true;
var breakOut: GameObject;
var balls: GameObject;
var newBreakOut: GameObject;
var prompt: Text;
var arcadeLight: GameObject;
var arcadeScreen: GameObject;
var powerOnSound: AudioClip;
var powerOffSound: AudioClip;

private var arcadeSound: AudioSource;

var achievementScript: AchievementTracker;
var achievementDone: boolean = false;

function Start(){
    arcadeSound = gameObject.GetComponent(AudioSource);
    balls = GameObject.FindGameObjectWithTag("ball");
}

function Update(){

    if (hasCollided && arcadeOn){ 
        
        prompt.text = "Press E to turn off";
        
        if(Input.GetKeyDown(KeyCode.E)) {  
            arcadeSwitch.SetBool ("ArcadeOn", false);
            arcadeLight.SetActive(false);
            arcadeScreen.SetActive(false);
            arcadeSound.PlayOneShot(powerOffSound,0.5F);
            arcadeDoorSound.enabled = true;
            arcadeOn = false;   
            arcadeDoor.SetTrigger("OpenArcadeDoor");
            Destroy(breakOut);
            Destroy(balls);
            if(achievementDone == false){
                achievementScript.playArcade = true;
            }
            achievementDone = true;
        }
    }
    else if (hasCollided && arcadeOn == false){ 
        
        prompt.text = "Press E to turn on";
        
        if(Input.GetKeyDown(KeyCode.E)) {  
            arcadeSwitch.SetBool ("ArcadeOn", true);
            arcadeLight.SetActive(true);
            arcadeScreen.SetActive(true);
            Instantiate(newBreakOut);
            arcadeSound.PlayOneShot(powerOnSound,0.5F);
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