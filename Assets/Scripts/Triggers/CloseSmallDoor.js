#pragma strict

var smallDoorLeft: Animator;
var smallDoorRight: Animator;
 
function OnTriggerEnter(c:Collider){

    if(c.gameObject.tag =="Player"){
        
        smallDoorLeft.SetTrigger ("CloseSmallDoor");
        smallDoorRight.SetTrigger ("CloseSmallDoor");
        Destroy(this);
    }
}