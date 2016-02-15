var hasCollided : boolean = false;
var doorLeft: Animator;
var doorRight: Animator;
var doorSound;

function Start(){
    doorSound = gameObject.GetComponent("AudioSource");
}
 
function OnTriggerEnter(c:Collider){

    if(c.gameObject.tag =="Player"){

        doorSound.enabled = true;
  		doorLeft.SetTrigger("OpenDoorLarge");
		doorRight.SetTrigger("OpenDoorLarge");
  	}
}
 
function OnTriggerExit( other : Collider ){

    doorSound.enabled = false;
 	doorLeft.SetTrigger("CloseDoorLarge");
	doorRight.SetTrigger("CloseDoorLarge");

}