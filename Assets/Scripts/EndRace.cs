using UnityEngine;
using System.Collections;

public class EndRace : MonoBehaviour
{
    public Transform Leaderboard;


<<<<<<< HEAD
=======
	public GameObject GiantDoor1;
	public GameObject GiantDoor2;
	private Animator doorAnim1;
	private Animator doorAnim2;

	void Start() {
		doorAnim1 = GiantDoor1.GetComponent<Animator> ();
		doorAnim2 = GiantDoor2.GetComponent<Animator> ();
	}

>>>>>>> remotes/origin/master
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
<<<<<<< HEAD
			col.gameObject.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().m_MouseLook.SetCursorLock (false);
=======
            col.gameObject.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_MouseLook.SetCursorLock(false);
>>>>>>> remotes/origin/master

            // ... destroy the player.
            //Destroy(col.gameObject);

			//pause the game
			Time.timeScale = 0;

            Timer t = FindObjectOfType<Timer>();
            t.gameObject.SetActive(false);

            InputStreamReaderWriter control = col.gameObject.GetComponent<InputStreamReaderWriter>();
            Spawn.Instance.AddGhostData(control.input);
            Spawn.Instance.KillCurrentGhosts();



<<<<<<< HEAD
			LeaderBoard lb = Leaderboard.GetComponent<LeaderBoard>();
			lb.GenerateLeaderBoard(t.TimeCounter);

=======

			LeaderBoard lb = Leaderboard.GetComponent<LeaderBoard>();
			lb.GenerateLeaderBoard(t.TimeCounter);

			//OPEN DOORS
			doorAnim1.SetTrigger("OpenDoorLarge");
			doorAnim2.SetTrigger("OpenDoorLarge");








>>>>>>> remotes/origin/master

        }
        else
        {
            //Destroy(col.gameObject);
        }
    }
}
