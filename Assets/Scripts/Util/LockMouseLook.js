//#pragma strict

var charController = gameObject.GetComponent("FirstPersonController");
var previouslyPaused = !GlobalSwitches.isPaused;

function Update()
{
    if (GlobalSwitches.isPaused != previouslyPaused)
    {
        charController.enabled = !GlobalSwitches.isPaused;
        Cursor.lockState = GlobalSwitches.isPaused ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible = GlobalSwitches.isPaused;

        previouslyPaused = GlobalSwitches.isPaused;
    }
}