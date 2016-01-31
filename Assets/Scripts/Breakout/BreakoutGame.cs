using UnityEngine;
using System.Collections;

public enum BreakoutGameState { playing, won, lost, prestart };

public class BreakoutGame : MonoBehaviour
{
    public static BreakoutGame SP;
	public GameObject SpawnPoint;

    public Transform ballPrefab;

    private int totalBlocks;
    private int blocksHit;
    private BreakoutGameState gameState;


    void Awake()
    {
        SP = this;
        blocksHit = 0;
		gameState = BreakoutGameState.prestart;
        totalBlocks = GameObject.FindGameObjectsWithTag("Pickup").Length;
        Time.timeScale = 1.0f;
    }

	public void StartGame()
	{
		gameState = BreakoutGameState.playing;
		SpawnBall ();
	}

    void SpawnBall()
    {
		Instantiate(ballPrefab, SpawnPoint.transform.position, Quaternion.identity);
    }

    public void HitBlock()
    {
        blocksHit++;
        
        if (blocksHit >= totalBlocks)
        {
            WonGame();
        }
    }

    public void WonGame()
    {
        gameState = BreakoutGameState.won;
    }

    public void LostBall()
    {
        int ballsLeft = GameObject.FindGameObjectsWithTag("Player").Length;
        if(ballsLeft<=1){
            //Was the last ball..
            SetGameOver();
        }
    }

    public void SetGameOver()
    {
        gameState = BreakoutGameState.lost;
    }
}
