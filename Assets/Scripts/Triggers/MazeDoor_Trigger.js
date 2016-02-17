var hasCollided : boolean = false;
var doorLeft: Animator;
var doorRight: Animator;
var doorOpenclip: AudioClip;
var doorSound;

function Start(){
    doorSound = gameObject.GetComponent("AudioSource");
}
 
function OnTriggerEnter(c:Collider){

    if(c.gameObject.tag =="Player"){

        doorSound.PlayOneShot(doorOpenclip, 0.7F);
  		doorLeft.SetTrigger("OpenDoorLarge");
		doorRight.SetTrigger("OpenDoorLarge");
  	}
}
 
function OnTriggerExit( c: Collider ){

    if(c.gameObject.tag =="Player"){

        doorSound.PlayOneShot(doorOpenclip, 0.7F);
        doorLeft.SetTrigger("CloseDoorLarge");
        doorRight.SetTrigger("CloseDoorLarge");
    }
}