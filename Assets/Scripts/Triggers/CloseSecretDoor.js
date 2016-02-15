#pragma strict

var secretDoor: Animator;
var secretDoorSound: AudioSource;
 
function OnTriggerEnter(c:Collider){

    if(c.gameObject.tag =="Player"){
        
        secretDoor.SetTrigger ("CloseSecretDoor");
        secretDoorSound.enabled = true;
        Destroy(this);
    }
}