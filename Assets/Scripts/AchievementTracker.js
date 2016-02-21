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
var AchievementIcon: Image;
var pauseAchiev01: Text;
var achievIcon01: Sprite;
var pauseIcon01: Image;
var pauseAchiev02: Text;
var achievIcon02: Sprite;
var pauseIcon02: Image;
var pauseAchiev03: Text;
var achievIcon03: Sprite;
var pauseIcon03: Image;
var pauseAchiev04: Text;
var achievIcon04: Sprite;
var pauseIcon04: Image;
var pauseAchiev05: Text;
var achievIcon05: Sprite;
var pauseIcon05: Image;
var pauseAchiev06: Text;
var achievIcon06: Sprite;
var pauseIcon06: Image;

function Update () {

    if(firstRun){
        AchievementTitle.text = "Through the maze";
        AchievementDescription.text = "Finish your first run of the maze";
        achievementAnim.SetTrigger("AchievementUnlocked");  
        AchievementIcon.sprite = achievIcon01;
        pauseAchiev01.text = "Through the maze";
        pauseAchiev01.color = Color.white;
        pauseIcon01.color = Color.white;
        firstRun = false;
    }
    if(badSecret){
        AchievementTitle.text = "Bad at keeping secrets";
        AchievementDescription.text = "Enter the garden";
        achievementAnim.SetTrigger("AchievementUnlocked");
        AchievementIcon.sprite = achievIcon02;
        pauseAchiev02.text = "Bad at keeping secrets";
        pauseAchiev02.color = Color.white;
        pauseIcon02.color = Color.white;
        badSecret = false;
    }
    if(playArcade){
        AchievementTitle.text = "Breakout";
        AchievementDescription.text = "Turn off the arcade machine";
        achievementAnim.SetTrigger("AchievementUnlocked");
        AchievementIcon.sprite = achievIcon03;
        pauseAchiev03.text = "Breakout";
        pauseAchiev03.color = Color.white;
        pauseIcon03.color = Color.white;
        playArcade = false;
    }
    if(theresMore){
        AchievementTitle.text = "Activation Complete";
        AchievementDescription.text = "Unlock the cave exit";
        achievementAnim.SetTrigger("AchievementUnlocked");
        AchievementIcon.sprite = achievIcon04;
        pauseAchiev04.text = "Activation complete";
        pauseAchiev04.color = Color.white;
        pauseIcon04.color = Color.white;
        theresMore = false;
    }
    if(octopusIdol){
        AchievementTitle.text = "Don't trust your eyes";
        AchievementDescription.text = "Reach the entrance of the octopus idol";
        achievementAnim.SetTrigger("AchievementUnlocked");
        AchievementIcon.sprite = achievIcon05;
        pauseAchiev05.text = "Don't trust your eyes";
        pauseAchiev05.color = Color.white;
        pauseIcon05.color = Color.white;
        octopusIdol = false;
    }
    if(finishGame){
        AchievementTitle.text = "Ritual Complete";
        AchievementDescription.text = "Finish the game";
        achievementAnim.SetTrigger("AchievementUnlocked");
        AchievementIcon.sprite = achievIcon06;
        pauseAchiev06.text = "Ritual Complete";
        pauseAchiev06.color = Color.white;
        pauseIcon06.color = Color.white;
        finishGame = false;
    }
    

}