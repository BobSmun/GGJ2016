#pragma strict

var secretDoor: Animator;
 
function OnTriggerEnter(c:Collider){

    if(c.gameObject.tag =="Player"){
        
        secretDoor.SetTrigger ("CloseSecretDoor");
        Destroy(this);
    }
}