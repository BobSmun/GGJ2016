var octopusDoor: Animator;
var doorSound: AudioSource;
 
function OnTriggerEnter(c:Collider){

    if(c.gameObject.tag =="Player"){

        octopusDoor.SetTrigger("OctopusOpen"); 
        doorSound.enabled = true;
    }
}
 
    function OnTriggerExit( other : Collider ){

        Destroy(this);

    }