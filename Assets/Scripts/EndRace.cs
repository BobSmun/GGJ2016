using UnityEngine;
using System.Collections;

public class EndRace : MonoBehaviour
{
    public Transform Leaderboard;

	public GameObject GiantDoor1;
	public GameObject GiantDoor2;
	private Animator doorAnim1;
	private Animator doorAnim2;

	void Start() {
		doorAnim1 = GiantDoor1.GetComponent<Animator> ();
		doorAnim2 = GiantDoor2.GetComponent<Animator> ();
	}

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

			//OPEN DOORS
			doorAnim1.SetTrigger("OpenDoorLarge");
			doorAnim2.SetTrigger("OpenDoorLarge");


            LeaderBoard lb = Leaderboard.GetComponent<LeaderBoard>();
            lb.GenerateLeaderBoard(t.TimeCounter);
        }
        else
        {
            Destroy(col.gameObject);
        }
    }
}
