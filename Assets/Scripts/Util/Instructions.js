#pragma strict

var pauseMenu: GameObject;

function Start () {  

    GlobalSwitches.isPaused = true;
    Time.timeScale = 0;
    pauseMenu.SetActive(true);      
						
}
function Update(){
    Cursor.visible = true; 
}