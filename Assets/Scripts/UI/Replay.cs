using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
	
	private GameObject player;

	public void ReplayGame()
    {
		
		Spawn.Instance.SpawnPlayer();
        Time.timeScale = 1;
        player = GameObject.FindGameObjectWithTag ("Player");
		Destroy(player);
    }
}