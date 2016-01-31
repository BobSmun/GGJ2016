using UnityEngine;
using System.Collections.Generic;

public class LeaderData
{
    public float time;
    public string name;
}

public class LeaderBoard : MonoBehaviour
{
    private bool init = false;
    public Transform LeaderboardEntry_1;
    public Transform LeaderboardEntry_2;
    public Transform LeaderboardEntry_3;
    private List<LeaderData> scores = new List<LeaderData>();

    public void AddTime(float time, string name)
    {
        LeaderData entry = new LeaderData();
        entry.time = time;
        entry.name = name;
        scores.Add(entry);
        scores.Sort((x, y) => x.time.CompareTo(y.time));
    }

    public void GenerateLeaderBoard()
    {
        gameObject.SetActive(true);
        if(!init)
        {
            AddTime(1f, "Dave");
            AddTime(16f, "Bob");
            AddTime(31f, "John");

            init = true;
        }

        LeaderboardEntry_1.Find("Time").GetComponent<UnityEngine.UI.Text>().text = scores[0].time.ToString("F2");
        LeaderboardEntry_1.Find("Name").GetComponent<UnityEngine.UI.Text>().text = scores[0].name;

        LeaderboardEntry_2.Find("Time").GetComponent<UnityEngine.UI.Text>().text = scores[1].time.ToString("F2");
        LeaderboardEntry_2.Find("Name").GetComponent<UnityEngine.UI.Text>().text = scores[1].name;

        LeaderboardEntry_3.Find("Time").GetComponent<UnityEngine.UI.Text>().text = scores[2].time.ToString("F2");
        LeaderboardEntry_3.Find("Name").GetComponent<UnityEngine.UI.Text>().text = scores[2].name;
    }
}
