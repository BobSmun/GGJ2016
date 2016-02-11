var octopusDoor: Animator;
 
function OnTriggerEnter(c:Collider){

    if(c.gameObject.tag =="Player"){

        octopusDoor.SetTrigger("OctopusOpen");        
    }
}
 
    function OnTriggerExit( other : Collider ){

        Destroy(this);

    }