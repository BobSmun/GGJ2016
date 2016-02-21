#pragma strict

var caveDoor: Animator;
var caveLines: Animator;
var caveLines02: Animator;
var arcadeDoor: Animator;
var achievementScript: AchievementTracker;
var caveSound01: AudioSource;
var caveSound02: AudioSource;

public static var pole01Active: boolean = false;
public static var pole02Active: boolean = false;
public static var pole03Active: boolean = false;
public static var pole04Active: boolean = false;
public static var pole05Active: boolean = false;
public static var pole06Active: boolean = false;
public static var pole07Active: boolean = false;

function Start () {
    
}

function Update () {
    if(pole01Active && pole02Active && pole03Active && pole04Active && pole05Active && pole06Active && pole07Active){

        caveDoor.SetTrigger("OpenCaveDoor");
        caveLines.SetTrigger("CaveLinesOn");
        caveLines02.SetTrigger("CaveLinesOn");
        arcadeDoor.SetTrigger("CloseArcadeDoor");
        caveSound01.enabled = true;
        caveSound02.enabled = true;
        achievementScript.theresMore = true;
        pole01Active = false;
    }    

}