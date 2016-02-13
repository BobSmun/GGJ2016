#pragma strict

var mainDoorLeft: Animator;
var mainDoorRight: Animator;
var secretDoor: Animator;
var endRace: GameObject;
var endGame: GameObject;
 
function OnTriggerEnter(c:Collider){

    if(c.gameObject.tag =="Player"){
        
        mainDoorLeft.SetTrigger ("CloseDoorLarge");
        mainDoorRight.SetTrigger ("CloseDoorLarge");
        secretDoor.SetTrigger ("OpenSecretDoor");
        endRace.SetActive(false);
        endGame.SetActive(true);

        Destroy(this);
    }
}