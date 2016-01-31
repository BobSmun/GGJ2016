using UnityEngine;
using System.Collections;

public class EndRace : MonoBehaviour
{
    public Transform Leaderboard;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            // ... destroy the player.
            Destroy(col.gameObject);

            Timer t = FindObjectOfType<Timer>();
            t.enabled = false;
            t.gameObject.SetActive(false);

            InputStreamReaderWriter control = col.gameObject.GetComponent<InputStreamReaderWriter>();
            Spawn.Instance.AddGhostData(control.input);
            Spawn.Instance.KillCurrentGhosts();

            LeaderBoard lb = Leaderboard.GetComponent<LeaderBoard>();
            lb.AddTime(t.TimeCounter, "You");
            lb.GenerateLeaderBoard();
        }
        else
        {
            Destroy(col.gameObject);
        }
    }
}
