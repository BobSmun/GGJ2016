using UnityEngine;
using System.Collections.Generic;

public class LeaderBoard : MonoBehaviour
{
    public Transform LeaderboardEntry;

    public void GenerateLeaderBoard(float time)
    {
        gameObject.SetActive(true);

        LeaderboardEntry.Find("Time").GetComponent<UnityEngine.UI.Text>().text = time.ToString("F2");
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
