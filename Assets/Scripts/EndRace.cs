using UnityEngine;
using System.Collections;

public class EndRace : MonoBehaviour
{
    public Transform Leaderboard;


    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
			col.gameObject.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().m_MouseLook.SetCursorLock (false);

            //Player object has camera, so we don't want to destroy it

			//pause the game
			Time.timeScale = 0;

            Timer t = FindObjectOfType<Timer>();
            t.gameObject.SetActive(false);

            Spawn.Instance.SaveGhost();
            Spawn.Instance.KillCurrentGhosts();

			LeaderBoard lb = Leaderboard.GetComponent<LeaderBoard>();
			lb.GenerateLeaderBoard(t.TimeCounter);
        }
        else
        {
            //kill individual ghost when it reaches end
            Destroy(col.gameObject);
        }
    }
}
