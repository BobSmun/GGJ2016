#pragma strict

var mainDoorLeft: Animator;
var mainDoorRight: Animator;
var secretDoor: Animator;
var secretDoorSound: AudioSource;
var endRace: GameObject;
var endGame: GameObject;
var caveSound: AudioSource;
 
function OnTriggerEnter(c:Collider){

    if(c.gameObject.tag =="Player"){
        
        mainDoorLeft.SetTrigger ("CloseDoorLarge");
        mainDoorRight.SetTrigger ("CloseDoorLarge");
        secretDoor.SetTrigger ("OpenSecretDoor");
        caveSound.enabled = false;
        secretDoorSound.enabled = true;
        endRace.SetActive(false);
        endGame.SetActive(true);

        
    }
 
}
    function OnTriggerExit( other : Collider ){

        secretDoorSound.enabled = false;
        Destroy(this);

    }