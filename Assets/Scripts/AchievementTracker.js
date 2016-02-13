#pragma strict

import UnityEngine.UI;

public var firstRun: boolean = false;
public var badSecret: boolean = false;
public var playArcade: boolean = false;
public var theresMore: boolean = false;
public var octopusIdol: boolean = false;
public var finishGame: boolean = false;


var achievementAnim: Animator;
var AchievementTitle: Text;
var AchievementDescription: Text;
var pauseAchiev01: Text;
var pauseIcon01: Image;
var pauseAchiev02: Text;
var pauseIcon02: Image;
var pauseAchiev03: Text;
var pauseIcon03: Image;
var pauseAchiev04: Text;
var pauseIcon04: Image;
var pauseAchiev05: Text;
var pauseIcon05: Image;
var pauseAchiev06: Text;
var pauseIcon06: Image;

function Update () {

    if(firstRun){
        AchievementTitle.text = "Through the maze";
        AchievementDescription.text = "Finish your first run of the maze";
        achievementAnim.SetTrigger("AchievementUnlocked");        
        pauseAchiev01.text = "Through the maze";
        pauseAchiev01.color = Color.white;
        pauseIcon01.color = Color.white;
        firstRun = false;
    }
    if(badSecret){
        AchievementTitle.text = "Bad at keeping secrets";
        AchievementDescription.text = "Enter the garden";
        achievementAnim.SetTrigger("AchievementUnlocked");
        pauseAchiev02.text = "Bad at keeping secrets";
        pauseAchiev02.color = Color.white;
        pauseIcon02.color = Color.white;
        badSecret = false;
    }
    if(playArcade){
        AchievementTitle.text = "Breakout";
        AchievementDescription.text = "Turn off the arcade machine";
        achievementAnim.SetTrigger("AchievementUnlocked");
        pauseAchiev03.text = "Breakout";
        pauseAchiev03.color = Color.white;
        pauseIcon03.color = Color.white;
        playArcade = false;
    }
    if(theresMore){
        AchievementTitle.text = "Following Steps";
        AchievementDescription.text = "Unlock the cave exit";
        achievementAnim.SetTrigger("AchievementUnlocked");
        pauseAchiev04.text = "Following Steps";
        pauseAchiev04.color = Color.white;
        pauseIcon04.color = Color.white;
        theresMore = false;
    }
    if(octopusIdol){
        AchievementTitle.text = "Octopus Idol";
        AchievementDescription.text = "Reach the heart of the mountain";
        achievementAnim.SetTrigger("AchievementUnlocked");
        pauseAchiev05.text = "Octopus Idol";
        pauseAchiev05.color = Color.white;
        pauseIcon05.color = Color.white;
        octopusIdol = false;
    }
    if(finishGame){
        AchievementTitle.text = "Ritual Complete";
        AchievementDescription.text = "Finish the game";
        achievementAnim.SetTrigger("AchievementUnlocked");
        pauseAchiev06.text = "Ritual Complete";
        pauseAchiev06.color = Color.white;
        pauseIcon06.color = Color.white;
        finishGame = false;
    }
    

}