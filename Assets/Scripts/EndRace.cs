using UnityEngine;
using System.Collections;

public class EndRace : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            // ... destroy the player.
            Destroy(col.gameObject);

            Timer t = FindObjectOfType<Timer>();
            t.enabled = false;

            // ... reload the level.
            StartCoroutine("ReloadGame");
        }
    }

    IEnumerator ReloadGame()
    {
        // ... pause briefly
        yield return new WaitForSeconds(0.1f);

        Spawn.Instance.SpawnPlayer();
    }
}
