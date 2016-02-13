#pragma strict

import UnityEngine.UI;

var hasCollided : boolean = false;
var labelText : String = "";
var prompt : Text;
var poleTop: Animator;

function Start(){
    
}
 
function Update(){

    if (Input.GetKey(KeyCode.E) && hasCollided == true){
           
        CaveControl.pole01Active = true;
        poleTop.SetTrigger("ActivatePole");        
        prompt.text = "";
        Destroy(this);

    }

}

function OnTriggerEnter(c:Collider){

    if(c.gameObject.tag =="Player"){

        hasCollided = true;
        prompt.text = "Press E to activate";
    }


}
 
    function OnTriggerExit( other : Collider ){

        prompt.text = "";
        hasCollided = false;
    }