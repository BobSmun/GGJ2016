using UnityEngine;
using System.Collections;

public class EndRace : MonoBehaviour
{

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
            // ... destroy the player.
            Destroy(col.gameObject);

            Timer t = FindObjectOfType<Timer>();
            t.enabled = false;

            InputStreamReaderWriter control = col.gameObject.GetComponent<InputStreamReaderWriter>();
            Spawn.Instance.AddGhostData(control.input);


			//OPEN DOORS
			doorAnim1.SetTrigger("OpenDoorLarge");
			doorAnim2.SetTrigger("OpenDoorLarge");


            // ... reload the level.
            StartCoroutine("ReloadGame");
        }
        else
        {
            Destroy(col.gameObject);
        }
    }

    IEnumerator ReloadGame()
    {
        // ... pause briefly
        yield return new WaitForSeconds(0.1f);
        Spawn.Instance.KillCurrentGhosts();
        Spawn.Instance.SpawnPlayer();
    }
}
