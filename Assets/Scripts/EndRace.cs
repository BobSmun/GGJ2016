using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRace : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
