#pragma strict

var ball: GameObject;
var newBall: GameObject;

function Update (){
    ball = GameObject.FindGameObjectWithTag("ball");
}

function OnTriggerEnter () {
    Destroy(ball);
    yield WaitForSeconds (0.7);
    Instantiate(newBall);
}

function OnTriggerExit() {
    Destroy(ball);
}