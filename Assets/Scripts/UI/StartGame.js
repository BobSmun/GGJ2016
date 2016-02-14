#pragma strict

import UnityEngine.SceneManagement;

function Update (){
    if (Input.anyKeyDown)
    {
       SceneManager.LoadScene(1);
    }
}