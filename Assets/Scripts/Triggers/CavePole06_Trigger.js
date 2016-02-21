#pragma strict

import UnityEngine.UI;

var hasCollided : boolean = false;
var labelText : String = "";
var prompt : Text;
var poleTop: Animator;
var poleSound: AudioSource;
var openClip: AudioClip;
var errorClip: AudioClip;

function Start(){
    
}
 
function Update(){

    if (Input.GetKey(KeyCode.E) && hasCollided == true){
           
        if(CaveControl.pole05Active){
            CaveControl.pole06Active = true;
            poleSound.PlayOneShot(openClip,0.3F);
            poleTop.SetTrigger("ActivatePole");        
            prompt.text = "";
            Destroy(this);
        }
        else{
            poleSound.PlayOneShot(errorClip,0.3F);
        }

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