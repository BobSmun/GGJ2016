#pragma strict

var breakoutUI: GameObject;
var arcadePower: ArcadeOnOff_Trigger;

function OnTriggerEnter (){
    if(arcadePower.arcadeOn){
        breakoutUI.SetActive(true);
    }else{}
}

function OnTriggerExit (){
    
        breakoutUI.SetActive(false);
    
}