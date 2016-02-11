#pragma strict

import UnityEngine.UI;

public var firstRun: boolean = false;
public var badSecret: boolean = false;
public var findArcade: boolean = false;
public var theresMore: boolean = false;
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

function Update () {

    if(firstRun){
        AchievementTitle.text = "Through the maze";
        AchievementDescription.text = "finish your first run through the maze";
        achievementAnim.SetTrigger("AchievementUnlocked");
        pauseAchiev01.text = "Through the maze";
        pauseAchiev01.color = Color.white;
        pauseIcon01.color = Color.white;
    }
    if(badSecret){
        AchievementTitle.text = "Bad at keeping secrets";
        AchievementDescription.text = "Open the door to the garden";
        achievementAnim.SetTrigger("AchievementUnlocked");
        pauseAchiev02.text = "Bad at keeping secrets";
        pauseAchiev02.color = Color.white;
        pauseIcon02.color = Color.white;
    }
    if(findArcade){
        AchievementTitle.text = "It's Breakout!!!";
        AchievementDescription.text = "Find the arcade machine";
        achievementAnim.SetTrigger("AchievementUnlocked");
        pauseAchiev03.text = "It's Breakout!!!";
        pauseAchiev03.color = Color.white;
        pauseIcon03.color = Color.white;
    }
    if(theresMore){
        AchievementTitle.text = "There's more to see";
        AchievementDescription.text = "Get to the cave";
        achievementAnim.SetTrigger("AchievementUnlocked");
        pauseAchiev04.text = "There's more to see";
        pauseAchiev04.color = Color.white;
        pauseIcon04.color = Color.white;
    }
    if(finishGame){
        AchievementTitle.text = "Thanks for playing";
        AchievementDescription.text = "Finish the game";
        achievementAnim.SetTrigger("AchievementUnlocked");
        pauseAchiev05.text = "Thanks for playing";
        pauseAchiev05.color = Color.white;
        pauseIcon05.color = Color.white;
    }
    

}