var hasCollided : boolean = false;
var doorLeft: Animator;
var doorRight: Animator;
 
function OnTriggerEnter(c:Collider){

  	if(c.gameObject.tag =="Player"){

  		doorLeft.SetTrigger("OpenDoorLarge");
		doorRight.SetTrigger("OpenDoorLarge");
  	}
}
 
function OnTriggerExit( other : Collider ){

 	doorLeft.SetTrigger("CloseDoorLarge");
	doorRight.SetTrigger("CloseDoorLarge");

}