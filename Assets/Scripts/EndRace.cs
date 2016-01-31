using UnityEngine;
using System.Collections;

public class EndRace : MonoBehaviour
{
    public Transform Leaderboard;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            col.gameObject.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_MouseLook.SetCursorLock(false);

            // ... destroy the player.
            Destroy(col.gameObject);

            Timer t = FindObjectOfType<Timer>();
            t.gameObject.SetActive(false);

            InputStreamReaderWriter control = col.gameObject.GetComponent<InputStreamReaderWriter>();
            Spawn.Instance.AddGhostData(control.input);
            Spawn.Instance.KillCurrentGhosts();

            LeaderBoard lb = Leaderboard.GetComponent<LeaderBoard>();
            lb.GenerateLeaderBoard(t.TimeCounter);
        }
        else
        {
            Destroy(col.gameObject);
        }
    }
}
