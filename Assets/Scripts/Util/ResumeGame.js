#pragma strict

var pauseMenu: GameObject;
var Timer: GameObject;

public function ResumeFromPause () {
		
    GlobalSwitches.isPaused = false;
    Timer.SetActive(true);
    Time.timeScale = 1.0;
    pauseMenu.SetActive(false);
}

