#pragma strict

public class SmallDoor_Trigger {

	var hasCollided: boolean = false;
	var hasKey: boolean = false;
	var labelText: String = "";
	//var promptKey: GameObject;
	//var promptNoKey: GameObject;
	var timer: CanvasGroup;
	var doorLeft: Animator;
	var doorRight: Animator;
	 
	function Update(){

		if (Input.GetKey(KeyCode.E) && hasCollided == true && hasKey == true){

	  		//timer.alpha = 0;
	  		doorLeft.SetTrigger("OpenSmallDoor");
			doorRight.SetTrigger("OpenSmallDoor");
			//promptKey.SetActive(false);
	 		//promptNoKey.SetActive(false);
			//Destroy(this);

	  	}

	}

	function OnTriggerEnter(c:Collider){

	  	if(c.gameObject.tag =="Player" && hasKey){

	  		hasCollided = true;
	  		//promptKey.SetActive(true);
	  	}
	  	else if (c.gameObject.tag =="Player" && hasKey == false){

			hasCollided = true;
			//promptNoKey.SetActive(true);
	  	}

	}
	 
	function OnTriggerExit( other : Collider ){

	 	//promptKey.SetActive(false);
	 	//promptNoKey.SetActive(false);
	 	hasCollided = false;
	}
}