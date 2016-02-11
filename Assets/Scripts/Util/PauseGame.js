﻿#pragma strict

var pauseMenu: GameObject;
var timer: GameObject;

function Update () {

    if (Input.GetKeyDown(KeyCode.Escape)) {

        if (Time.timeScale == 1.0){
            GlobalSwitches.isPaused = true;
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
            Cursor.visible = true;
        }
        else
        {
            GlobalSwitches.isPaused = false;
            Time.timeScale = 1.0;
            timer.SetActive(true);
            pauseMenu.SetActive(false);
            Cursor.visible = false;
        }		   
						
	}
	   
}