//#pragma strict

var charController = gameObject.GetComponent("FirstPersonController");

function Update () {    

    if(GlobalSwitches.isPaused == true){
        charController.enabled = false;
    }
    else{
        charController.enabled = true;
    }
}